using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;
using MsgPack2;

namespace PCRClient;

internal static class PackHelper
{
    private static readonly Aes aes;
    private static readonly byte[] iv = Encoding.UTF8.GetBytes("ha4nBYA2APUD6Uv1");
    static PackHelper()
    {
        aes = Aes.Create("AesManaged") ?? throw new InvalidOperationException();
        aes.Mode = CipherMode.CBC;
        aes.KeySize = 256;
        aes.BlockSize = 128;
        aes.Padding = PaddingMode.PKCS7;
    }

    public static JToken Unpack(byte[] crypted, out byte[] key)
    {
        var n = crypted.Length;
        key = crypted.Skip(n - 32).ToArray();
        var transform = aes.CreateDecryptor(key, iv);
        var buf = transform.TransformFinalBlock(crypted.Take(n - 32).ToArray(), 0, n - 32);
        return JToken.FromObject(BoxingPacker.Unpack(buf));
    }

    public static string Encrypt(string content, byte[] key)
    {

        var transform = aes.CreateEncryptor(key, iv);

        var buf = Encoding.UTF8.GetBytes(content);

        return Convert.ToBase64String(transform.TransformFinalBlock(buf, 0, buf.Length).Concat(key).ToArray());
    }

    public static byte[] CreateKey() => Encoding.ASCII.GetBytes(string.Concat(Guid.NewGuid().ToByteArray().Select(b => b.ToString("x2"))));

    public static byte[] Pack(JToken token, byte[] key)
    {
        var transform = aes.CreateEncryptor(key, iv);

        static object? Mapper(JToken o)
        {
            return o switch
            {
                JArray arr => arr.Select(Mapper).ToArray(),
                JObject obj => obj.Properties().ToDictionary(prop => prop.Name, prop => Mapper(prop.Value)),
                _ => o.ToObject<object>()
            };
        }
            
        var buf = BoxingPacker.Pack(Mapper(token));

        return transform.TransformFinalBlock(buf, 0, buf.Length).Concat(key).ToArray();
    }
}
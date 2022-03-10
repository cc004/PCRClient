using System.Security.Cryptography;
using System.Text;

namespace PCRClient;

public static class Utils
{
    public static async Task<byte[]> ReadAllBytes(this Stream stream)
    {
        await using var ms = new MemoryStream();
        int b;

        do
        {
            var t = new byte[1024];
            b = await stream.ReadAsync(t, 0, 1024);
            if (b > 0)
                ms.Write(t, 0, b);
        } while (b > 0);

        return ms.ToArray();
    }
    public static string CalcMd5(byte[] content)
    {
        using var md5 = MD5.Create();
        return string.Concat(md5.ComputeHash(content).Select(b => $"{b:x2}"));
    }
    public static string CalcMd5(string content) => CalcMd5(Encoding.UTF8.GetBytes(content));
}
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

    private static readonly DateTime dateTimeStart = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);

    public static DateTime ToDateTime(this long timeStamp)
    {
        return dateTimeStart.Add(new TimeSpan(10000 * timeStamp));
    }

    public static long ToTimestamp(this DateTime time)
    {
        return (long)(time - dateTimeStart).TotalMilliseconds;
    }
}
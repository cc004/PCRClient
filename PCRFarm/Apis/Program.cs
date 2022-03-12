namespace PCRFarm.Apis
{
    internal class Program
    {
        internal static void Main2(ushort port)
        {
            try
            {
                CreateHostBuilder(port).Build().Run();
            }
            catch
            {

            }
        }

        public static IHostBuilder CreateHostBuilder(ushort port) =>
            Host.CreateDefaultBuilder(Array.Empty<string>())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls($"http://*:{port}/").UseStartup<Startup>();
                });
    }
}

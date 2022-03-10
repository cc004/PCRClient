using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace PCRClient
{
    public class CaptchaResult
    {
        internal readonly string validate, gt_user_id, challenge;

        internal CaptchaResult(string validate, string gtUserId, string challenge)
        {
            this.validate = validate;
            gt_user_id = gtUserId;
            this.challenge = challenge;
        }
    }

    public class CaptchaRequest
    {
        public string? challenge, gt, gt_user_id;
        
        public void CreateResult(string validate) => new CaptchaResult(validate, gt_user_id!, challenge!);
    }

    public static class BsGameSdk
    {
        internal class BSdkLoginResult
        {
            public string? uid;
            public string? access_key;
            public string? message;
            public int code;
        }

        private const string Url = "https://line1-sdk-center-login-sh.biligame.net/";
        private static readonly HttpClient _client = new();
        // 祖传阴间代码，懒得改了，反正b站登录不是重点
        private static readonly string modelRsa = "{\"operators\":\"5\",\"merchant_id\":\"1\",\"isRoot\":\"0\",\"domain_switch_count\":\"0\",\"sdk_type\":\"1\",\"sdk_log_type\":\"1\",\"timestamp\":\"1613035485639\",\"support_abis\":\"x86,armeabi-v7a,armeabi\",\"access_key\":\"\",\"sdk_ver\":\"3.4.2\",\"oaid\":\"\",\"dp\":\"1280*720\",\"original_domain\":\"\",\"imei\":\"227656364311444\",\"version\":\"1\",\"udid\":\"KREhESMUIhUjFnJKNko2TDQFYlZkB3cdeQ==\",\"apk_sign\":\"e89b158e4bcf988ebd09eb83f5378e87\",\"platform_type\":\"3\",\"old_buvid\":\"XZA2FA4AC240F665E2F27F603ABF98C615C29\",\"android_id\":\"84567e2dda72d1d4\",\"fingerprint\":\"\",\"mac\":\"08:00:27:53:DD:12\",\"server_id\":\"1592\",\"domain\":\"line1-sdk-center-login-sh.biligame.net\",\"app_id\":\"1370\",\"version_code\":\"90\",\"net\":\"4\",\"pf_ver\":\"6.0.1\",\"cur_buvid\":\"XZA2FA4AC240F665E2F27F603ABF98C615C29\",\"c\":\"1\",\"brand\":\"Android\",\"client_timestamp\":\"1613035486888\",\"channel_id\":\"1\",\"uid\":\"\",\"game_id\":\"1370\",\"ver\":\"2.4.10\",\"model\":\"MuMu\"}";
        private static readonly string modelLogin = "{\"operators\":\"5\",\"merchant_id\":\"1\",\"isRoot\":\"0\",\"domain_switch_count\":\"0\",\"sdk_type\":\"1\",\"sdk_log_type\":\"1\",\"timestamp\":\"1613035508188\",\"support_abis\":\"x86,armeabi-v7a,armeabi\",\"access_key\":\"\",\"sdk_ver\":\"3.4.2\",\"oaid\":\"\",\"dp\":\"1280*720\",\"original_domain\":\"\",\"imei\":\"227656364311444\",\"gt_user_id\":\"fac83ce4326d47e1ac277a4d552bd2af\",\"seccode\":\"\",\"version\":\"1\",\"udid\":\"KREhESMUIhUjFnJKNko2TDQFYlZkB3cdeQ==\",\"apk_sign\":\"e89b158e4bcf988ebd09eb83f5378e87\",\"platform_type\":\"3\",\"old_buvid\":\"XZA2FA4AC240F665E2F27F603ABF98C615C29\",\"android_id\":\"84567e2dda72d1d4\",\"fingerprint\":\"\",\"validate\":\"84ec07cff0d9c30acb9fe46b8745e8df\",\"mac\":\"08:00:27:53:DD:12\",\"server_id\":\"1592\",\"domain\":\"line1-sdk-center-login-sh.biligame.net\",\"app_id\":\"1370\",\"pwd\":\"rxwA8J+GcVdqa3qlvXFppusRg4Ss83tH6HqxcciVsTdwxSpsoz2WuAFFGgQKWM1+GtFovrLkpeMieEwOmQdzvDiLTtHeQNBOiqHDfJEKtLj7h1nvKZ1Op6vOgs6hxM6fPqFGQC2ncbAR5NNkESpSWeYTO4IT58ZIJcC0DdWQqh4=\",\"version_code\":\"90\",\"net\":\"4\",\"pf_ver\":\"6.0.1\",\"cur_buvid\":\"XZA2FA4AC240F665E2F27F603ABF98C615C29\",\"c\":\"1\",\"brand\":\"Android\",\"client_timestamp\":\"1613035509437\",\"channel_id\":\"1\",\"uid\":\"\",\"captcha_type\":\"1\",\"game_id\":\"1370\",\"challenge\":\"efc825eaaef2405c954a91ad9faf29a2\",\"user_id\":\"doo349\",\"ver\":\"2.4.10\",\"model\":\"MuMu\"}";
        private static readonly string modelCaptcha = "{\"operators\":\"5\",\"merchant_id\":\"1\",\"isRoot\":\"0\",\"domain_switch_count\":\"0\",\"sdk_type\":\"1\",\"sdk_log_type\":\"1\",\"timestamp\":\"1613035486182\",\"support_abis\":\"x86,armeabi-v7a,armeabi\",\"access_key\":\"\",\"sdk_ver\":\"3.4.2\",\"oaid\":\"\",\"dp\":\"1280*720\",\"original_domain\":\"\",\"imei\":\"227656364311444\",\"version\":\"1\",\"udid\":\"KREhESMUIhUjFnJKNko2TDQFYlZkB3cdeQ==\",\"apk_sign\":\"e89b158e4bcf988ebd09eb83f5378e87\",\"platform_type\":\"3\",\"old_buvid\":\"XZA2FA4AC240F665E2F27F603ABF98C615C29\",\"android_id\":\"84567e2dda72d1d4\",\"fingerprint\":\"\",\"mac\":\"08:00:27:53:DD:12\",\"server_id\":\"1592\",\"domain\":\"line1-sdk-center-login-sh.biligame.net\",\"app_id\":\"1370\",\"version_code\":\"90\",\"net\":\"4\",\"pf_ver\":\"6.0.1\",\"cur_buvid\":\"XZA2FA4AC240F665E2F27F603ABF98C615C29\",\"c\":\"1\",\"brand\":\"Android\",\"client_timestamp\":\"1613035487431\",\"channel_id\":\"1\",\"uid\":\"\",\"game_id\":\"1370\",\"ver\":\"2.4.10\",\"model\":\"MuMu\"}";
        static BsGameSdk()
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 BSGameSDK");
        }

        private static async Task<JObject> Post(string url, Dictionary<string, string> data)
        {
            return JObject.Parse(await (await _client.PostAsync(Url + url, new FormUrlEncodedContent(data))).Content.ReadAsStringAsync());
        }

        private static void SignData(Dictionary<string, string> data)
        {
            data["timestamp"] = DateTime.Now.ToTimestamp().ToString();
            data["client_timestamp"] = DateTime.Now.ToTimestamp().ToString();
            data["sign"] = Utils.CalcMd5(data.OrderBy(p => p.Key)
                .Aggregate(new StringBuilder(), (sb, p) => sb.Append(p.Value)) + "fe8aac4e02f845b8ad67c427d48bfaf1");
        }

        public static string EncryptRSA(string msg, string key)
        {
            using var sr = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(key)));
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1");
            cipher.Init(true, (ICipherParameters)new PemReader(sr).ReadObject());
            var bytes = Encoding.UTF8.GetBytes(msg);
            return Convert.ToBase64String(cipher.DoFinal(bytes));
        }

        private static async Task<CaptchaRequest> GetCaptcha()
        {
            var data = JObject.Parse(modelCaptcha).ToObject<Dictionary<string, string>>()!;
            SignData(data);
            return (await Post("api/client/start_captcha", data)).ToObject<CaptchaRequest>()!;
        }

        private static async Task<JObject> Login(string account, string password, CaptchaResult? captcha = null)
        {
            var data = JObject.Parse(modelRsa).ToObject<Dictionary<string, string>>()!;
            SignData(data);
            var rsa = await Post("api/client/rsa", data);
            var key = rsa.Value<string>("rsa_key")!;
            data = JObject.Parse(captcha == null ? modelLogin : modelRsa).ToObject<Dictionary<string, string>>()!;
            data["access_key"] = string.Empty;
            data["uid"] = string.Empty;
            data["user_id"] = account;
            if (captcha != null)
            {
                data["gt_user_id"] = captcha.gt_user_id!;
                data["challenge"] = captcha.challenge!;
                data["validate"] = captcha.validate!;
                data["seccode"] = captcha.validate + "|jordan";
            }
            else
            {
                data["gt_user_id"] = string.Empty;
                data["challenge"] = string.Empty;
                data["validate"] = string.Empty;
            }
            data["pwd"] = EncryptRSA(rsa.Value<string>("hash") + password, key);
            SignData(data);
            return await Post("api/client/login", data);
        }

        internal static async Task<BSdkLoginResult> Login(AccountInfo info, Func<CaptchaRequest, Task<CaptchaResult>> validator)
        {
            var result = await Login(info.username!, info.password!);
            if (result.ContainsKey("access_key")) return result.ToObject<BSdkLoginResult>()!;
            return (await Login(info.username!, info.password!, await validator(await GetCaptcha())))
                .ToObject<BSdkLoginResult>()!;
        }
    }
}

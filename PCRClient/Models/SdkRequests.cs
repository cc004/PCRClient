// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
#pragma warning disable CS8618

namespace PCRClient.Models
{
    public class ToolSdkLoginRequest : Request<ToolSdkLoginResponse>
    {
        public string? uid;
        public string? access_key;
        public string platform;
        public string channel_id;
        public string challenge;
        public string validate;
        public string seccode;
        public string captcha_type;
        public string image_token;
        public string captcha_code;

        internal override string Url => "tool/sdk_login";
        internal override bool Crypt => true;
    }

    public class ToolSdkLoginResponse : ResponseBase
    {
    }

    public class CheckGameStartRequest : Request<CheckGameStartResponse>
    {
        public int apptype;
        public string campaign_data;
        public int campaign_user;
        internal override string Url => "check/game_start";
        internal override bool Crypt => true;
    }

    public class CheckGameStartResponse : ResponseBase
    {
    }

    public class SourceIniIndexRequest : Request<SourceIniIndexResponse>
    {
        internal override string Url => "source_ini/index";
        internal override bool Crypt => false;
    }

    public class SourceIniIndexResponse : ResponseBase
    {
        public string[] server;
    }
    public class SourceIniGetMaintenanceStatusRequest : Request<SourceIniGetMaintenanceStatusResponse>
    {
        internal override string Url => "source_ini/get_maintenance_status?format=json";
        internal override bool Crypt => false;
    }

    public class SourceIniGetMaintenanceStatusResponse : ResponseBase
    {
        public int json;
        public int encrypt;
        public int res_http_type;
        public int node_type;
        public int silence_download_size;
        public string res_ver;
        public string execl_ver;
        public string res_key;
        public string start_time;
        public string manifest_ver;
        public string required_manifest_ver;
        public string movie_ver;
        public string sound_ver;
        public string patch_ver;
        public string[] resource;
    }
}

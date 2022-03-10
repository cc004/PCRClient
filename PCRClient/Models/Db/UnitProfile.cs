using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitProfile
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public string Age { get; set; } = null!;
        public string Guild { get; set; } = null!;
        public string Race { get; set; } = null!;
        public string Height { get; set; } = null!;
        public string Weight { get; set; } = null!;
        public string BirthMonth { get; set; } = null!;
        public string BirthDay { get; set; } = null!;
        public string BloodType { get; set; } = null!;
        public string Favorite { get; set; } = null!;
        public string Voice { get; set; } = null!;
        public long VoiceId { get; set; }
        public string CatchCopy { get; set; } = null!;
        public string SelfText { get; set; } = null!;
        public string GuildId { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ExperienceTeam
    {
        public long TeamLevel { get; set; }
        public long TotalExp { get; set; }
        public long MaxStamina { get; set; }
        public long OverLimitStamina { get; set; }
        public long RecoverStaminaCount { get; set; }
    }
}

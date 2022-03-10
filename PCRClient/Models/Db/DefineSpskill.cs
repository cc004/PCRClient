using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class DefineSpskill
    {
        public long LinkSkillSlot { get; set; }
        public long SpSkillId { get; set; }
        public long BaseSkillId { get; set; }
        public long SkillCategory { get; set; }
    }
}

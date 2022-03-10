using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CustomMypage
    {
        public long StillId { get; set; }
        public long GroupId { get; set; }
        public long StillGroupId { get; set; }
        public string StillName { get; set; } = null!;
        public long VerticalStillFlg { get; set; }
        public long ScrollDirection { get; set; }
    }
}

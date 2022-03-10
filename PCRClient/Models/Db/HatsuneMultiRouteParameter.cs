using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneMultiRouteParameter
    {
        public long Id { get; set; }
        public long QuestId { get; set; }
        public long Type { get; set; }
        public long Param1 { get; set; }
        public long Param2 { get; set; }
        public long Param3 { get; set; }
        public string Text1 { get; set; } = null!;
    }
}

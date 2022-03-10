using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class Tip
    {
        public long Id { get; set; }
        public long Value { get; set; }
        public long TipsIndex { get; set; }
        public string Title { get; set; } = null!;
    }
}

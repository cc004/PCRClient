using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneDiaryScript
    {
        public long Id { get; set; }
        public long DiaryId { get; set; }
        public long SeqNum { get; set; }
        public long Type { get; set; }
        public string DiaryText { get; set; } = null!;
        public long TextAnimationSpeed { get; set; }
        public string SheetName { get; set; } = null!;
        public string CueName { get; set; } = null!;
        public long Command { get; set; }
        public double CommandParam { get; set; }
    }
}

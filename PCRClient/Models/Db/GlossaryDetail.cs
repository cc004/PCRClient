using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class GlossaryDetail
    {
        public long GlossaryId { get; set; }
        public long GlossaryCategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long UnlockStoryId { get; set; }
        public long CategoryType { get; set; }
        public long DispOrder { get; set; }
    }
}

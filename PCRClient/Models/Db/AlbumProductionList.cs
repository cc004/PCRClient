using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class AlbumProductionList
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long Type { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}

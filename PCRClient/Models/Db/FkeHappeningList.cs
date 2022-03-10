using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class FkeHappeningList
    {
        public long HappeningId { get; set; }
        public string HappeningName { get; set; } = null!;
    }
}

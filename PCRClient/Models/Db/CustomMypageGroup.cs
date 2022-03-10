using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CustomMypageGroup
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UekDrama
    {
        public long CommandId { get; set; }
        public long DramaId { get; set; }
        public long CommandType { get; set; }
        public string Param01 { get; set; } = null!;
        public string Param02 { get; set; } = null!;
        public string Param03 { get; set; } = null!;
        public string Param04 { get; set; } = null!;
        public string Param05 { get; set; } = null!;
        public string Param06 { get; set; } = null!;
        public string Param07 { get; set; } = null!;
        public string Param08 { get; set; } = null!;
    }
}

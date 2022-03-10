using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SrtAction
    {
        public string ActionName { get; set; } = null!;
        public string InoriAction { get; set; } = null!;
        public string DragonAction { get; set; } = null!;
        public string KayaAction { get; set; } = null!;
        public string HomareAction { get; set; } = null!;
        public long TalkTextType { get; set; }
        public string TalkText { get; set; } = null!;
        public string VoiceList { get; set; } = null!;
    }
}

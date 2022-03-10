using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomReleaseDatum
    {
        public long SystemId { get; set; }
        public long StoryId { get; set; }
        public long PreStoryId { get; set; }
    }
}

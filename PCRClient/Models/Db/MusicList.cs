using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class MusicList
    {
        public long MusicId { get; set; }
        public string ListName { get; set; } = null!;
        public double FontSize { get; set; }
        public string PreShopStart { get; set; } = null!;
        public string ShopStart { get; set; } = null!;
        public string ShopEnd { get; set; } = null!;
        public long StoryId { get; set; }
        public long CostItemNum { get; set; }
        public long Sort { get; set; }
        public string Kana { get; set; } = null!;
        public string IosUrl { get; set; } = null!;
        public string AndroidUrl { get; set; } = null!;
        public string DmmUrl { get; set; } = null!;
    }
}

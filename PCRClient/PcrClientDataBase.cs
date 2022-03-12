using PCRClient.Models;

namespace PCRClient
{
    public class PcrClientDataBase : PcrClientSessionBase
    {
        public HashSet<int> FinishedQuest { get; } = new();
        public int Jewel { get; private set; }
        public int ClanId { get; private set; }
        public int DonationNum { get; private set; }
        public int TeamLevel { get; private set; }
        public int Stamina { get; private set; }
        public bool ClanUnlocked => FinishedQuest.Any(q => q == 11003001);
        public string? Name { get; private set; }

        public InventoryList Inventory { get; } = new();

        protected PcrClientDataBase(EnvironmentInfo? info = null) : base(info)
        {
        }

        protected override async Task<T> Request<T>(Request<T> request)
        {
            var result = await base.Request(request);
            if (result is IClanId clan)
            {
                ClanId = clan.ClanId;
            }
            if (result is ILevel lvl)
            {
                TeamLevel = lvl.Level;
            }
            if (result is IJewel jwl)
            {
                Jewel = jwl.Jewel;
            }
            if (result is IUpdateInventory inv)
            {
                if (inv.ClearPrevious) Inventory.Clear();
                foreach (var item in inv.Inventory.Where(a => a != null).SelectMany(a => a!))
                    Inventory.Update(item);
            }
            if (result is IDonationNum dn)
            {
                DonationNum = dn.Num;
            }
            if (result is IName name)
            {
                Name = name.Name;
            }
            if (result is IStamina sta)
            {
                Stamina = sta.Stamina;
            }
            if (result is IClearedQuest q)
            {
                FinishedQuest.UnionWith(q.QuestIds);
            }

            return result;
        }

        protected override void Log(LogLevel level, string message)
        {
            Console.WriteLine($"[{level.ToString().ToLower()}] {Name ?? Account?.username}: {message}");
        }
    }
}

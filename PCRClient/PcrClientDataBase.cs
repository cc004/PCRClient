using PCRClient.Models;

namespace PCRClient
{
    public class PcrClientDataBase : PcrClientSessionBase
    {
        public int ClanId { get; private set; }
        public int TeamLevel { get; private set; }
        public bool ClanUnlocked { get; private set; }

        protected readonly InventoryList inventory = new();
        public IReadOnlyDictionary<InventoryType, int> Inventory => inventory;

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
            if (result is IUpdateInventory inv)
            {
                if (inv.ClearPrevious) inventory.Clear();
                foreach (var item in inv.Inventory.Where(a => a != null).SelectMany(a => a!))
                    inventory.Update(item);
            }
            if (result is IBasicData data)
            {
                ClanUnlocked = data.ClanUnlocked;
            }

            return result;
        }
    }
}

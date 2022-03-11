using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRClient.Models
{
    public record struct InventoryType
    {
        public int id;
        public eInventoryType type;

        public static implicit operator InventoryType(InventoryInfo info) => new()
        {
            id = info.id,
            type = info.type
        };
    }

    public class InventoryList : Dictionary<InventoryType, int>
    {
        public void Update(InventoryInfo item)
        {
            this[item] = item.stock;
        }

        public int Get(InventoryType type) => TryGetValue(type, out var val) ? val : 0;
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRClient.Models
{
    internal interface IClanId
    {
        int ClanId { get; }
    }

    internal interface ILevel
    {
        int Level { get; }
    }

    internal interface IName
    {
        string Name { get; }
    }
    internal interface IStamina
    {
        int Stamina { get; }
    }
    internal interface IJewel
    {
        int Jewel { get; }
    }

    internal interface IDonationNum
    {
        int Num { get; }
    }

    internal interface IBasicData
    {
        bool ClanUnlocked { get; }
    }

    internal interface IUpdateInventory
    {
        InventoryInfo[]?[] Inventory { get; }
        bool ClearPrevious => false;
    }
}

namespace PCRClient.Models;

public partial class QuestSkipResponse : IUpdateInventory
{
    public InventoryInfo[]?[] Inventory => new[]
    {
        item_list, bonus_reward_list, item_data
    }.Concat(quest_result_list.Select(q => q.reward_list)).ToArray();
}

public partial class LoadIndexResponse : IUpdateInventory
{
    public InventoryInfo[]?[] Inventory => new[]
    {
        item_list, material_list, user_equip
    };

    public bool ClearPrevious => true;
}

public partial class EquipDonateResponse : IUpdateInventory
{
    public InventoryInfo[]?[] Inventory => new[]
    {
        rewards, new[] {donate_equip}
    };
}
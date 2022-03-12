using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRClient.Models;

public partial class LoadIndexResponse : ILevel, IName
{
    public string Name => user_info.user_name;
    public int Level => user_info.team_level;
}

public partial class HomeIndexResponse : IClearedQuest
{
    public HashSet<int> QuestIds => quest_list.Where(q => q.result_type > 0).Select(q => q.quest_id).ToHashSet();
}
public partial class LoadIndexResponse : IJewel
{
    public int Jewel => user_jewel.free_jewel;
}

public partial class ShopRecoverStaminaResponse : IJewel
{
    public int Jewel => user_jewel.free_jewel;
}

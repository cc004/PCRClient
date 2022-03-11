using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRClient.Models;

public partial class LoadIndexResponse : ILevel
{
    public int Level => user_info.team_level;
}

public partial class HomeIndexResponse : IBasicData
{
    public bool ClanUnlocked => quest_list.Any(q => q.quest_id == 11003001 && q.result_type > 0);
}

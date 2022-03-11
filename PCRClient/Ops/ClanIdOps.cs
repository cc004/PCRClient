using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRClient.Models;

public partial class HomeIndexResponse : IClanId
{
    public int ClanId => user_clan.clan_id;
}

public partial class ClanInfoResponse : IClanId
{
    public int ClanId => clan.detail.clan_id;
}
public partial class ClanCreateResponse : IClanId
{
    public int ClanId => clan_id;
}
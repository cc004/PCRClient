using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRClient.Models;

public partial class LoadIndexResponse : IStamina
{
    public int Stamina => user_info.user_stamina;
}

public partial class QuestSkipResponse : IStamina
{
    public int Stamina => user_info.user_stamina;
}

public partial class ShopRecoverStaminaResponse : IStamina
{
    public int Stamina => user_info.user_stamina;
}
public partial class RoomReceiveItemAllResponse : IStamina
{
    public int Stamina => stamina_info.user_stamina;
}

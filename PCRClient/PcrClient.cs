using PCRClient.Models;
using PCRClient.Models.Db;
// ReSharper disable InconsistentNaming

namespace PCRClient;

// behaviour level client

public class PcrClient : PcrClientDataBase
{
    public async Task<ProfileGetResponse> GetProfile(long viewer_id)
    {
        return await Request(new ProfileGetRequest
        {
            target_viewer_id = viewer_id
        });
    }

    public async Task<ClanInviteResponse> InviteToClan(long viewer_id, string message = "")
    {
        return await Request(new ClanInviteRequest
        {
            invited_viewer_id = viewer_id,
            invite_message = message
        });
    }

    /// <summary>
    /// return null when failed, might indicates the invitation is in the next page
    /// </summary>
    /// <param name="clan_id"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    private async Task<ClanJoinResponse?> AcceptClanInvitation(int clan_id, int page = 0)
    {
        try
        {
            var result = await Request(new ClanJoinRequest
            {
                clan_id = clan_id,
                from_invite = (await Request(new UserInviteClanListRequest
                {
                    page = 0
                })).list.First(inv => inv.clan_id == clan_id).invite_id
            });
            await Request(new ClanInfoRequest()); // refresh clan id
            return result;
        }
        catch (InvalidOperationException)
        {
            return null;
        }
    }

    public async Task<ClanRemoveResponse> RemoveMember(long viewer_id, string message = "")
    {
        return await Request(new ClanRemoveRequest
        {
            clan_id = ClanId,
            remove_viewer_id = viewer_id
        });
    }

    public async Task InviteToClan(PcrClient other)
    {
        await InviteToClan(other.ViewerId);
        for (var page = 0; await other.AcceptClanInvitation(ClanId, page) == null && page < 5; ++page)
        {
        }
    }

    public async Task<ClanCreateResponse?> CreateClan(string clan_name = "一个名字", string description = "一个描述",
        eClanJoinCondition cond = eClanJoinCondition.ONLY_INVITATION,
        eClanActivityGuideline guideLine = eClanActivityGuideline.GUIDELINE_1)
    {
        return await Request(new ClanCreateRequest
        {
            activity = (int) guideLine,
            clan_battle_mode = 0,
            clan_name = clan_name,
            description = description,
            join_condition = (int) cond
        });
    }

    /// <summary>
    /// get_user_equip代表是否收集已经被捐赠的装备
    /// </summary>
    /// <param name="get_user_equip"></param>
    /// <returns>null代表无行会</returns>
    public async Task<ClanData?> GetCurrentClanInfo(int get_user_equip = 0)
    {
        if (ClanId == 0) return null;
        return (await Request(new ClanInfoRequest
        {
            clan_id = ClanId,
            get_user_equip = get_user_equip
        })).clan;
    }

    public async Task<EquipDonateResponse> DonateEquip(EquipRequests request, int times)
    {
        return await Request(new EquipDonateRequest
        {
            clan_id = ClanId,
            current_equip_num = inventory.Get(new (){id = request.equip_id, type = eInventoryType.Equip}),
            donation_num = times,
            message_id = request.message_id
        });
    }

    private static readonly InventoryType ticket = new() {id = 23001, type = eInventoryType.Item};
    public async Task<QuestSkipResponse> QuestSkip(int quest_id, int times)
    {
        return await Request(new QuestSkipRequest
        {
            current_ticket_num = inventory.Get(ticket),
            quest_id = quest_id,
            random_count = times
        });
    }

    public async Task<EquipRequests[]> GetEquipmentRequests()
    {
        return (await Request(new ClanChatInfoListRequest()
        {
            clan_id = ClanId,
            count = 100,
            direction = 1, // RequestDirection.UP
            search_date = "2099-12-31",
            start_message_id = 0,
            update_message_ids = Array.Empty<int>(),
            wait_interval = 3
        })).equip_requests;
    }

    public PcrClient(EnvironmentInfo info) : base(info)
    {
    }
}

public class AccountInfo
{
    public string? username, password;
    public int platform, channel;
}
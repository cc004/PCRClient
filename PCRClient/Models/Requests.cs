namespace PCRClient.Models;
// ReSharper disable InconsistentNaming
#pragma warning disable CS8618

public class AcceptAgreementRequest : Request<AcceptAgreementResponse>
{
    public int agreement_type;
    public int agreement_ver;
    public int policy_ver;
    internal override string Url => "check/accept_agreement";
}

public class AddUserTipsRequest : Request<AddUserTipsResponse>
{
    public int[] tips_id_list;
    internal override string Url => "tips/add_user_tips";
}

public class ArcadeBuyRequest : Request<ArcadeBuyResponse>
{
    public int arcade_id;
    public int room_coin;
    internal override string Url => "arcade/buy";
}

public class ArcadeReadStoryRequest : Request<ArcadeReadStoryResponse>
{
    public int story_id;
    internal override string Url => "arcade/read_story";
}

public class ArcadeStoryListRequest : Request<ArcadeStoryListResponse>
{
    public int arcade_id;
    internal override string Url => "arcade/story_list";
}

public class ArcadeSyncStoryListRequest : Request<ArcadeSyncStoryListResponse>
{
    public int arcade_id;
    public int[] story_id_list;
    internal override string Url => "arcade/sync_story_list";
}

public class ArcadeTopRequest : Request<ArcadeTopResponse>
{
    internal override string Url => "arcade/top";
}

public class ArenaApplyRequest : Request<ArenaApplyResponse>
{
    public long battle_viewer_id;
    public int opponent_rank;
    internal override string Url => "arena/apply";
}

public class ArenaCancelRequest : Request<ArenaCancelResponse>
{
    public long battle_viewer_id;
    internal override string Url => "arena/cancel";
}

public class ArenaFinishRequest : Request<ArenaFinishResponse>
{
    public int battle_id;
    public ArenaWaveResult[] arena_wave_result_list;
    public int is_skipped;
    internal override string Url => "arena/finish";
}

public class ArenaHistoryDamageRankingRequest : Request<ArenaHistoryDamageRankingResponse>
{
    public int log_id;
    internal override string Url => "arena/history_damage_ranking";
}

public class ArenaHistoryDetailRequest : Request<ArenaHistoryDetailResponse>
{
    public int log_id;
    internal override string Url => "arena/history_detail";
}

public class ArenaHistoryRequest : Request<ArenaHistoryResponse>
{
    internal override string Url => "arena/history";
}

public class ArenaInfoRequest : Request<ArenaInfoResponse>
{
    internal override string Url => "arena/info";
}

public class ArenaIntervalCancelRequest : Request<ArenaIntervalCancelResponse>
{
    internal override string Url => "arena/interval_cancel";
}

public class ArenaMoveGroupRequest : Request<ArenaMoveGroupResponse>
{
    public int group_id;
    internal override string Url => "arena/move_group";
}

public class ArenaRankingRequest : Request<ArenaRankingResponse>
{
    public int limit;
    public int page;
    internal override string Url => "arena/ranking";
}

public class ArenaReplayRequest : Request<ArenaReplayResponse>
{
    public int log_id;
    internal override string Url => "arena/replay";
}

public class ArenaResetBattleNumberRequest : Request<ArenaResetBattleNumberResponse>
{
    internal override string Url => "arena/reset_battle_number";
}

public class ArenaSearchRequest : Request<ArenaSearchResponse>
{
    internal override string Url => "arena/search";
}

public class ArenaStartRequest : Request<ArenaStartResponse>
{
    public string token;
    public long battle_viewer_id;
    public int remain_battle_number;
    public int disable_skin;
    internal override string Url => "arena/start";
}

public class ArenaTimeRewardAcceptRequest : Request<ArenaTimeRewardAcceptResponse>
{
    internal override string Url => "arena/time_reward_accept";
}

public class AutomaticEnhanceRequest : Request<AutomaticEnhanceResponse>
{
    public int unit_id;
    public ItemInfo[] item_list;
    public UserEquipParameterIdCount[] equip_recipe_list;
    public int[] equip_slot_num_list;
    public SkillLevelUpDetail[] skill_levelup_list;
    public int excludes_equip;
    internal override string Url => "unit/automatic_enhance";
}

public class AutomaticEquipEnhanceRequest : Request<AutomaticEquipEnhanceResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public int current_enhancement_pt;
    public InventoryInfoPost[] item_list;
    public ShopBuyInfo[] buy_item_list;
    internal override string Url => "equipment/automatic_enhance";
}

public class AutomaticEquipEnhanceUniqueRequest : Request<AutomaticEquipEnhanceUniqueResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public int current_enhancement_pt;
    public InventoryInfoPost[] item_list;
    public ShopBuyInfo[] buy_item_list;
    internal override string Url => "equipment/automatic_enhance_unique";
}

public class ChangeRarityRequest : Request<ChangeRarityResponse>
{
    public ChangeRarityUnit[] change_rarity_unit_list;
    internal override string Url => "unit/change_rarity";
}

public class ChangeRoleRequest : Request<ChangeRoleResponse>
{
    public RoleInfo[] role_info;
    internal override string Url => "clan/change_role";
}

public class ChangeSkinRequest : Request<ChangeSkinResponse>
{
    public SkinDataForRequest skin_data_for_request;
    internal override string Url => "unit/change_skin";
}

public class CharaETicketExchangeRequest : Request<CharaETicketExchangeResponse>
{
    public int ticket_id;
    public int ticket_count;
    public int unit_id;
    internal override string Url => "chara_e_ticket/exchange";
}

public class CharaETicketRewardsRequest : Request<CharaETicketRewardsResponse>
{
    public int ticket_id;
    internal override string Url => "chara_e_ticket/rewards";
}

public class CheckAgreementRequest : Request<CheckAgreementResponse>
{
    internal override string Url => "check/check_agreement";
}

public class CheckExistClanRequest : Request<CheckExistClanResponse>
{
    internal override string Url => "check/exist_clan";
}

public class ClanBattleBossHistoryRequest : Request<ClanBattleBossHistoryResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int period;
    public int page;
    internal override string Url => "clan_battle/boss_history";
}

public class ClanBattleBossInfoRequest : Request<ClanBattleBossInfoResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int lap_num;
    public int order_num;
    internal override string Url => "clan_battle/boss_info";
}

public class ClanBattleBossRankingInClanRequest : Request<ClanBattleBossRankingInClanResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int month;
    internal override string Url => "clan_battle/boss_ranking_in_clan";
}

public class ClanBattleConfirmRehearsalMyLogRequest : Request<ClanBattleConfirmRehearsalMyLogResponse>
{
    public int clan_id;
    internal override string Url => "clan_battle/confirm_rehearsal_mylog";
}

public class ClanBattleConfirmTrainingMyLogRequest : Request<ClanBattleConfirmTrainingMyLogResponse>
{
    internal override string Url => "clan_battle/confirm_training_my_log";
}

public class ClanBattleDamageReportRequest : Request<ClanBattleDamageReportResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int lap_num;
    public int order_num;
    internal override string Url => "clan_battle/damage_report";
}

public class ClanBattleDeleteRehearsalMyLogRequest : Request<ClanBattleDeleteRehearsalMyLogResponse>
{
    public int clan_id;
    public int mylog_id;
    internal override string Url => "clan_battle/delete_rehearsal_mylog";
}

public class ClanBattleDeleteTrainingMyLogRequest : Request<ClanBattleDeleteTrainingMyLogResponse>
{
    public int mylog_id;
    internal override string Url => "clan_battle/delete_training_mylog";
}

public class ClanBattleFinishRequest : Request<ClanBattleFinishResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int lap_num;
    public int order_num;
    public ClanBattleFinishUnit user_unit;
    public int boss_hp;
    public int boss_damage;
    public int remain_time;
    public int total_damage;
    public int battle_log_id;
    public int is_auto;
    public string battle_log;
    internal override string Url => "clan_battle/finish";
}

public class ClanBattleHistoryReportRequest : Request<ClanBattleHistoryReportResponse>
{
    public int clan_id;
    public int history_id;
    internal override string Url => "clan_battle/history_report";
}

public class ClanBattleMissionIndexRequest : Request<ClanBattleMissionIndexResponse>
{
    internal override string Url => "clan_battle/mission_index";
}

public class ClanBattleMyLogDetailRequest : Request<ClanBattleMyLogDetailResponse>
{
    public int clan_id;
    public int clan_battle_id;
    internal override string Url => "clan_battle/mylog_detail";
}

public class ClanBattleMyLogRequest : Request<ClanBattleMyLogResponse>
{
    public int clan_id;
    internal override string Url => "clan_battle/mylog";
}

public class ClanBattlePeriodRankingRequest : Request<ClanBattlePeriodRankingResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int period;
    public int month;
    public int page;
    public int is_my_clan;
    public int is_first;
    internal override string Url => "clan_battle/period_ranking";
}

public class ClanBattleRehearsalFinishRequest : Request<ClanBattleRehearsalFinishResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int lap_num;
    public int order_num;
    public ClanBattleFinishUnit user_unit;
    public int boss_hp;
    public int boss_damage;
    public int remain_time;
    public int total_damage;
    public int battle_log_id;
    public int is_actual_boss_status;
    internal override string Url => "clan_battle/rehearsal_finish";
}

public class ClanBattleRehearsalStartRequest : Request<ClanBattleRehearsalStartResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int period;
    public int lap_num;
    public int order_num;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    public int is_actual_boss_status;
    internal override string Url => "clan_battle/rehearsal_start";
}

public class ClanBattleReloadDetailInfoRequest : Request<ClanBattleReloadDetailInfoResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int lap_num;
    public int order_num;
    internal override string Url => "clan_battle/reload_detail_info";
}

public class ClanBattleResetHpRequest : Request<ClanBattleResetHpResponse>
{
    public int hp_reset_count;
    public int current_currency_num;
    internal override string Url => "clan_battle/reset_hp";
}

public class ClanBattleSaveRehearsalMyLogRequest : Request<ClanBattleSaveRehearsalMyLogResponse>
{
    public int clan_id;
    public int mylog_id;
    public int lap_num;
    public int order_num;
    public UnitDamageInfo[] user_unit;
    public int total_damage;
    public int boss_damage;
    public int battle_log_id;
    public int is_auto;
    internal override string Url => "clan_battle/save_rehearsal_mylog";
}

public class ClanBattleSaveTrainingMyLogRequest : Request<ClanBattleSaveTrainingMyLogResponse>
{
    public int clan_id;
    public int training_id;
    public int mylog_id;
    public int clan_battle_mode;
    public int phase;
    public int order_num;
    public UnitDamageInfo[] user_unit;
    public int total_damage;
    public int boss_damage;
    public int battle_log_id;
    public int is_auto;
    internal override string Url => "clan_battle/save_training_mylog";
}

public class ClanBattleStartRequest : Request<ClanBattleStartResponse>
{
    public int clan_id;
    public int clan_battle_id;
    public int period;
    public int lap_num;
    public int order_num;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    public int remaining_count;
    internal override string Url => "clan_battle/start";
}

public class ClanBattleSuggestDeckListRequest : Request<ClanBattleSuggestDeckListResponse>
{
    public int recommend_group;
    public int clan_battle_id;
    public int lap_num;
    public int order_num;
    internal override string Url => "clan_battle/suggest_deck_list";
}

public class ClanBattleSuggestDeckReplayRequest : Request<ClanBattleSuggestDeckReplayResponse>
{
    public int clan_battle_id;
    public string enc_key;
    internal override string Url => "clan_battle/suggest_deck_replay";
}

public class ClanBattleSuggestDeckReplayReportRequest : Request<ClanBattleSuggestDeckReplayReportResponse>
{
    public int clan_battle_id;
    public string report_key;
    internal override string Url => "clan_battle/suggest_deck_replay_report";
}

public class ClanBattleSupportUnitList2Request : Request<ClanBattleSupportUnitList2Response>
{
    public int clan_id;
    internal override string Url => "clan_battle/support_unit_list_2";
}

public class ClanBattleSupportUnitListRequest : Request<ClanBattleSupportUnitListResponse>
{
    public int clan_id;
    internal override string Url => "clan_battle/support_unit_list";
}

public class ClanBattleTopRequest : Request<ClanBattleTopResponse>
{
    public int clan_id;
    public int is_first;
    public int current_clan_battle_coin;
    internal override string Url => "clan_battle/top";
}

public class ClanBattleTrainingFinishRequest : Request<ClanBattleTrainingFinishResponse>
{
    public int clan_id;
    public int training_id;
    public int clan_battle_mode;
    public int phase;
    public int order_num;
    public ClanBattleFinishUnit user_unit;
    public int boss_hp;
    public int boss_damage;
    public int remain_time;
    public int total_damage;
    public int battle_log_id;
    public int is_auto;
    internal override string Url => "clan_battle/training_finish";
}

public class ClanBattleTrainingStartRequest : Request<ClanBattleTrainingStartResponse>
{
    public int clan_id;
    public int training_id;
    public int clan_battle_mode;
    public int phase;
    public int order_num;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    internal override string Url => "clan_battle/training_start";
}

public class ClanBlockListRequest : Request<ClanBlockListResponse>
{
    public int page;
    internal override string Url => "clan/block_list";
}

public class ClanBreakUpRequest : Request<ClanBreakUpResponse>
{
    public int clan_id;
    internal override string Url => "clan/breakup";
}

public class ClanChatInfoListRequest : Request<ClanChatInfoListResponse>
{
    public int clan_id;
    public int start_message_id;
    public string search_date;
    public int direction;
    public int count;
    public int wait_interval;
    public int[] update_message_ids;
    internal override string Url => "clan/chat_info_list";
}

public class ClanChatRequest : Request<ClanChatResponse>
{
    public int clan_id;
    public int type;
    public string message;
    internal override string Url => "clan/chat";
}

public class ClanCreateRequest : Request<ClanCreateResponse>
{
    public string clan_name;
    public string description;
    public int join_condition;
    public int activity;
    public int clan_battle_mode;
    internal override string Url => "clan/create";
}

public class ClanDamageReportRequest : Request<ClanDamageReportResponse>
{
    public long target_viewer_id;
    public int clan_id;
    public int battle_type;
    public int battle_log_id;
    internal override string Url => "clan/chat_damage_report";
}

public class ClanDetailRequest : Request<ClanDetailResponse>
{
    public int clan_id;
    public int page;
    internal override string Url => "clan/detail";
}

public class ClanInfoRequest : Request<ClanInfoResponse>
{
    public int clan_id;
    public int get_user_equip;
    internal override string Url => "clan/info";
}

public class ClanInviteBlockRequest : Request<ClanInviteBlockResponse>
{
    public int invite_id;
    internal override string Url => "clan/block_invite";
}

public class ClanInviteCancelRequest : Request<ClanInviteCancelResponse>
{
    public int invite_id;
    internal override string Url => "clan/cancel_invite";
}

public class ClanInvitedUserListRequest : Request<ClanInvitedUserListResponse>
{
    public int clan_id;
    public int page;
    public long oldest_time;
    internal override string Url => "clan/invite_user_list";
}

public class ClanInvitePermissionRequest : Request<ClanInvitePermissionResponse>
{
    public int invite_accept_flag;
    internal override string Url => "clan/update_invite_accept_flag";
}

public class ClanInviteRequest : Request<ClanInviteResponse>
{
    public long invited_viewer_id;
    public string invite_message;
    internal override string Url => "clan/invite";
}

public class ClanInviteRejectRequest : Request<ClanInviteRejectResponse>
{
    public int invite_id;
    internal override string Url => "clan/reject_invite";
}

public class ClanInviteUnblockRequest : Request<ClanInviteUnblockResponse>
{
    public int block_id;
    internal override string Url => "clan/cancel_block_invite";
}

public class ClanJoinRequest : Request<ClanJoinResponse>
{
    public int clan_id;
    public int from_invite;
    internal override string Url => "clan/join";
}

public class ClanJoinRequestAcceptRequest : Request<ClanJoinRequestAcceptResponse>
{
    public long request_viewer_id;
    public int clan_id;
    internal override string Url => "clan/join_request_accept";
}

public class ClanJoinRequestCancelRequest : Request<ClanJoinRequestCancelResponse>
{
    public int clan_id;
    internal override string Url => "clan/join_request_cancel";
}

public class ClanJoinRequestListRequest : Request<ClanJoinRequestListResponse>
{
    public int clan_id;
    public int page;
    public long oldest_time;
    internal override string Url => "clan/join_request_list";
}

public class ClanJoinRequestRejectRequest : Request<ClanJoinRequestRejectResponse>
{
    public long request_viewer_id;
    public int clan_id;
    internal override string Url => "clan/join_request_reject";
}

public class ClanLeaveRequest : Request<ClanLeaveResponse>
{
    public int clan_id;
    internal override string Url => "clan/leave";
}

public class ClanLikeRequest : Request<ClanLikeResponse>
{
    public int clan_id;
    public long target_viewer_id;
    internal override string Url => "clan/like";
}

public class ClanMemberBattleFinishRequest : Request<ClanMemberBattleFinishResponse>
{
    public int battle_id;
    public FriendBattleResult[] wave_result_list;
    internal override string Url => "clan/clan_member_battle_finish";
}

public class ClanMemberBattleStartRequest : Request<ClanMemberBattleStartResponse>
{
    public long battle_viewer_id;
    public int[] unit_id_list;
    public int disable_skin;
    public long create_time;
    internal override string Url => "clan/clan_member_battle_start";
}

public class ClanRemoveRequest : Request<ClanRemoveResponse>
{
    public int clan_id;
    public long remove_viewer_id;
    internal override string Url => "clan/remove";
}

public class ClanSearchRequest : Request<ClanSearchResponse>
{
    public string clan_name;
    public int join_condition;
    public int member_condition_range;
    public int activity;
    public int clan_battle_mode;
    internal override string Url => "clan/search_clan";
}

public class ClanSearchUserRequest : Request<ClanSearchUserResponse>
{
    public int level_group_id;
    internal override string Url => "clan/search_user";
}

public class ClanSetDispatchStatusRequest : Request<ClanSetDispatchStatusResponse>
{
    public int clan_id;
    public int unit_id;
    public int position;
    public int action;
    internal override string Url => "clan/set_dispatch_status";
}

public class ClanUpdateRequest : Request<ClanUpdateResponse>
{
    public int clan_id;
    public string clan_name;
    public string description;
    public int join_condition;
    public int activity;
    public int clan_battle_mode;
    internal override string Url => "clan/update";
}

public class CloisterBattleSkipRequest : Request<CloisterBattleSkipResponse>
{
    public int quest_id;
    public int skip_count;
    public int current_ticket_num;
    internal override string Url => "tower/cloister_battle_skip";
}

public class DeckUpdateListRequest : Request<DeckUpdateListResponse>
{
    public DeckListData[] deck_list;
    internal override string Url => "deck/update_list";
}

public class DeckUpdateRequest : Request<DeckUpdateResponse>
{
    public int deck_number;
    public int unit_id_1;
    public int unit_id_2;
    public int unit_id_3;
    public int unit_id_4;
    public int unit_id_5;
    internal override string Url => "deck/update";
}

public class DungeonBattleFinishRequest : Request<DungeonBattleFinishResponse>
{
    public int quest_id;
    public DungeonQueryUnit[] user_unit;
    public DungeonQueryUnit[] versus_user_unit;
    public int remain_time;
    public int total_damage;
    internal override string Url => "dungeon/battle_finish";
}

public class DungeonBattleRetireRequest : Request<DungeonBattleRetireResponse>
{
    public int quest_id;
    internal override string Url => "dungeon/battle_retire";
}

public class DungeonBattleStartRequest : Request<DungeonBattleStartResponse>
{
    public int quest_id;
    public DungeonBattleStartUnit[] unit_list;
    public int disable_skin;
    public int support_battle_rarity;
    internal override string Url => "dungeon/battle_start";
}

public class DungeonClanDispatchUnitListRequest : Request<DungeonClanDispatchUnitListResponse>
{
    public int dungeon_area_id;
    internal override string Url => "dungeon/clan_dispatch_unit_list";
}

public class DungeonDispatchUnitList2Request : Request<DungeonDispatchUnitList2Response>
{
    public int dungeon_area_id;
    internal override string Url => "dungeon/dispatch_unit_list_2";
}

public class DungeonEnterAreaRequest : Request<DungeonEnterAreaResponse>
{
    public int dungeon_area_id;
    internal override string Url => "dungeon/enter_area";
}

public class DungeonInfoRequest : Request<DungeonInfoResponse>
{
    internal override string Url => "dungeon/info";
}

public class DungeonResetRequest : Request<DungeonResetResponse>
{
    public int dungeon_area_id;
    internal override string Url => "dungeon/reset";
}

public class DungeonSkipRequest : Request<DungeonSkipResponse>
{
    public int dungeon_area_id;
    internal override string Url => "dungeon/skip";
}

public class EmblemChangeRequest : Request<EmblemChangeResponse>
{
    public int emblem_id;
    internal override string Url => "emblem/change";
}

public class EmblemTopRequest : Request<EmblemTopResponse>
{
    internal override string Url => "emblem/top";
}

public class EquipCraftRequest : Request<EquipCraftResponse>
{
    public int equip_id;
    public UserEquipParameterIdCount[] equip_recipe_list;
    public int current_equip_num;
    internal override string Url => "equipment/craft";
}

public class EquipDonateRequest : Request<EquipDonateResponse>
{
    public int clan_id;
    public int message_id;
    public int donation_num;
    public int current_equip_num;
    internal override string Url => "equipment/donate";
}

public class EquipEnhanceMaxRequest : Request<EquipEnhanceMaxResponse>
{
    public int unit_id;
    public int equip_slot_num;
    internal override string Url => "equipment/enhance_max";
}

public class EquipEnhanceRequest : Request<EquipEnhanceResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public InventoryInfoPost[] item_list;
    public int current_enhancement_pt;
    internal override string Url => "equipment/enhance";
}

public class EquipGetRequestRequest : Request<EquipGetRequestResponse>
{
    public int clan_id;
    public int message_id;
    internal override string Url => "equipment/get_request";
}

public class EquipmentFreeEnhanceRequest : Request<EquipmentFreeEnhanceResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public int after_equip_level;
    internal override string Url => "equipment/free_enhance";
}

public class EquipRequestRequest : Request<EquipRequestResponse>
{
    public int equip_id;
    public int clan_id;
    internal override string Url => "equipment/request";
}

public class EventGachaExecRequest : Request<EventGachaExecResponse>
{
    public int event_id;
    public int gacha_id;
    public int gacha_times;
    public int current_cost_num;
    public int loop_box_multi_gacha_flag;
    internal override string Url => "event/hatsune/gacha_exec";
}

public class EventGachaIndexRequest : Request<EventGachaIndexResponse>
{
    public int event_id;
    public int gacha_id;
    internal override string Url => "event/hatsune/gacha_index";
}

public class EventGachaLineupRequest : Request<EventGachaLineupResponse>
{
    public int event_id;
    public int gacha_id;
    internal override string Url => "event/hatsune/gacha_lineup";
}

public class EventGachaResetRequest : Request<EventGachaResetResponse>
{
    public int event_id;
    public int gacha_id;
    internal override string Url => "event/hatsune/gacha_reset";
}

public class FkeFinishRequest : Request<FkeFinishResponse>
{
    public int fke_play_id;
    public int base_fke_point;
    public int[] happening_id_list;
    internal override string Url => "fke/finish";
}

public class FkeStartRequest : Request<FkeStartResponse>
{
    internal override string Url => "fke/start";
}

public class FkeSyncTopRequest : Request<FkeSyncTopResponse>
{
    public int[] happening_id_list;
    internal override string Url => "fke/sync_top";
}

public class FkeTopRequest : Request<FkeTopResponse>
{
    internal override string Url => "fke/top";
}

public class FriendAcceptRequest : Request<FriendAcceptResponse>
{
    public long target_viewer_id;
    internal override string Url => "friend/accept";
}

public class FriendBattleFinishRequest : Request<FriendBattleFinishResponse>
{
    public int battle_id;
    public FriendBattleResult[] wave_result_list;
    internal override string Url => "practice/friend_battle_finish";
}

public class FriendBattleStartRequest : Request<FriendBattleStartResponse>
{
    public long battle_viewer_id;
    public int deck_number;
    public int disable_skin;
    public int is_clan;
    internal override string Url => "practice/friend_battle_start";
}

public class FriendBattleTopRequest : Request<FriendBattleTopResponse>
{
    public int is_clan;
    internal override string Url => "practice/friend_battle_top";
}

public class FriendBattleUpdateDeckRequest : Request<FriendBattleUpdateDeckResponse>
{
    public int deck_number;
    public string deck_name;
    public int unit_id_1;
    public int unit_id_2;
    public int unit_id_3;
    public int unit_id_4;
    public int unit_id_5;
    public int mask_bit_flag;
    internal override string Url => "practice/update_deck";
}

public class FriendCancelRequest : Request<FriendCancelResponse>
{
    public long target_viewer_id;
    internal override string Url => "friend/cancel";
}

public class FriendFriendListRequest : Request<FriendFriendListResponse>
{
    internal override string Url => "friend/friend_list";
}

public class FriendGetMissionTargetFriendCountRequest : Request<FriendGetMissionTargetFriendCountResponse>
{
    public int campaign_id;
    public int mission_id;
    internal override string Url => "friend/get_mission_target_friend_count";
}

public class FriendMissionAcceptRequest : Request<FriendMissionAcceptResponse>
{
    public int campaign_id;
    public int type;
    public int id;
    internal override string Url => "friend/mission_accept";
}

public class FriendMissionIndexRequest : Request<FriendMissionIndexResponse>
{
    public int campaign_id;
    internal override string Url => "friend/mission_index";
}

public class FriendPendingListRequest : Request<FriendPendingListResponse>
{
    internal override string Url => "friend/pending_list";
}

public class FriendRejectRequest : Request<FriendRejectResponse>
{
    public long target_viewer_id;
    internal override string Url => "friend/reject";
}

public class FriendRemoveRequest : Request<FriendRemoveResponse>
{
    public long target_viewer_id;
    internal override string Url => "friend/remove";
}

public class FriendRequestListRequest : Request<FriendRequestListResponse>
{
    internal override string Url => "friend/request_list";
}

public class FriendRequestRequest : Request<FriendRequestResponse>
{
    public long target_viewer_id;
    internal override string Url => "friend/request";
}

public class FriendSearchRequest : Request<FriendSearchResponse>
{
    public int level_group_id;
    internal override string Url => "friend/search";
}

public class GachaExchangePointRequest : Request<GachaExchangePointResponse>
{
    public int exchange_id;
    public int unit_id;
    public int current_point;
    internal override string Url => "gacha/exchange_point";
}

public class GachaExecRequest : Request<GachaExecResponse>
{
    public int gacha_id;
    public int gacha_times;
    public int exchange_id;
    public int draw_type;
    public int current_cost_num;
    public int campaign_id;
    internal override string Url => "gacha/exec";
}

public class GachaIndexRequest : Request<GachaIndexResponse>
{
    internal override string Url => "gacha/index";
}

public class GachaPrizeHistoryRequest : Request<GachaPrizeHistoryResponse>
{
    public int gacha_id;
    public int offset;
    public int page;
    internal override string Url => "gacha/prize_history";
}

public class GachaPrizeRewardRequest : Request<GachaPrizeRewardResponse>
{
    public int gacha_id;
    internal override string Url => "gacha/prize_reward";
}

public class GachaSelectPrizeRequest : Request<GachaSelectPrizeResponse>
{
    public int prizegacha_id;
    public int item_id;
    internal override string Url => "gacha/select_prize";
}

public class GachaSpecialFesIndexRequest : Request<GachaSpecialFesIndexResponse>
{
    internal override string Url => "gacha/special_fes_index";
}

public class GetFriendSupportUnitListRequest : Request<GetFriendSupportUnitListResponse>
{
}

public class GetTipsListRequest : Request<GetTipsListResponse>
{
}

public class GrandArenaApplyRequest : Request<GrandArenaApplyResponse>
{
    public long battle_viewer_id;
    public int opponent_rank;
    internal override string Url => "grand_arena/apply";
}

public class GrandArenaCancelIntervalRequest : Request<GrandArenaCancelIntervalResponse>
{
    internal override string Url => "grand_arena/cancel_interval";
}

public class GrandArenaCancelRequest : Request<GrandArenaCancelResponse>
{
    public long battle_viewer_id;
    internal override string Url => "grand_arena/cancel";
}

public class GrandArenaFinishRequest : Request<GrandArenaFinishResponse>
{
    public int battle_id;
    public ArenaWaveResult[] arena_wave_result_list;
    public int is_skipped;
    internal override string Url => "grand_arena/finish";
}

public class GrandArenaGetDestinationGroupRequest : Request<GrandArenaGetDestinationGroupResponse>
{
    internal override string Url => "grand_arena/get_destination_group";
}

public class GrandArenaHistoryDetailRequest : Request<GrandArenaHistoryDetailResponse>
{
    public int log_id;
    internal override string Url => "grand_arena/history_detail";
}

public class GrandArenaHistoryRequest : Request<GrandArenaHistoryResponse>
{
    internal override string Url => "grand_arena/history";
}

public class GrandArenaInfoRequest : Request<GrandArenaInfoResponse>
{
    internal override string Url => "grand_arena/info";
}

public class GrandArenaMoveGroupRequest : Request<GrandArenaMoveGroupResponse>
{
    public int group_id;
    internal override string Url => "grand_arena/move_group";
}

public class GrandArenaRankingRequest : Request<GrandArenaRankingResponse>
{
    public int limit;
    public int page;
    internal override string Url => "grand_arena/ranking";
}

public class GrandArenaReplayRequest : Request<GrandArenaReplayResponse>
{
    public int log_id;
    public int round;
    internal override string Url => "grand_arena/replay";
}

public class GrandArenaResetBattleNumberRequest : Request<GrandArenaResetBattleNumberResponse>
{
    internal override string Url => "grand_arena/reset_battle_number";
}

public class GrandArenaSearchRequest : Request<GrandArenaSearchResponse>
{
    internal override string Url => "grand_arena/search";
}

public class GrandArenaStartRequest : Request<GrandArenaStartResponse>
{
    public string token;
    public long battle_viewer_id;
    public int remain_battle_number;
    public int disable_skin;
    internal override string Url => "grand_arena/start";
}

public class GrandArenaTimeRewardAcceptRequest : Request<GrandArenaTimeRewardAcceptResponse>
{
    internal override string Url => "grand_arena/time_reward_accept";
}

public class HatsuneBossBattleFinishRequest : Request<HatsuneBossBattleFinishResponse>
{
    public int event_id;
    public int boss_id;
    public HatsuneBossBattleFinishUnit user_unit;
    public int remain_time;
    public int total_damage;
    public EventEnemyDamageInfo[] enemy_damage_list;
    internal override string Url => "event/hatsune/boss_battle_finish";
}

public class HatsuneBossBattleSkipRequest : Request<HatsuneBossBattleSkipResponse>
{
    public int event_id;
    public int boss_id;
    public int exec_skip_num;
    public int current_skip_ticket_num;
    public int current_boss_ticket_num;
    internal override string Url => "event/hatsune/boss_battle_skip";
}

public class HatsuneBossBattleStartRequest : Request<HatsuneBossBattleStartResponse>
{
    public int event_id;
    public int boss_id;
    public int current_ticket_num;
    internal override string Url => "event/hatsune/boss_battle_start";
}

public class HatsuneChangeNyxItemColorRequest : Request<HatsuneChangeNyxItemColorResponse>
{
    public int color_id;
    internal override string Url => "event/hatsune/change_nyx_item_color";
}

public class HatsuneDearFinishRequest : Request<HatsuneDearFinishResponse>
{
    public int event_id;
    public int story_id;
    public int choice;
    internal override string Url => "event/hatsune/dear_finish";
}

public class HatsuneDearTopRequest : Request<HatsuneDearTopResponse>
{
    public int event_id;
    internal override string Url => "event/hatsune/dear_top";
}

public class HatsuneMissionAcceptRequest : Request<HatsuneMissionAcceptResponse>
{
    public int event_id;
    public int type;
    public int id;
    public int buy_id;
    internal override string Url => "event/hatsune/mission_accept";
}

public class HatsuneMissionIndexRequest : Request<HatsuneMissionIndexResponse>
{
    public int event_id;
    internal override string Url => "event/hatsune/mission_index";
}

public class HatsuneQuestFinishRequest : Request<HatsuneQuestFinishResponse>
{
    public int event_id;
    public int quest_id;
    public int remain_time;
    public UnitHpInfo[] unit_hp_list;
    public long owner_viewer_id;
    public int support_position;
    public int is_friend;
    internal override string Url => "event/hatsune/quest_finish";
}

public class HatsuneQuestRetireRequest : Request<HatsuneQuestRetireResponse>
{
    public int event_id;
    public int quest_id;
    internal override string Url => "event/hatsune/quest_retire";
}

public class HatsuneQuestSkipRequest : Request<HatsuneQuestSkipResponse>
{
    public int event_id;
    public int quest_id;
    public int use_ticket_num;
    public int current_ticket_num;
    internal override string Url => "event/hatsune/quest_skip";
}

public class HatsuneQuestStartRequest : Request<HatsuneQuestStartResponse>
{
    public int event_id;
    public int quest_id;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    public int is_friend;
    internal override string Url => "event/hatsune/quest_start";
}

public class HatsuneQuestTopRequest : Request<HatsuneQuestTopResponse>
{
    public int event_id;
    internal override string Url => "event/hatsune/quest_top";
}

public class HatsuneQuizAnswerRequest : Request<HatsuneQuizAnswerResponse>
{
    public int event_id;
    public int quiz_id;
    public int choice;
    internal override string Url => "event/hatsune/quiz_answer";
}

public class HatsuneReadDiaryRequest : Request<HatsuneReadDiaryResponse>
{
    public int diary_id;
    internal override string Url => "event/hatsune/read_diary";
}

public class HatsuneReadNyxStoryRequest : Request<HatsuneReadNyxStoryResponse>
{
    public int id;
    internal override string Url => "event/hatsune/read_nyx_story";
}

public class HatsuneReadOmpStoryRequest : Request<HatsuneReadOmpStoryResponse>
{
    public int omp_story_id;
    internal override string Url => "event/hatsune/read_omp_story";
}

public class HatsuneReadRelayStoryRequest : Request<HatsuneReadRelayStoryResponse>
{
    public int relay_story_id;
    internal override string Url => "event/hatsune/read_relay_story";
}

public class HatsuneRecoverChallengeRequest : Request<HatsuneRecoverChallengeResponse>
{
    public int quest_id;
    public int current_currency_num;
    public int event_id;
    internal override string Url => "event/hatsune/recover_challenge";
}

public class HatsuneSpecialBattleExFinishRequest : Request<HatsuneSpecialBattleExFinishResponse>
{
    public int event_id;
    public int boss_id;
    public HatsuneBossBattleFinishUnit user_unit;
    public int total_damage;
    public EventEnemyDamageInfo[] enemy_damage_list;
    public int remain_time;
    public int mode;
    public EventEnemyInfo[] enemy_info;
    public int manual_flags;
    internal override string Url => "event/hatsune/special_battle_ex_finish";
}

public class HatsuneSpecialBattleExHistoryRequest : Request<HatsuneSpecialBattleExHistoryResponse>
{
    public int event_id;
    public int appear_num;
    public int page;
    internal override string Url => "event/hatsune/special_battle_ex_history";
}

public class HatsuneSpecialBattleExResetRequest : Request<HatsuneSpecialBattleExResetResponse>
{
    public int event_id;
    public int boss_id;
    public int appear_num;
    internal override string Url => "event/hatsune/special_battle_ex_reset";
}

public class HatsuneSpecialBattleExRetireRequest : Request<HatsuneSpecialBattleExRetireResponse>
{
    public int event_id;
    public int boss_id;
    public int manual_flags;
    internal override string Url => "event/hatsune/special_battle_ex_retire";
}

public class HatsuneSpecialBattleExStartRequest : Request<HatsuneSpecialBattleExStartResponse>
{
    public int boss_id;
    public int event_id;
    public int mode;
    internal override string Url => "event/hatsune/special_battle_ex_start";
}

public class HatsuneSpecialBattleFinishRequest : Request<HatsuneSpecialBattleFinishResponse>
{
    public int event_id;
    public int boss_id;
    public HatsuneBossBattleFinishUnit user_unit;
    public int total_damage;
    public EventEnemyDamageInfo[] enemy_damage_list;
    public int remain_time;
    public int mode;
    public EventEnemyInfo[] enemy_info;
    internal override string Url => "event/hatsune/special_battle_finish";
}

public class HatsuneSpecialBattleRetireRequest : Request<HatsuneSpecialBattleRetireResponse>
{
    public int event_id;
    public int boss_id;
    internal override string Url => "event/hatsune/special_battle_retire";
}

public class HatsuneSpecialBattleStartRequest : Request<HatsuneSpecialBattleStartResponse>
{
    public int boss_id;
    public int event_id;
    public int current_ticket_num;
    public int mode;
    internal override string Url => "event/hatsune/special_battle_start";
}

public class HatsuneTopRequest : Request<HatsuneTopResponse>
{
    public int event_id;
    internal override string Url => "event/hatsune/top";
}

public class HomeIndexRequest : Request<HomeIndexResponse>
{
    public int message_id;
    public int[] tips_id_list;
    public int is_first;
    public int gold_history;
    internal override string Url => "home/index";
}

public class ItemETicketExchangeRequest : Request<ItemETicketExchangeResponse>
{
    public int ticket_id;
    public int ticket_count;
    public int exchange_number;
    internal override string Url => "item_e_ticket/exchange";
}

public class KaiserBattleGetMainBossInfoRequest : Request<KaiserBattleGetMainBossInfoResponse>
{
    internal override string Url => "kaiser_battle/get_main_boss_info";
}

public class KaiserBattleMainFinishRequest : Request<KaiserBattleMainFinishResponse>
{
    public int kaiser_boss_id;
    public int battle_log_id;
    public int remain_time;
    public int total_damage;
    public int mode;
    public BossBattleFinishUnit battle_finish_unit;
    public EventEnemyInfo[] enemy_info;
    internal override string Url => "kaiser_battle/main_finish";
}

public class KaiserBattleMainRetireRequest : Request<KaiserBattleMainRetireResponse>
{
    public int kaiser_boss_id;
    public int battle_log_id;
    internal override string Url => "kaiser_battle/main_retire";
}

public class KaiserBattleMainStartRequest : Request<KaiserBattleMainStartResponse>
{
    public int kaiser_boss_id;
    public string token;
    public int mode;
    public int from_event_flag;
    public KaiserBattleSupportRental[] support_list;
    internal override string Url => "kaiser_battle/main_start";
}

public class KaiserBattleMySupportListRequest : Request<KaiserBattleMySupportListResponse>
{
    internal override string Url => "kaiser_battle/my_support_list";
}

public class KaiserBattleSetSupportUnitRequest : Request<KaiserBattleSetSupportUnitResponse>
{
    public int position;
    public int unit_id;
    internal override string Url => "kaiser_battle/set_support_unit";
}

public class KaiserBattleSubFinishRequest : Request<KaiserBattleSubFinishResponse>
{
    public int kaiser_boss_id;
    public int battle_log_id;
    public int remaining_count;
    public int remain_time;
    public int total_damage;
    public BossBattleFinishUnit battle_finish_unit;
    internal override string Url => "kaiser_battle/sub_finish";
}

public class KaiserBattleSubStartRequest : Request<KaiserBattleSubStartResponse>
{
    public int kaiser_boss_id;
    public string token;
    public KaiserBattleSupportRental[] support_list;
    internal override string Url => "kaiser_battle/sub_start";
}

public class KaiserBattleSupportListRequest : Request<KaiserBattleSupportListResponse>
{
    public int kaiser_boss_id;
    internal override string Url => "kaiser_battle/support_list";
}

public class KaiserBattleTopRequest : Request<KaiserBattleTopResponse>
{
    internal override string Url => "kaiser_battle/top";
}

public class KaiserBattleUpdateDeckRequest : Request<KaiserBattleUpdateDeckResponse>
{
    public int kaiser_boss_id;
    public int unit_id_1;
    public int unit_id_2;
    public int unit_id_3;
    public int unit_id_4;
    public int unit_id_5;
    internal override string Url => "kaiser_battle/update_deck";
}

public class KmkFinishRequest : Request<KmkFinishResponse>
{
    public int play_id;
    public int base_score;
    public KmkKillList kill_list;
    public int max_combo_count;
    public int after_hp;
    public int fever_score;
    internal override string Url => "kmk/finish";
}

public class KmkStartRequest : Request<KmkStartResponse>
{
    public int difficulty_level;
    internal override string Url => "kmk/start";
}

public class KmkTopRequest : Request<KmkTopResponse>
{
    internal override string Url => "kmk/top";
}

public class LoadIndexRequest : Request<LoadIndexResponse>
{
    public string carrier;
    internal override string Url => "load/index";
}

public class LoadNextDayIndexRequest : Request<LoadNextDayIndexResponse>
{
    public string carrier;
    internal override string Url => "load/next_day_index";
}

public class MissionAcceptRequest : Request<MissionAcceptResponse>
{
    public int type;
    public int id;
    public int buy_id;
    internal override string Url => "mission/accept";
}

public class MissionIndexRequest : Request<MissionIndexResponse>
{
    public MissionRequestFlag request_flag;
    internal override string Url => "mission/index";
}

public class MultiUnlockRaritySixSlotRequest : Request<MultiUnlockRaritySixSlotResponse>
{
    public int unit_id;
    public int slot_id;
    public int current_gold_num;
    public PostMultiUnlockRarity6Slot[] slot_list;
    internal override string Url => "unit/multi_unlock_rarity_6_slot";
}

public class MusicBuyRequest : Request<MusicBuyResponse>
{
    public int music_id;
    public int room_coin;
    internal override string Url => "music/buy";
}

public class MusicSetRequest : Request<MusicSetResponse>
{
    public MusicIdData[] bgm;
    internal override string Url => "music/set";
}

public class MusicTopRequest : Request<MusicTopResponse>
{
    internal override string Url => "music/top";
}

public class MyPageSetMyPageRequest : Request<MyPageSetMyPageResponse>
{
    public MyPage[] my_page_info;
    internal override string Url => "my_page/set_my_page";
}

public class OtherClanInfoRequest : Request<OtherClanInfoResponse>
{
    public int clan_id;
    internal override string Url => "clan/others_info";
}

public class PctFinishRequest : Request<PctFinishResponse>
{
    public int pct_play_id;
    public int base_pct_point;
    public int max_combo_count;
    public PctGradeInfo[] grade_list;
    public int barrage_count;
    public int fruits_count;
    public int special_item_count;
    public int fever_count;
    internal override string Url => "pct/finish";
}

public class PctStartRequest : Request<PctStartResponse>
{
    public int unit_id;
    public int use_item_id;
    public int use_item_count;
    internal override string Url => "pct/start";
}

public class PctTopRequest : Request<PctTopResponse>
{
    internal override string Url => "pct/top";
}

public class PictureBookRequest : Request<PictureBookResponse>
{
    public int mode;
    internal override string Url => "picture_book/index";
}

public class PkbFinishSoloRequest : Request<PkbFinishSoloResponse>
{
    public int play_id;
    public int result_type;
    public int total_batting_distance;
    public int single_max_batting_distance;
    public int home_run_num;
    public int hit_num;
    public PkbBattingResultInfo[] batting_result_list;
    public int[] ball_type_list;
    public int elapsed_frame;
    public int from_system_id;
    public ePkbHappenMode happen_mode;
    internal override string Url => "pkb/finish_solo";
}

public class PkbFinishVsRequest : Request<PkbFinishVsResponse>
{
    public int play_id;
    public int result_type;
    public int base_score;
    public int vs_base_score;
    public int total_batting_distance;
    public int single_max_batting_distance;
    public int home_run_num;
    public int hit_num;
    public PkbBattingResultInfo[] batting_result_list;
    public int[] ball_type_list;
    public int elapsed_frame;
    public int from_system_id;
    public ePkbHappenMode happen_mode;
    internal override string Url => "pkb/finish_vs";
}

public class PkbReadCatalogRequest : Request<PkbReadCatalogResponse>
{
    public int[] pitcher_id_list;
    public int[] batter_id_list;
    public int from_system_id;
    internal override string Url => "pkb/read_catalog";
}

public class PkbReadRankingRequest : Request<PkbReadRankingResponse>
{
    public PkbReadRankingInfo[] read_ranking_info;
    public PkbReadRankingInfo[] read_simple_ranking_info;
    public int from_system_id;
    internal override string Url => "pkb/read_ranking";
}

public class PkbStartSoloRequest : Request<PkbStartSoloResponse>
{
    public int difficulty_level;
    public int batter_id;
    public int from_system_id;
    public ePkbHappenMode happen_mode;
    internal override string Url => "pkb/start_solo";
}

public class PkbStartVsRequest : Request<PkbStartVsResponse>
{
    public int difficulty_level;
    public int batter_id;
    public int vs_batter_id;
    public int from_system_id;
    public ePkbHappenMode happen_mode;
    internal override string Url => "pkb/start_vs";
}

public class PkbTopRequest : Request<PkbTopResponse>
{
    public int from_system_id;
    internal override string Url => "pkb/top";
}

public class PresentHistoryRequest : Request<PresentHistoryResponse>
{
    public int page;
    internal override string Url => "present/history";
}

public class PresentIndexRequest : Request<PresentIndexResponse>
{
    public int time_filter;
    public int type_filter;
    public bool desc_flag;
    public int offset;
    internal override string Url => "present/index";
}

public class PresentReceiveAllRequest : Request<PresentReceiveAllResponse>
{
    public int time_filter;
    public int type_filter;
    public bool desc_flag;
    internal override string Url => "present/receive_all";
}

public class PresentReceiveSingleRequest : Request<PresentReceiveSingleResponse>
{
    public long present_id;
    internal override string Url => "present/receive";
}

public class ProfileFavoriteUnitRequest : Request<ProfileFavoriteUnitResponse>
{
    public int unit_id;
    internal override string Url => "profile/favorite_unit";
}

public class ProfileGetRequest : Request<ProfileGetResponse>
{
    public long target_viewer_id;
    internal override string Url => "profile/get_profile";
}

public class ProfileMakerGetClanProfileRequest : Request<ProfileMakerGetClanProfileResponse>
{
    internal override string Url => "profile_maker/get_clan_profile";
}

public class ProfileMakerGetMyProfileRequest : Request<ProfileMakerGetMyProfileResponse>
{
    internal override string Url => "profile_maker/get_my_profile";
}

public class ProfileMakerSetClanProfileRequest : Request<ProfileMakerSetClanProfileResponse>
{
    public ClanProfileCardSetting profile;
    internal override string Url => "profile_maker/set_clan_profile";
}

public class ProfileMakerSetMyProfileRequest : Request<ProfileMakerSetMyProfileResponse>
{
    public MyProfileCardSetting profile;
    internal override string Url => "profile_maker/set_my_profile";
}

public class ProfileRenameRequest : Request<ProfileRenameResponse>
{
    public string user_name;
    internal override string Url => "profile/rename";
}

public class ProfileSetBirthDayRequest : Request<ProfileSetBirthDayResponse>
{
    public int birthday;
    internal override string Url => "profile/set_birthday";
}

public class ProfileUpdateCommentRequest : Request<ProfileUpdateCommentResponse>
{
    public string user_comment;
    internal override string Url => "profile/update_comment";
}

public class QuestFinishRequest : Request<QuestFinishResponse>
{
    public int quest_id;
    public int remain_time;
    public UnitHpInfo[] unit_hp_list;
    public int auto_clear;
    public int fps;
    public long owner_viewer_id;
    public int support_position;
    public int is_friend;
    internal override string Url => "quest/finish";
}

public class QuestRecoverChallengeMultipleRequest : Request<QuestRecoverChallengeMultipleResponse>
{
    public int[] hard_quest_list;
    public int[] very_hard_quest_list;
    public int current_currency_num;
    internal override string Url => "quest/recover_challenge_multiple";
}

public class QuestRecoverChallengeRequest : Request<QuestRecoverChallengeResponse>
{
    public int quest_id;
    public int current_currency_num;
    internal override string Url => "quest/recover_challenge";
}

public class QuestReplayListRequest : Request<QuestReplayListResponse>
{
    public int quest_id;
    public int fps;
    public int team_level;
    internal override string Url => "quest/replay_list";
}

public class QuestReplayRequest : Request<QuestReplayResponse>
{
    public int quest_id;
    public string enc_key;
    internal override string Url => "quest/replay";
}

public class QuestReplayReportRequest : Request<QuestReplayReportResponse>
{
    public string enc_key;
    public int quest_id;
    internal override string Url => "quest/replay_report";
}

public class QuestRetireRequest : Request<QuestRetireResponse>
{
    public int quest_id;
    internal override string Url => "quest/retire";
}

public class QuestSkipMultipleRequest : Request<QuestSkipMultipleResponse>
{
    public QuestSkipInfo[] normal_skip_list;
    public QuestSkipInfo[] hard_skip_list;
    public QuestSkipInfo[] very_hard_skip_list;
    public QuestSkipInfo[] shiori_hard_skip_list;
    public int current_ticket_num;
    internal override string Url => "quest/quest_skip_multiple";
}

public class QuestSkipRequest : Request<QuestSkipResponse>
{
    public int quest_id;
    public int random_count;
    public int current_ticket_num;
    internal override string Url => "quest/quest_skip";
}

public class QuestStartRequest : Request<QuestStartResponse>
{
    public int quest_id;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    public int is_friend;
    internal override string Url => "quest/start";
}

public class RaceLoginBonusCharaSelectDataRequest : Request<RaceLoginBonusCharaSelectDataResponse>
{
    public int fortune_id;
    public int unit_id;
    internal override string Url => "chara_fortune/draw";
}

public class RaritySixQuestFinishRequest : Request<RaritySixQuestFinishResponse>
{
    public int quest_id;
    public int remain_time;
    public UnitHpInfo[] unit_hp_list;
    internal override string Url => "rarity_6_quest/finish";
}

public class RaritySixQuestStartRequest : Request<RaritySixQuestStartResponse>
{
    public int quest_id;
    public string token;
    internal override string Url => "rarity_6_quest/start";
}

public class RoomClanMemberRequest : Request<RoomClanMemberResponse>
{
    internal override string Url => "room/clan_member";
}

public class RoomExtendStorageRequest : Request<RoomExtendStorageResponse>
{
    public int storage_num;
    internal override string Url => "room/extend_storage";
}

public class RoomFreeGiftRequest : Request<RoomFreeGiftResponse>
{
    public int unit_id;
    public int after_love_level;
    internal override string Url => "room/free_gift";
}

public class RoomGiveGiftRequest : Request<RoomGiveGiftResponse>
{
    public int unit_id;
    public int item_id;
    public int item_num;
    public int current_item_num;
    internal override string Url => "room/give_gift";
}

public class RoomItemBuyRequest : Request<RoomItemBuyResponse>
{
    public int item_id;
    public int item_count;
    public int purchase_type;
    public int floor_number;
    public int background_theme;
    public RoomFloorLayout layout;
    public int has_update;
    public int room_coin;
    internal override string Url => "room/buy";
}

public class RoomItemSellRequest : Request<RoomItemSellResponse>
{
    public int[] serial_id_list;
    public int floor_number;
    public int background_theme;
    public RoomFloorLayout layout;
    internal override string Url => "room/sell";
}

public class RoomLevelUpEndRequest : Request<RoomLevelUpEndResponse>
{
    public int serial_id;
    internal override string Url => "room/level_up_end";
}

public class RoomLevelUpShorteningRequest : Request<RoomLevelUpShorteningResponse>
{
    public int serial_id;
    internal override string Url => "room/level_up_shortening";
}

public class RoomLevelUpStartRequest : Request<RoomLevelUpStartResponse>
{
    public int floor_number;
    public int serial_id;
    internal override string Url => "room/level_up_start";
}

public class RoomLevelUpStopRequest : Request<RoomLevelUpStopResponse>
{
    public int serial_id;
    internal override string Url => "room/level_up_stop";
}

public class RoomLikeHistoryRequest : Request<RoomLikeHistoryResponse>
{
    internal override string Url => "room/like_history";
}

public class RoomLikeRequest : Request<RoomLikeResponse>
{
    public long target_viewer_id;
    internal override string Url => "room/like";
}

public class RoomMultiGiveGiftRequest : Request<RoomMultiGiveGiftResponse>
{
    public int unit_id;
    public SendGiftData[] item_info;
    internal override string Url => "room/multi_give_gift";
}

public class RoomMultiLevelUpEndRequest : Request<RoomMultiLevelUpEndResponse>
{
    public int[] serial_id_list;
    internal override string Url => "room/multi_level_up_end";
}

public class RoomMysetDeleteRequest : Request<RoomMysetDeleteResponse>
{
    public int myset_index;
    internal override string Url => "room/delete_myset";
}

public class RoomMysetListRequest : Request<RoomMysetListResponse>
{
    internal override string Url => "room/myset_list";
}

public class RoomMysetRenameRequest : Request<RoomMysetRenameResponse>
{
    public int myset_index;
    public string new_name;
    internal override string Url => "room/rename_myset";
}

public class RoomMysetSaveRequest : Request<RoomMysetSaveResponse>
{
    public int myset_index;
    public int background_theme;
    public RoomFloorLayoutForMyset floor_layout;
    internal override string Url => "room/save_myset";
}

public class RoomReceiveItemAllRequest : Request<RoomReceiveItemAllResponse>
{
    internal override string Url => "room/receive_item_all";
}

public class RoomReceiveItemRequest : Request<RoomReceiveItemResponse>
{
    public int serial_id;
    internal override string Url => "room/receive";
}

public class RoomStartRequest : Request<RoomStartResponse>
{
    internal override string Url => "room/start";
}

public class RoomUpdateRequest : Request<RoomUpdateResponse>
{
    public int floor_number;
    public RoomFloorLayout layout;
    public int background_theme;
    internal override string Url => "room/update";
}

public class RoomVisitRequest : Request<RoomVisitResponse>
{
    public long target_viewer_id;
    internal override string Url => "room/visit";
}

public class SeasonPassBuyLevelRequest : Request<SeasonPassBuyLevelResponse>
{
    public int season_id;
    public int current_currency_num;
    public int cost_jewel_num;
    public int current_level;
    public int add_level;
    internal override string Url => "season_pass/buy_level";
}

public class SeasonPassIndexRequest : Request<SeasonPassIndexResponse>
{
    public int season_id;
    internal override string Url => "season_pass/index";
}

public class SeasonPassMissionAcceptRequest : Request<SeasonPassMissionAcceptResponse>
{
    public int season_id;
    public int mission_id;
    internal override string Url => "season_pass/mission_accept";
}

public class SeasonPassRewardAcceptRequest : Request<SeasonPassRewardAcceptResponse>
{
    public int season_id;
    public int level;
    public int index;
    internal override string Url => "season_pass/reward_accept";
}

public class SekaiBossInfoRequest : Request<SekaiBossInfoResponse>
{
    public int sekai_id;
    internal override string Url => "sekai/boss_info";
}

public class SekaiFinishRequest : Request<SekaiFinishResponse>
{
    public int sekai_id;
    public BossBattleFinishUnit user_unit;
    public long boss_hp;
    public int boss_damage;
    public int remain_time;
    public long total_damage;
    public long score;
    public int battle_log_id;
    internal override string Url => "sekai/finish";
}

public class SekaiHistoryReportRequest : Request<SekaiHistoryReportResponse>
{
    public int sekai_id;
    public int history_id;
    public long history_viewer_id;
    internal override string Url => "sekai/history_report";
}

public class SekaiRankingInClanRequest : Request<SekaiRankingInClanResponse>
{
    public int clan_id;
    public int sekai_id;
    internal override string Url => "sekai/ranking_in_clan";
}

public class SekaiRankingRequest : Request<SekaiRankingResponse>
{
    public int sekai_id;
    public int page;
    public int is_mine;
    internal override string Url => "sekai/ranking";
}

public class SekaiRetireRequest : Request<SekaiRetireResponse>
{
    public int clan_id;
    public int sekai_id;
    internal override string Url => "sekai/retire";
}

public class SekaiStartRequest : Request<SekaiStartResponse>
{
    public int sekai_id;
    public long owner_viewer_id;
    public int support_unit_id;
    public string token;
    internal override string Url => "sekai/start";
}

public class SekaiSupportUnitList2Request : Request<SekaiSupportUnitList2Response>
{
    public int clan_id;
    internal override string Url => "sekai/support_unit_list_2";
}

public class SekaiTopRequest : Request<SekaiTopResponse>
{
    internal override string Url => "sekai/top";
}

public class SellItemRequest : Request<SellItemResponse>
{
    public int item_type;
    public int item_id;
    public int item_num;
    public int current_item_num;
    internal override string Url => "item/sell";
}

public class SendBattleLogCsvRequest : Request<SendBattleLogCsvResponse>
{
    public int battle_log_id;
    public int frame_rate;
    public string battle_log;
    public int system_id;
    internal override string Url => "log/battle_log2";
}

public class SerialCodeRegisterRequest : Request<SerialCodeRegisterResponse>
{
    public string serial_code;
    internal override string Url => "serial_code/register";
}

public class SetMyPartyRequest : Request<SetMyPartyResponse>
{
    public int tab_number;
    public int party_number;
    public int party_label_type;
    public string party_name;
    public int unit_id_1;
    public int unit_id_2;
    public int unit_id_3;
    public int unit_id_4;
    public int unit_id_5;
    public ChangeRarityUnit[] change_rarity_unit_list;
    internal override string Url => "my_party/set_party";
}

public class SetMyPartyTabRequest : Request<SetMyPartyTabResponse>
{
    public int tab_number;
    public string tab_name;
    internal override string Url => "my_party/set_tab";
}

public class ShioriBossBattleFinishRequest : Request<ShioriBossBattleFinishResponse>
{
    public int event_id;
    public int boss_id;
    public HatsuneBossBattleFinishUnit user_unit;
    public int remain_time;
    public int total_damage;
    public int battle_log_id;
    internal override string Url => "event/shiori/boss_battle_finish";
}

public class ShioriBossBattleRetireRequest : Request<ShioriBossBattleRetireResponse>
{
    public int event_id;
    public int boss_id;
    public int battle_log_id;
    internal override string Url => "event/shiori/boss_battle_retire";
}

public class ShioriBossBattleStartRequest : Request<ShioriBossBattleStartResponse>
{
    public int event_id;
    public int boss_id;
    public string token;
    internal override string Url => "event/shiori/boss_battle_start";
}

public class ShioriDearFinishRequest : Request<ShioriDearFinishResponse>
{
    public int event_id;
    public int story_id;
    public int choice;
    internal override string Url => "event/shiori/dear_finish";
}

public class ShioriDearTopRequest : Request<ShioriDearTopResponse>
{
    public int event_id;
    internal override string Url => "event/shiori/dear_top";
}

public class ShioriEventTopRequest : Request<ShioriEventTopResponse>
{
    public int event_id;
    internal override string Url => "event/shiori/event_top";
}

public class ShioriFavoriteRequest : Request<ShioriFavoriteResponse>
{
    public int event_id;
    public int favorite_flag;
    internal override string Url => "event/shiori/favorite";
}

public class ShioriMissionAcceptRequest : Request<ShioriMissionAcceptResponse>
{
    public int event_id;
    public int type;
    public int id;
    public int buy_id;
    internal override string Url => "event/shiori/mission_accept";
}

public class ShioriMissionIndexRequest : Request<ShioriMissionIndexResponse>
{
    public int event_id;
    internal override string Url => "event/shiori/mission_index";
}

public class ShioriQuestFinishRequest : Request<ShioriQuestFinishResponse>
{
    public int event_id;
    public int quest_id;
    public int remain_time;
    public UnitHpInfo[] unit_hp_list;
    public long owner_viewer_id;
    public int support_position;
    public int is_friend;
    public int battle_log_id;
    internal override string Url => "event/shiori/quest_finish";
}

public class ShioriQuestRetireRequest : Request<ShioriQuestRetireResponse>
{
    public int event_id;
    public int quest_id;
    public int battle_log_id;
    internal override string Url => "event/shiori/quest_retire";
}

public class ShioriQuestSkipRequest : Request<ShioriQuestSkipResponse>
{
    public int event_id;
    public int quest_id;
    public int use_ticket_num;
    public int current_ticket_num;
    internal override string Url => "event/shiori/quest_skip";
}

public class ShioriQuestStartRequest : Request<ShioriQuestStartResponse>
{
    public int event_id;
    public int quest_id;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    public int is_friend;
    internal override string Url => "event/shiori/quest_start";
}

public class ShioriQuizAnswerRequest : Request<ShioriQuizAnswerResponse>
{
    public int event_id;
    public int quiz_id;
    public int choice;
    internal override string Url => "event/shiori/quiz_answer";
}

public class ShioriTopRequest : Request<ShioriTopResponse>
{
    internal override string Url => "shiori/top";
}

public class ShopAlchemyRequest : Request<ShopAlchemyResponse>
{
    public int multiple_count;
    public int pay_or_free;
    public int current_currency_num;
    internal override string Url => "shop/alchemy";
}

public class ShopBuyMultipleRequest : Request<ShopBuyMultipleResponse>
{
    public int system_id;
    public int[] slot_ids;
    public int current_currency_num;
    internal override string Url => "shop/buy_multiple";
}

public class ShopBuyRequest : Request<ShopBuyResponse>
{
    public int system_id;
    public int slot_id;
    public int current_currency_num;
    public int number;
    public int total_price;
    internal override string Url => "shop/buy";
}

public class ShopCloseDailyShopRequest : Request<ShopCloseDailyShopResponse>
{
    public int system_id;
    internal override string Url => "shop/close_daily_shop";
}

public class ShopCloseLimitedShopRequest : Request<ShopCloseLimitedShopResponse>
{
    public int system_id;
    public int appear_count;
    public long close_time;
    internal override string Url => "shop/close_limited_shop";
}

public class ShopComebackTutorialDailyShopRequest : Request<ShopComebackTutorialDailyShopResponse>
{
    internal override string Url => "shop/comeback_tutorial_daily_shop";
}

public class ShopItemListRequest : Request<ShopItemListResponse>
{
    internal override string Url => "shop/item_list";
}

public class ShopRecoverStaminaRequest : Request<ShopRecoverStaminaResponse>
{
    public int current_currency_num;
    internal override string Url => "shop/recover_stamina";
}

public class ShopResetRequest : Request<ShopResetResponse>
{
    public int system_id;
    public int current_currency_num;
    internal override string Url => "shop/reset";
}

public class SkillLevelUpRequest : Request<SkillLevelUpResponse>
{
    public int unit_id;
    public SkillLevelUpDetail[] skill_levelup_list;
    internal override string Url => "skill/level_up";
}

public class SkillRemoveFreeRequest : Request<SkillRemoveFreeResponse>
{
    public int unit_id;
    public int location;
    internal override string Url => "skill/remove_free";
}

public class SkillSetFreeRequest : Request<SkillSetFreeResponse>
{
    public int unit_id;
    public int location;
    public int origin_unit_id;
    public int origin_location;
    internal override string Url => "skill/set_free";
}

public class SpaceFinishRequest : Request<SpaceFinishResponse>
{
    public int space_id;
    public int space_battle_id;
    public BossBattleFinishUnit user_unit;
    public long total_damage;
    public int remain_time;
    public int battle_log_id;
    internal override string Url => "space/finish";
}

public class SpaceRetireRequest : Request<SpaceRetireResponse>
{
    public int space_id;
    public int space_battle_id;
    public int battle_log_id;
    internal override string Url => "space/retire";
}

public class SpaceStartRequest : Request<SpaceStartResponse>
{
    public int space_id;
    public int space_battle_id;
    public long owner_viewer_id;
    public int support_unit_id;
    public string token;
    internal override string Url => "space/start";
}

public class SpaceStoryCheckRequest : Request<SpaceStoryCheckResponse>
{
    public int story_id;
    internal override string Url => "space/story_check";
}

public class SpaceStoryStartRequest : Request<SpaceStoryStartResponse>
{
    public int story_id;
    public int space_id;
    public int progress;
    internal override string Url => "space/story_start";
}

public class SpaceSupportUnitList2Request : Request<SpaceSupportUnitList2Response>
{
    public int clan_id;
    internal override string Url => "space/support_unit_list_2";
}

public class SpaceTopRequest : Request<SpaceTopResponse>
{
    internal override string Url => "space/top";
}

public class SrtFinishRequest : Request<SrtFinishResponse>
{
    public int play_id;
    public int result_type;
    public int base_score;
    public int turn_num;
    public int avg_answer_time;
    public int wrong_num;
    public SrtCatalogInfo[] update_catalog_info;
    internal override string Url => "srt/finish";
}

public class SrtReadCatalogRequest : Request<SrtReadCatalogResponse>
{
    internal override string Url => "srt/read_catalog";
}

public class SrtStartRequest : Request<SrtStartResponse>
{
    public int difficulty_level;
    public int priconne_mode;
    internal override string Url => "srt/start";
}

public class SrtTopRequest : Request<SrtTopResponse>
{
    internal override string Url => "srt/top";
}

public class StoryForceReleaseRequest : Request<StoryForceReleaseResponse>
{
    public int story_group_id;
    internal override string Url => "story/force_release";
}

public class StoryMaintenanceCheckRequest : Request<StoryMaintenanceCheckResponse>
{
    public int story_id;
    internal override string Url => "story/check";
}

public class StoryQuestStartRequest : Request<StoryQuestStartResponse>
{
    public int quest_id;
    internal override string Url => "story/quest_start";
}

public class StoryViewingRequest : Request<StoryViewingResponse>
{
    public int story_id;
    internal override string Url => "story/start";
}

public class SubStoryLtoReadStoryRequest : Request<SubStoryLtoReadStoryResponse>
{
    public int sub_story_id;
    internal override string Url => "sub_story/lto/read_story";
}

public class SubStorySkeConfirmRequest : Request<SubStorySkeConfirmResponse>
{
}

public class SubStorySkeReadStoryRequest : Request<SubStorySkeReadStoryResponse>
{
    public int sub_story_id;
    internal override string Url => "sub_story/ske/read_story";
}

public class SubStorySspReadSspStoryRequest : Request<SubStorySspReadSspStoryResponse>
{
    public int sub_story_id;
    internal override string Url => "sub_story/ssp/read_ssp_story";
}

public class SupportUnitChangeSettingRequest : Request<SupportUnitChangeSettingResponse>
{
    public int support_type;
    public int position;
    public int action;
    public int unit_id;
    internal override string Url => "support_unit/change_setting";
}

public class SupportUnitGetSettingRequest : Request<SupportUnitGetSettingResponse>
{
    internal override string Url => "support_unit/get_setting";
}

public class TestBuyTicketRequest : Request<TestBuyTicketResponse>
{
    public int season_id;
    internal override string Url => "test/buy_ticket";
}

public class TowerBattleFinishRequest : Request<TowerBattleFinishResponse>
{
    public int quest_id;
    public TowerQueryUnit[] user_unit;
    public TowerQueryUnit[] versus_user_unit;
    public int remain_time;
    public int fps;
    public int auto_clear;
    internal override string Url => "tower/battle_finish";
}

public class TowerBattleRetireRequest : Request<TowerBattleRetireResponse>
{
    public int quest_id;
    internal override string Url => "tower/battle_retire";
}

public class TowerBattleSkipRequest : Request<TowerBattleSkipResponse>
{
    internal override string Url => "tower/battle_skip";
}

public class TowerBattleStartRequest : Request<TowerBattleStartResponse>
{
    public int quest_id;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    internal override string Url => "tower/battle_start";
}

public class TowerCloisterBattleFinishRequest : Request<TowerCloisterBattleFinishResponse>
{
    public int quest_id;
    public int wave;
    public TowerQueryUnit[] user_unit;
    public TowerQueryUnit[] versus_user_unit;
    public int remain_time;
    public int fps;
    public int auto_clear;
    internal override string Url => "tower/cloister_battle_finish";
}

public class TowerCloisterBattleRetireRequest : Request<TowerCloisterBattleRetireResponse>
{
    public int quest_id;
    internal override string Url => "tower/cloister_battle_retire";
}

public class TowerCloisterBattleStartRequest : Request<TowerCloisterBattleStartResponse>
{
    public int quest_id;
    public int wave;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    internal override string Url => "tower/cloister_battle_start";
}

public class TowerExBattleFinishRequest : Request<TowerExBattleFinishResponse>
{
    public int quest_id;
    public int total_damage;
    public TowerWaveResultInfo[] wave_result_list;
    public TowerQueryUnit[] versus_user_unit;
    public int fps;
    public int auto_clear;
    public string[] battle_log_list;
    internal override string Url => "tower/ex_battle_finish";
}

public class TowerExBattleRetireRequest : Request<TowerExBattleRetireResponse>
{
    public int quest_id;
    internal override string Url => "tower/ex_battle_retire";
}

public class TowerExBattleStartRequest : Request<TowerExBattleStartResponse>
{
    public int quest_id;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    internal override string Url => "tower/ex_battle_start";
}

public class TowerExSupportUnitList2Request : Request<TowerExSupportUnitList2Response>
{
    internal override string Url => "tower/ex_support_unit_list2";
}

public class TowerExSupportUnitListRequest : Request<TowerExSupportUnitListResponse>
{
    internal override string Url => "tower/ex_support_unit_list";
}

public class TowerRehearsalFinishRequest : Request<TowerRehearsalFinishResponse>
{
    public int quest_id;
    public TowerQueryUnit[] user_unit;
    public TowerQueryUnit[] versus_user_unit;
    public int remain_time;
    public int fps;
    public int auto_clear;
    internal override string Url => "tower/rehearsal_finish";
}

public class TowerRehearsalRetireRequest : Request<TowerRehearsalRetireResponse>
{
    public int quest_id;
    internal override string Url => "tower/rehearsal_retire";
}

public class TowerRehearsalStartRequest : Request<TowerRehearsalStartResponse>
{
    public int quest_id;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    internal override string Url => "tower/rehearsal_start";
}

public class TowerReplayListRequest : Request<TowerReplayListResponse>
{
    public int quest_id;
    public int fps;
    public int team_level;
    internal override string Url => "tower/replay_list";
}

public class TowerReplayRequest : Request<TowerReplayResponse>
{
    public int quest_id;
    public int fps;
    public string enc_key;
    internal override string Url => "tower/replay";
}

public class TowerReplayReportRequest : Request<TowerReplayReportResponse>
{
    public int quest_id;
    public int fps;
    public string enc_key;
    internal override string Url => "tower/replay_report";
}

public class TowerResetRequest : Request<TowerResetResponse>
{
    internal override string Url => "tower/reset";
}

public class TowerSupportUnitList2Request : Request<TowerSupportUnitList2Response>
{
    internal override string Url => "tower/support_unit_list2";
}

public class TowerSupportUnitListRequest : Request<TowerSupportUnitListResponse>
{
    internal override string Url => "tower/support_unit_list";
}

public class TowerTopRequest : Request<TowerTopResponse>
{
    public int is_first;
    public int return_cleared_ex_quest;
    internal override string Url => "tower/top";
}

public class TrainingQuestFinishRequest : Request<TrainingQuestFinishResponse>
{
    public int quest_id;
    public int remain_time;
    public UnitHpInfo[] unit_hp_list;
    public long owner_viewer_id;
    public int support_position;
    public int is_friend;
    internal override string Url => "training_quest/finish";
}

public class TrainingQuestRetireRequest : Request<TrainingQuestRetireResponse>
{
    public int quest_id;
    internal override string Url => "training_quest/retire";
}

public class TrainingQuestSkipRequest : Request<TrainingQuestSkipResponse>
{
    public int quest_id;
    public int random_count;
    public int current_ticket_num;
    internal override string Url => "training_quest/quest_skip";
}

public class TrainingQuestStartRequest : Request<TrainingQuestStartResponse>
{
    public int quest_id;
    public string token;
    public long owner_viewer_id;
    public int support_unit_id;
    public int support_battle_rarity;
    public int is_friend;
    internal override string Url => "training_quest/start";
}

public class TtkChooseWeaponRequest : Request<TtkChooseWeaponResponse>
{
    public int weapon_id;
    internal override string Url => "ttk/choose_weapon";
}

public class TtkFinishRequest : Request<TtkFinishResponse>
{
    public int play_id;
    public int base_score;
    public int coin_num;
    public TtkBeatEnemyInfo[] beat_enemy_info;
    public int remain_life;
    public int elapsed_frame;
    internal override string Url => "ttk/finish";
}

public class TtkReadCatalogRequest : Request<TtkReadCatalogResponse>
{
    internal override string Url => "ttk/read_catalog";
}

public class TtkReadStoryRequest : Request<TtkReadStoryResponse>
{
    public int ttk_story_id;
    internal override string Url => "ttk/read_story";
}

public class TtkStartRequest : Request<TtkStartResponse>
{
    public int difficulty_level;
    internal override string Url => "ttk/start";
}

public class TtkTopRequest : Request<TtkTopResponse>
{
    internal override string Url => "ttk/top";
}

public class TutorialUpdateRequest : Request<TutorialUpdateResponse>
{
    public int step;
    public int skip;
    public string user_name;
    internal override string Url => "tutorial/update_step";
}

public class UekBossBattleFinishRequest : Request<UekBossBattleFinishResponse>
{
    public int enemy_id;
    public int battle_log_id;
    public HatsuneBossBattleFinishUnit user_unit;
    public int remain_time;
    public int total_damage;
    internal override string Url => "uek/boss_battle_finish";
}

public class UekBossBattleRetireRequest : Request<UekBossBattleRetireResponse>
{
    public int enemy_id;
    public int battle_log_id;
    internal override string Url => "uek/boss_battle_retire";
}

public class UekBossBattleStartRequest : Request<UekBossBattleStartResponse>
{
    public int enemy_id;
    internal override string Url => "uek/boss_battle_start";
}

public class UekTopRequest : Request<UekTopResponse>
{
    public int event_id;
    internal override string Url => "uek/uek_top";
}

public class UniqueEquipCraftRequest : Request<UniqueEquipCraftResponse>
{
    public int equip_id;
    public UserEquipParameterIdCount[] equip_recipe_list;
    public UserEquipParameterIdCount[] item_recipe_list;
    public int current_equip_num;
    internal override string Url => "equipment/craft_unique";
}

public class UniqueEquipEnhanceRequest : Request<UniqueEquipEnhanceResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public InventoryInfoPost[] item_list;
    public int current_enhancement_pt;
    internal override string Url => "equipment/enhance_unique";
}

public class UniqueEquipMultiEnhanceRequest : Request<UniqueEquipMultiEnhanceResponse>
{
    public int unit_id;
    public int slot_id;
    public int current_gold;
    public EnhanceRecipe[] craft_equip_recipe;
    public EnhanceRecipe[] craft_item_recepe;
    public EnhanceRecipe[] rankup_equip_recipe;
    public EnhanceRecipe[] rankup_item_recipe;
    public EnhanceRecipe[] rankup_potion_recipe;
    public int current_rank;
    public int after_rank;
    public EnhanceRecipe[] enhancement_item_list;
    public int current_enhancement_pt;
    internal override string Url => "equipment/multi_enhance_unique";
}

public class UniqueEquipRankupRequest : Request<UniqueEquipRankupResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public UserEquipParameterIdCount[] equip_recipe_list;
    public UserEquipParameterIdCount[] item_recipe_list;
    public int current_rank;
    internal override string Url => "equipment/rankup_unique";
}

public class UnitCraftEquipRequest : Request<UnitCraftEquipResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public UserEquipParameterIdCount[] equip_recipe_list;
    public ItemInfo[] item_list;
    internal override string Url => "unit/craft_equip";
}

public class UnitCraftEquipUniqueRequest : Request<UnitCraftEquipUniqueResponse>
{
    public int unit_id;
    public int equip_slot_num;
    public UserEquipParameterIdCount[] equip_recipe_list;
    public UserEquipParameterIdCount[] item_recipe_list;
    internal override string Url => "unit/craft_equip_unique";
}

public class UnitEquipRequest : Request<UnitEquipResponse>
{
    public int unit_id;
    public int equip_slot_num;
    internal override string Url => "unit/equip";
}

public class UnitEvolutionRequest : Request<UnitEvolutionResponse>
{
    public int unit_id;
    public int current_unit_rarity;
    internal override string Url => "unit/evolution";
}

public class UnitEvolutionRaritySixRequest : Request<UnitEvolutionRaritySixResponse>
{
    public int unit_id;
    public int current_unit_rarity;
    internal override string Url => "unit/evolution_rarity_6";
}

public class UnitFavoriteRequest : Request<UnitFavoriteResponse>
{
    public int[] unit_id_list;
    public int[] favorite_flag_list;
    internal override string Url => "unit/favorite";
}

public class UnitFreeAutomaticEnhanceRequest : Request<UnitFreeAutomaticEnhanceResponse>
{
    public int unit_id;
    public int after_level;
    public int[] equip_slot_num_list;
    public SkillLevelUpDetail[] skill_levelup_list;
    public int excludes_equip;
    internal override string Url => "unit/free_automatic_enhance";
}

public class UnitFreeEquipRequest : Request<UnitFreeEquipResponse>
{
    public int unit_id;
    public int[] equip_slot_num_list;
    internal override string Url => "unit/free_equip";
}

public class UnitFreeEvolutionRequest : Request<UnitFreeEvolutionResponse>
{
    public int unit_id;
    public int current_unit_rarity;
    internal override string Url => "unit/free_evolution";
}

public class UnitFreeLevelUpRequest : Request<UnitFreeLevelUpResponse>
{
    public int unit_id;
    public int after_level;
    internal override string Url => "unit/free_level_up";
}

public class UnitFreeMultiEvolutionRequest : Request<UnitFreeMultiEvolutionResponse>
{
    public int unit_id;
    public int current_rarity;
    public int after_rarity;
    internal override string Url => "unit/free_multi_evolution";
}

public class UnitFreePromotionRequest : Request<UnitFreePromotionResponse>
{
    public int unit_id;
    public int target_promotion_level;
    internal override string Url => "unit/free_promotion";
}

public class UnitGrowthEnhanceRequest : Request<UnitGrowthEnhanceResponse>
{
    public int unit_id;
    public int target_promotion_level;
    internal override string Url => "unit/growth_enhance";
}

public class UnitMultiEquipRequest : Request<UnitMultiEquipResponse>
{
    public int unit_id;
    public int[] equip_slot_num_list;
    public UserEquipParameterIdCount[] equip_recipe_list;
    public ItemInfo[] item_list;
    internal override string Url => "unit/multi_equip";
}

public class UnitMultiEvolutionRequest : Request<UnitMultiEvolutionResponse>
{
    public int unit_id;
    public int current_rarity;
    public int after_rarity;
    public int current_gold_num;
    public int current_memory_piece_num;
    internal override string Url => "unit/multi_evolution";
}

public class UnitMultiPromotionRequest : Request<UnitMultiPromotionResponse>
{
    public int target_promotion_level;
    public RequiredMaterialList[] equip_recipe_list;
    public ItemInfo[] item_list;
    public int unit_id;
    internal override string Url => "unit/multi_promotion";
}

public class UnitPromotionRequest : Request<UnitPromotionResponse>
{
    public int unit_id;
    public int current_promotion_level;
    internal override string Url => "unit/promotion";
}

public class UnitSetGrowthItemRequest : Request<UnitSetGrowthItemResponse>
{
    public int unit_id;
    public int item_id;
    internal override string Url => "unit/set_growth_item";
}

public class UnitUniqueEquipRequest : Request<UnitUniqueEquipResponse>
{
    public int unit_id;
    public int equip_slot_num;
    internal override string Url => "unit/equip_unique";
}

public class UnlockRaritySixSlotRequest : Request<UnlockRaritySixSlotResponse>
{
    public int unit_id;
    public int slot_id;
    public int current_unlock_level;
    internal override string Url => "unit/unlock_rarity_6_slot";
}

public class UnlockUnitRequest : Request<UnlockUnitResponse>
{
    public int unit_id;
    internal override string Url => "unit/unlock_unit";
}

public class UpdateSkipQuestListRequest : Request<UpdateSkipQuestListResponse>
{
    public UserMyQuestForPost[] my_quest_tab_list;
    internal override string Url => "my_quest/update_skip_quest_list";
}

public class UpdateTabRequest : Request<UpdateTabResponse>
{
    public int tab_number;
    public string tab_name;
    internal override string Url => "my_quest/update_tab";
}

public class UseExpItemRequest : Request<UseExpItemResponse>
{
    public ItemInfo[] item_list;
    public int unit_id;
    internal override string Url => "item/exp";
}

public class UserInviteClanListRequest : Request<UserInviteClanListResponse>
{
    public int page;
    internal override string Url => "clan/invited_clan_list";
}

public class VoteExecRequest : Request<VoteExecResponse>
{
    public int vote_id;
    public int unit_rarity;
    public int unit_id;
    internal override string Url => "vote/exec";
}

public class VoteTopRequest : Request<VoteTopResponse>
{
    public int vote_id;
    internal override string Url => "vote/top";
}


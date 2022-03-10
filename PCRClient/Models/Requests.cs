namespace PCRClient.Models;
// ReSharper disable InconsistentNaming
#pragma warning disable CS8618

public class AcceptAgreementResponse : ResponseBase
{
}

public class AddUserTipsResponse : ResponseBase
{
}

public class ArcadeBuyResponse : ResponseBase
{
    public InventoryInfo[] item_data;
}

public class ArcadeReadStoryResponse : ResponseBase
{
}

public class ArcadeStoryListResponse : ResponseBase
{
    public int[] story_id_list;
}

public class ArcadeSyncStoryListResponse : ResponseBase
{
    public int[] story_id_list;
}

public class ArcadeTopResponse : ResponseBase
{
    public int[] arcade_id_list;
}

public class ArenaApplyResponse : ResponseBase
{
    public long battle_viewer_id;
    public int true_rank;
}

public class ArenaCancelResponse : ResponseBase
{
    public SearchOpponent[] search_opponent;
}

public class ArenaFinishResponse : ResponseBase
{
    public int old_record;
    public int new_record;
    public ArenaInfo arena_info;
    public InventoryInfo highest_rank_reward;
}

public class ArenaHistoryDamageRankingResponse : ResponseBase
{
    public UnitDataForView[] user_unit_list;
    public UnitDataForView[] opponent_unit_list;
    public UnitDamageInfo[] damage_list;
}

public class ArenaHistoryDetailResponse : ResponseBase
{
    public VersusResultDetail versus_result_detail;
}

public class ArenaHistoryResponse : ResponseBase
{
    public VersusResult[] versus_result_list;
}

public class ArenaInfoResponse : ResponseBase
{
    public ArenaInfo arena_info;
    public DeckData attack_deck;
    public DeckData defend_deck;
    public SearchOpponent[] search_opponent;
    public InventoryInfo reward_info;
    public int reward_hour_num;
    public bool is_time_reward_max;
}

public class ArenaIntervalCancelResponse : ResponseBase
{
    public ArenaInfo arena_info;
    public UserJewel user_jewel;
}

public class ArenaMoveGroupResponse : ResponseBase
{
    public ArenaInfo arena_info;
}

public class ArenaRankingResponse : ResponseBase
{
    public RankingSearchOpponent[] ranking;
}

public class ArenaReplayResponse : ResponseBase
{
    public int seed;
    public int is_challenge;
    public UnitData[] user_unit_list;
    public UnitData[] opponent_unit_list;
}

public class ArenaResetBattleNumberResponse : ResponseBase
{
    public ArenaInfo arena_info;
    public UserJewel user_jewel;
}

public class ArenaSearchResponse : ResponseBase
{
    public SearchOpponent[] search_opponent;
}

public class ArenaStartResponse : ResponseBase
{
    public long my_viewer_id;
    public long battle_viewer_id;
    public int battle_id;
    public int battle_speed;
    public ArenaWaveInfo[] wave_info_list;
}

public class ArenaTimeRewardAcceptResponse : ResponseBase
{
    public InventoryInfo reward_info;
    public int add_present_count;
}

public class AutomaticEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
}

public class AutomaticEquipEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] item_list;
    public UserGold user_gold;
}

public class AutomaticEquipEnhanceUniqueResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] item_list;
    public UserGold user_gold;
}

public class BaseResponse : ResponseBase
{
    public Notification notification;
}

public class ChangeRarityResponse : ResponseBase
{
    public UnitData[] unit_data_list;
}

public class ChangeRoleResponse : ResponseBase
{
    public ClanMemberInfo[] members;
}

public class ChangeSkinResponse : ResponseBase
{
}

public class CharaETicketExchangeResponse : ResponseBase
{
    public InventoryInfo[] reward_info_list;
    public InventoryInfo[] item_data;
}

public class CharaETicketRewardsResponse : ResponseBase
{
    public CharaExchangeTicketReward[] rewards;
}

public class CheckAgreementResponse : ResponseBase
{
    public AgreementStatus agreement;
    public AgreementStatus policy;
}

public class CheckExistClanResponse : ResponseBase
{
}

public class ClanBattleBossHistoryResponse : ResponseBase
{
    public BossHistory[] boss_history;
}

public class ClanBattleBossInfoResponse : ResponseBase
{
    public DamageHistory[] damage_history;
    public int current_hp;
    public int attack_count;
    public int fighter_num;
}

public class ClanBattleBossRankingInClanResponse : ResponseBase
{
    public BossRankingInClan[] bosses;
    public BossRankingInClanSummary summary;
}

public class ClanBattleConfirmRehearsalMyLogResponse : ResponseBase
{
    public int is_full;
    public MyLog[] mylogs;
}

public class ClanBattleConfirmTrainingMyLogResponse : ResponseBase
{
    public int is_full;
    public MyLog[] mylogs;
}

public class ClanBattleDamageReportResponse : ResponseBase
{
    public DamageReport[] damage_report;
    public int max_hp;
}

public class ClanBattleDeleteRehearsalMyLogResponse : ResponseBase
{
    public int mylog_count;
}

public class ClanBattleDeleteTrainingMyLogResponse : ResponseBase
{
    public int mylog_count;
}

public class ClanBattleFinishResponse : ResponseBase
{
    public int acquired_gold;
    public UserGold user_gold;
    public int damage_result;
    public int dead;
    public int carry_over_time;
    public int is_over_kill;
    public int attack_count;
    public InventoryInfo[] challenge_reward;
    public int add_present_count;
}

public class ClanBattleHistoryReportResponse : ResponseBase
{
    public HistoryReport[] history_report;
    public int lap_num;
    public int order_num;
}

public class ClanBattleMissionIndexResponse : ResponseBase
{
    public UserMissionInfo[] missions;
    public long daily_reset_time;
}

public class ClanBattleMyLogDetailResponse : ResponseBase
{
    public int lap_num;
    public int order_num;
}

public class ClanBattleMyLogResponse : ResponseBase
{
    public MyLog[] actual_logs;
    public MyLog[] rehearsal_logs;
    public MyLog[] training_logs;
}

public class ClanBattlePeriodRankingResponse : ResponseBase
{
    public PeriodRanking[] period_ranking;
    public PeriodRanking my_clan_data;
    public int clan_battle_id;
    public int period;
    public int clan_battle_mode;
}

public class ClanBattleRehearsalFinishResponse : ResponseBase
{
    public int damage_result;
    public int carry_over_time;
}

public class ClanBattleRehearsalStartResponse : ResponseBase
{
    public int limit_time;
    public UnitData enemy_data;
    public int battle_log_id;
    public SkinDataForRequest[] skin_data_for_request;
    public int seed;
    public int current_hp;
}

public class ClanBattleReloadDetailInfoResponse : ResponseBase
{
    public int fighter_num;
    public int current_hp;
}

public class ClanBattleResetHpResponse : ResponseBase
{
    public UserJewel user_jewel;
    public int[] used_unit;
}

public class ClanBattleSaveRehearsalMyLogResponse : ResponseBase
{
    public int mylog_count;
}

public class ClanBattleSaveTrainingMyLogResponse : ResponseBase
{
    public int mylog_count;
}

public class ClanBattleStartResponse : ResponseBase
{
    public int limit_time;
    public UnitData enemy_data;
    public int battle_log_id;
    public int current_hp;
    public UserGold user_gold;
    public SkinDataForRequest[] skin_data_for_request;
    public int seed;
}

public class ClanBattleSuggestDeckListResponse : ResponseBase
{
    public ClanBattleSuggestDeck[] suggest_deck_list;
}

public class ClanBattleSuggestDeckReplayResponse : ResponseBase
{
    public int limit_time;
    public UnitData[] user_unit_list;
    public UnitData enemy_data;
    public int current_hp;
    public int seed;
    public string report_key;
}

public class ClanBattleSuggestDeckReplayReportResponse : ResponseBase
{
}

public class ClanBattleSupportUnitList2Response : ResponseBase
{
    public ClanBattleSupportUnitLight[] support_unit_list;
}

public class ClanBattleSupportUnitListResponse : ResponseBase
{
    public ClanBattleSupportUnit[] support_unit_list;
}

public class ClanBattleTopResponse : ResponseBase
{
    public int clan_battle_id;
    public int period;
    public int lap_num;
    public BossInfo[] boss_info;
    public DamageHistory[] damage_history;
    public int period_rank;
    public int remaining_count;
    public int[] used_unit;
    public int[] using_unit;
    public int point;
    public int hp_reset_count;
    public BossReward[] boss_reward;
    public RankResult[] last_rank_result;
    public int change_period;
    public int change_season;
    public int add_present_count;
    public int carry_over_time;
    public int clan_battle_mode;
    public int next_clan_battle_mode;
    public ClanBattleTopUserClanInformation user_clan;
    public UserMissionInfo[] missions;
    public ClanBattleExtraBattleChallengeRewardInfo[] challenge_reward;
}

public class ClanBattleTrainingFinishResponse : ResponseBase
{
    public int damage_result;
    public int carry_over_time;
}

public class ClanBattleTrainingStartResponse : ResponseBase
{
    public int limit_time;
    public UnitData enemy_data;
    public int battle_log_id;
    public SkinDataForRequest[] skin_data_for_request;
    public int seed;
    public int current_hp;
}

public class ClanBlockListResponse : ResponseBase
{
    public BlockUserDetail[] list;
}

public class ClanBreakUpResponse : ResponseBase
{
    public int add_present_count;
}

public class ClanChatInfoListResponse : ResponseBase
{
    public ChatMessageInfo[] clan_chat_message;
    public ChatMemberInfo[] users;
    public EquipRequests[] equip_requests;
    public UserEquipParameter[] user_equip_data;
    public int latest_comment_id;
    public int[] expired_message_ids;
    public string next_search_date;
    public int wait_interval;
}

public class ClanChatResponse : ResponseBase
{
}

public class ClanCreateResponse : ResponseBase
{
    public int clan_id;
    public eUserClanJoinStatus clan_status;
}

public class ClanDamageReportResponse : ResponseBase
{
    public HistoryReport[] damage_report;
}

public class ClanDetailResponse : ResponseBase
{
    public ClanMemberInfo[] member;
    public long owner_viewer_id;
    public int invite_id;
    public int block_id;
}

public class ClanInfoResponse : ResponseBase
{
    public ClanData clan;
    public eUserClanJoinStatus clan_status;
    public InventoryInfoShort[] user_equip;
    public int have_join_request;
    public int unread_liked_count;
    public int is_equip_request_finish_checked;
    public int add_present_count;
    public UserGold user_gold;
    public long latest_request_time;
    public int current_period_ranking;
    public int last_total_ranking;
    public int current_clan_battle_mode;
    public int current_battle_joined;
    public int last_clan_battle_mode;
    public int last_battle_joined;
    public int grade_rank;
    public int clan_point;
    public int remaining_count;
}

public class ClanInviteBlockResponse : ResponseBase
{
}

public class ClanInviteCancelResponse : ResponseBase
{
}

public class ClanInvitedUserListResponse : ResponseBase
{
    public InvitedUserDetail[] list;
    public long oldest_time;
}

public class ClanInvitePermissionResponse : ResponseBase
{
}

public class ClanInviteResponse : ResponseBase
{
}

public class ClanInviteRejectResponse : ResponseBase
{
}

public class ClanInviteUnblockResponse : ResponseBase
{
}

public class ClanJoinResponse : ResponseBase
{
    public eUserClanJoinStatus clan_status;
}

public class ClanJoinRequestAcceptResponse : ResponseBase
{
}

public class ClanJoinRequestCancelResponse : ResponseBase
{
}

public class ClanJoinRequestListResponse : ResponseBase
{
    public JoinRequestUserInfo[] list;
    public long oldest_time;
}

public class ClanJoinRequestRejectResponse : ResponseBase
{
}

public class ClanLeaveResponse : ResponseBase
{
    public int add_present_count;
}

public class ClanLikeResponse : ResponseBase
{
    public UserStaminaInfo stamina_info;
}

public class ClanMemberBattleFinishResponse : ResponseBase
{
}

public class ClanMemberBattleStartResponse : ResponseBase
{
    public int battle_id;
    public PracticeWaveInfo[] wave_info_list;
}

public class ClanRemoveResponse : ResponseBase
{
}

public class ClanSearchResponse : ResponseBase
{
    public ClanInfo[] list;
}

public class ClanSearchUserResponse : ResponseBase
{
    public ClanMemberInfo[] search_user_list;
}

public class ClanSetDispatchStatusResponse : ResponseBase
{
    public UnitDataForClanMember[] dispatch_units;
    public InventoryInfo dispatch_time_bonus;
    public InventoryInfo dispatch_count_bonus;
    public int add_present_count;
}

public class ClanUpdateResponse : ResponseBase
{
    public ClanInfo clan;
}

public class CloisterBattleSkipResponse : ResponseBase
{
    public QuestResult[] quest_result_list;
    public InventoryInfo[] bonus_reward_list;
    public UserGold user_gold;
    public InventoryInfo[] item_list;
    public int cloister_remain_clear_count;
    public int add_present_count;
}

public class DeckUpdateListResponse : ResponseBase
{
}

public class DeckUpdateResponse : ResponseBase
{
}

public class DungeonBattleFinishResponse : ResponseBase
{
    public int quest_id;
    public bool complete;
    public DungeonQuest[] area_quest_list;
    public RestChallengeInfo[] rest_challenge_count;
    public InventoryInfo[] reward_list;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
    public int add_present_count;
    public int first_area_clear_flag;
    public DungeonBattleMission[] current_battle_mission_list;
}

public class DungeonBattleRetireResponse : ResponseBase
{
}

public class DungeonBattleStartResponse : ResponseBase
{
    public UnitData[] user_unit;
    public UnitData[] versus_user_unit;
    public int battle_log_id;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
    public int seed;
    public int support_unit_hp;
}

public class DungeonClanDispatchUnitListResponse : ResponseBase
{
    public ClanDispatchUnit[] dispatch_unit_list;
}

public class DungeonDispatchUnitList2Response : ResponseBase
{
    public ClanDispatchUnitLight[] dispatch_unit_list;
}

public class DungeonEnterAreaResponse : ResponseBase
{
    public int quest_id;
    public bool complete;
    public DungeonQuest[] area_quest_list;
    public DungeonUnit[] dungeon_unit;
    public RestChallengeInfo[] rest_challenge_count;
    public int[] dungeon_cleared_area_id_list;
    public int season_pack_rate;
    public DungeonBattleMission[] current_battle_mission_list;
    public long enter_reset_time;
}

public class DungeonInfoResponse : ResponseBase
{
    public int enter_area_id;
    public RestChallengeInfo[] rest_challenge_count;
    public DungeonArea[] dungeon_area;
    public int[] dungeon_cleared_area_id_list;
    public int season_pack_rate;
}

public class DungeonResetResponse : ResponseBase
{
    public RestChallengeInfo[] rest_challenge_count;
    public DungeonArea[] dungeon_area;
    public int season_pack_rate;
}

public class DungeonSkipResponse : ResponseBase
{
    public int start_quest_id;
    public RestChallengeInfo[] rest_challenge_count;
    public int season_pack_rate;
    public QuestResult[] skip_result_list;
    public UserGold user_gold;
    public int add_present_count;
    public bool upper_limit_flag;
}

public class EmblemChangeResponse : ResponseBase
{
}

public class EmblemTopResponse : ResponseBase
{
    public UserEmblem[] user_emblem_list;
}

public class EquipCraftResponse : ResponseBase
{
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
}

public class EquipDonateResponse : ResponseBase
{
    public int donation_num;
    public InventoryInfo donate_equip;
    public InventoryInfo[] rewards;
    public int add_present_count;
}

public class EquipEnhanceMaxResponse : ResponseBase
{
    public UnitData unit_data;
    public UserJewel user_jewel;
}

public class EquipEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
    public InventoryInfo[] item_list;
}

public class EquipGetRequestResponse : ResponseBase
{
    public EquipRequests request;
    public InventoryInfo[] equip_list;
    public int receive_donation_sum;
    public int add_present_count;
}

public class EquipmentFreeEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
}

public class EquipRequestResponse : ResponseBase
{
    public long latest_request_time;
}

public class EventGachaExecResponse : ResponseBase
{
    public EventBoxGachaHitRewardInfo[] draw_result;
    public InventoryInfo[] reward_info_list;
    public int add_present_count;
    public HatsuneEventBossStatus[] unlock_bosses;
}

public class EventGachaIndexResponse : ResponseBase
{
    public EventGachaInfo event_gacha_info;
}

public class EventGachaLineupResponse : ResponseBase
{
    public EventBoxGachaSet[] event_gacha_lineup;
}

public class EventGachaResetResponse : ResponseBase
{
    public EventGachaInfo event_gacha_info;
}

public class FkeFinishResponse : ResponseBase
{
    public int total_fke_point;
    public int add_present_count;
}

public class FkeStartResponse : ResponseBase
{
    public int fke_play_id;
}

public class FkeSyncTopResponse : ResponseBase
{
    public int total_fke_point;
    public int best_fke_point;
    public int[] happening_id_list;
}

public class FkeTopResponse : ResponseBase
{
    public int total_fke_point;
    public int best_fke_point;
    public int[] happening_id_list;
}

public class FriendAcceptResponse : ResponseBase
{
}

public class FriendBattleFinishResponse : ResponseBase
{
}

public class FriendBattleStartResponse : ResponseBase
{
    public int battle_id;
    public PracticeWaveInfo[] wave_info_list;
}

public class FriendBattleTopResponse : ResponseBase
{
    public PracticeDeckData[] my_deck_list;
    public FriendBattleInfo[] friend;
}

public class FriendBattleUpdateDeckResponse : ResponseBase
{
}

public class FriendCancelResponse : ResponseBase
{
}

public class FriendFriendListResponse : ResponseBase
{
    public FriendInfo[] friend_list;
    public CampaignTarget[] campaign_target_list;
}

public class FriendGetMissionTargetFriendCountResponse : ResponseBase
{
    public int target_friend_count;
}

public class FriendMissionAcceptResponse : ResponseBase
{
    public int team_level;
    public int team_exp;
    public UserStaminaInfo stamina_info;
    public InventoryInfo[] rewards;
    public bool flag_exchange_team_exp;
    public int add_present_count;
}

public class FriendMissionIndexResponse : ResponseBase
{
    public UserMissionInfo[] missions;
    public bool campaign_target_flag;
}

public class FriendPendingListResponse : ResponseBase
{
    public FriendInfo[] pending_list;
    public int friend_num;
    public CampaignTarget[] campaign_target_list;
}

public class FriendRejectResponse : ResponseBase
{
}

public class FriendRemoveResponse : ResponseBase
{
}

public class FriendRequestListResponse : ResponseBase
{
    public FriendInfo[] request_list;
    public int friend_num;
    public CampaignTarget[] campaign_target_list;
}

public class FriendRequestResponse : ResponseBase
{
    public UnitDataForView favorite_unit;
}

public class FriendSearchResponse : ResponseBase
{
    public FriendInfo[] search_list;
    public int friend_num;
    public CampaignTarget[] campaign_target_list;
}

public class GachaExchangePointResponse : ResponseBase
{
    public InventoryInfo[] reward_info_list;
    public GachaPointInfo gacha_point_info;
    public GachaPointInfo sdfes_gacha_point_info;
    public GachaBonusResult bonus_reward_info;
    public GachaGrowthUnitInfo growth_unit_info;
}

public class GachaExecResponse : ResponseBase
{
    public InventoryInfo[] reward_info_list;
    public UserGold user_gold;
    public PrizeRewardInfo prize_reward_info;
    public GachaPointInfo gacha_point_info;
    public GachaPointInfo sdfes_gacha_point_info;
    public int add_present_count;
    public GachaBonusResult bonus_reward_info;
    public GachaGrowthUnitInfo growth_unit_info;
}

public class GachaIndexResponse : ResponseBase
{
    public GachaParameter[] gacha_info;
    public int nngtime;
    public CampaignGachaInfo campaign_info;
    public string sdg_url_param;
    public GachaPointReset[] gacha_point_reset_list;
    public GachaPointReset gacha_point_reset;
    public GachaPointReset sdfes_gacha_point_reset;
    public GachaPointReset return_fes_gacha_point_reset;
    public int current_gacha_point;
    public TicketGachaParameter[] ticket_gacha_info;
}

public class GachaPrizeHistoryResponse : ResponseBase
{
    public GachaPrizeHistoryList[] gacha_prize_history_list;
}

public class GachaPrizeRewardResponse : ResponseBase
{
    public GachaPrizeItemDetail[] gacha_prize_reward_list;
}

public class GachaSelectPrizeResponse : ResponseBase
{
}

public class GachaSpecialFesIndexResponse : ResponseBase
{
    public GachaParameter[] gacha_info;
    public TicketGachaParameter[] ticket_gacha_info;
}

public class GetFriendSupportUnitListResponse : ResponseBase
{
    public SupportUnitStatus[] friend_support_unit_list;
    public SupportUnitStatus[] general_support_unit_list;
}

public class GetTipsListResponse : ResponseBase
{
    public int[] tips_id_list;
}

public class GrandArenaApplyResponse : ResponseBase
{
    public long battle_viewer_id;
    public int true_rank;
}

public class GrandArenaCancelIntervalResponse : ResponseBase
{
    public GrandArenaInfo grand_arena_info;
    public UserJewel user_jewel;
}

public class GrandArenaCancelResponse : ResponseBase
{
    public GrandArenaSearchOpponent[] search_opponent;
}

public class GrandArenaFinishResponse : ResponseBase
{
    public int old_record;
    public int new_record;
    public GrandArenaInfo grand_arena_info;
    public InventoryInfo highest_rank_reward;
}

public class GrandArenaGetDestinationGroupResponse : ResponseBase
{
    public RankingGroupInfo[] group_list;
}

public class GrandArenaHistoryDetailResponse : ResponseBase
{
    public GrandArenaHistoryDetailInfo grand_arena_history_detail;
}

public class GrandArenaHistoryResponse : ResponseBase
{
    public GrandArenaHistoryInfo[] grand_arena_history_list;
}

public class GrandArenaInfoResponse : ResponseBase
{
    public GrandArenaInfo grand_arena_info;
    public DeckData[] attack_deck_list;
    public DeckData[] defend_deck_list;
    public GrandArenaSearchOpponent[] search_opponent;
    public InventoryInfo reward_info;
    public int reward_hour_num;
    public bool is_time_reward_max;
}

public class GrandArenaMoveGroupResponse : ResponseBase
{
    public GrandArenaInfo grand_arena_info;
}

public class GrandArenaRankingResponse : ResponseBase
{
    public GrandArenaSearchOpponent[] ranking;
}

public class GrandArenaReplayResponse : ResponseBase
{
    public int seed;
    public int is_challenge;
    public UnitData[] user_unit_list;
    public UnitData[] vs_user_unit_list;
}

public class GrandArenaResetBattleNumberResponse : ResponseBase
{
    public GrandArenaInfo grand_arena_info;
    public UserJewel user_jewel;
}

public class GrandArenaSearchResponse : ResponseBase
{
    public GrandArenaSearchOpponent[] search_opponent;
}

public class GrandArenaStartResponse : ResponseBase
{
    public int battle_id;
    public long my_viewer_id;
    public long battle_viewer_id;
    public int battle_speed;
    public ArenaWaveInfo[] wave_info_list;
}

public class GrandArenaTimeRewardAcceptResponse : ResponseBase
{
    public InventoryInfo reward_info;
    public int add_present_count;
}

public class HatsuneBossBattleFinishResponse : ResponseBase
{
    public LevelInfo level_info;
    public int result_type;
    public int[] unlock_quest_list;
    public int unlock_story_id;
    public int[] unlock_story_id_list;
    public InventoryInfo[] quest_rewards;
    public InventoryInfo[] first_clear_rewards;
    public int acquired_gold;
    public UserGold user_gold;
    public int add_present_count;
    public bool upper_limit_flag;
    public InventoryInfo[] treasure_rewards;
    public InventoryInfo[] item_list;
    public UnitData unlock_unit;
    public int[] event_present_list;
    public int unlock_dear_story_id;
    public int[] release_diary_ids;
    public int[] new_omp_story_ids;
    public int[] release_nyx_story_ids;
    public EventSubStoryInfo[] new_sub_story_info_list;
    public HatsuneEventBossStatus next_boss;
    public int damage_result;
    public HatsuneEventBossStatus[] unlock_bosses;
    public int[] unlock_boss_id_list;
}

public class HatsuneBossBattleSkipResponse : ResponseBase
{
    public QuestResult[] quest_result_list;
    public QuestResult[] crush_reward_list;
    public UserGold user_gold;
    public int add_present_count;
    public bool upper_limit_flag;
    public InventoryInfo[] item_list;
    public int unlock_dear_story_id;
    public int[] release_diary_ids;
    public int[] release_nyx_story_ids;
}

public class HatsuneBossBattleStartResponse : ResponseBase
{
    public int limit_time;
    public int battle_log_id;
    public int seed;
    public UnitData boss_unit_data;
    public int[] hit_treasure_nums;
    public EventHitTreasureInfo[] hit_treasure_list;
}

public class HatsuneChangeNyxItemColorResponse : ResponseBase
{
}

public class HatsuneDearFinishResponse : ResponseBase
{
    public DearPointInfo before_dear_point_info;
    public DearPointInfo after_dear_point_info;
    public int add_present_count;
}

public class HatsuneDearTopResponse : ResponseBase
{
    public DearStoryInfo[] unlock_dear_story_info_list;
    public DearPointInfo[] dear_point_info_list;
}

public class HatsuneMissionAcceptResponse : ResponseBase
{
    public int team_level;
    public int team_exp;
    public UserStaminaInfo stamina_info;
    public InventoryInfo[] rewards;
    public bool flag_exchange_team_exp;
    public int add_present_count;
    public ReleaseContentData[] release_contents;
}

public class HatsuneMissionIndexResponse : ResponseBase
{
    public UserMissionInfo[] missions;
    public UserSeasonPackInfo[] season_pack;
    public long daily_reset_time;
    public HatsuneSeriesInfo[] series_info_list;
}

public class HatsuneQuestFinishResponse : ResponseBase
{
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public InventoryInfo[] reward_list;
    public bool flag_exchange_team_exp;
    public int[] unlock_quest_list;
    public int unlock_story_id;
    public int quest_id;
    public int clear_flag;
    public int result_type;
    public int add_present_count;
    public bool upper_limit_flag;
    public int daily_clear_count;
    public LimitedShop[] limited_shop_list;
    public DailyShop daily_shop;
    public int has_drop;
    public ClanPoint clan_point;
    public InventoryInfo[] drop_rewards;
    public int[] event_present_list;
    public int[] unlock_quiz;
    public eExchangeStaminaState state_exchange_stamina;
    public int unlock_dear_story_id;
    public int[] release_diary_ids;
    public int[] new_relay_story_ids;
    public int[] new_omp_story_ids;
    public int[] release_nyx_story_ids;
    public UserGold user_gold;
    public EventSubStoryInfo[] new_sub_story_info_list;
    public HatsuneEventBossStatus[] unlock_bosses;
    public int[] unlock_boss_id_list;
}

public class HatsuneQuestRetireResponse : ResponseBase
{
}

public class HatsuneQuestSkipResponse : ResponseBase
{
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public bool flag_exchange_team_exp;
    public QuestResult[] quest_result_list;
    public InventoryInfo[] bonus_reward_list;
    public UserGold user_gold;
    public int add_present_count;
    public bool upper_limit_flag;
    public InventoryInfo[] item_list;
    public int daily_clear_count;
    public LimitedShop[] limited_shop_list;
    public DailyShop daily_shop;
    public ClanPoint clan_point;
    public eExchangeStaminaState state_exchange_stamina;
    public int unlock_dear_story_id;
    public int[] release_diary_ids;
    public int[] release_nyx_story_ids;
}

public class HatsuneQuestStartResponse : ResponseBase
{
    public WaveEnemyInfoList[] quest_wave_info;
    public UserStaminaInfo user_info;
    public int quest_id;
    public UnitData[] enemy_list;
    public int battle_log_id;
    public int seed;
    public UserGold user_gold;
    public int support_position;
}

public class HatsuneQuestTopResponse : ResponseBase
{
    public HatsuneUserEventQuest[] quest_list;
    public EventQuizInfo[] quiz;
    public int[] release_diary_ids;
    public HatsuneEventBossStatus[] bosses;
    public HatsuneEventBossStatus[] boss_battle_info;
    public HatsuneEventBossEnemyInfo[] boss_enemy_info;
}

public class HatsuneQuizAnswerResponse : ResponseBase
{
    public int is_correct;
    public int[] unlock_quest_list;
    public int[] unlock_quiz;
    public int add_present_count;
}

public class HatsuneReadDiaryResponse : ResponseBase
{
}

public class HatsuneReadNyxStoryResponse : ResponseBase
{
}

public class HatsuneReadOmpStoryResponse : ResponseBase
{
    public int add_present_count;
}

public class HatsuneReadRelayStoryResponse : ResponseBase
{
}

public class HatsuneRecoverChallengeResponse : ResponseBase
{
    public UserJewel user_jewel;
    public QuestRecoverInfo user_quest;
}

public class HatsuneSpecialBattleExFinishResponse : ResponseBase
{
    public int result_type;
    public int chat_battle_log_flag;
    public int damage_result;
}

public class HatsuneSpecialBattleExHistoryResponse : ResponseBase
{
    public int total_attack_count;
    public DateTime clear_time;
    public EventSpecialBattleExHistory[] history;
}

public class HatsuneSpecialBattleExResetResponse : ResponseBase
{
    public SpecialBattleInfo special_battle_info;
}

public class HatsuneSpecialBattleExRetireResponse : ResponseBase
{
}

public class HatsuneSpecialBattleExStartResponse : ResponseBase
{
    public int limit_time;
    public int battle_log_id;
    public EventEnemyInfo[] enemy_info;
}

public class HatsuneSpecialBattleFinishResponse : ResponseBase
{
    public LevelInfo level_info;
    public int result_type;
    public int unlock_story_id;
    public InventoryInfo[] first_clear_rewards;
    public InventoryInfo[] quest_rewards;
    public int acquired_gold;
    public UserGold user_gold;
    public InventoryInfo[] item_list;
    public InventoryInfo[] treasure_rewards;
    public UnitData unlock_unit;
    public int add_present_count;
    public int chat_battle_log_flag;
    public int unlock_dear_story_id;
    public int[] release_nyx_story_ids;
    public int damage_result;
}

public class HatsuneSpecialBattleRetireResponse : ResponseBase
{
}

public class HatsuneSpecialBattleStartResponse : ResponseBase
{
    public int limit_time;
    public int battle_log_id;
    public EventEnemyInfo[] enemy_info;
    public int[] hit_treasure_nums;
    public EventHitTreasureInfo[] hit_treasure_list;
}

public class HatsuneTopResponse : ResponseBase
{
    public HatsuneEventStatus[] event_status;
    public HatsuneEventStoryState[] additional_stories;
    public InventoryInfo boss_ticket_info;
    public DeckData[] event_decks;
    public HatsuneLoginBonusData login_bonus;
    public int add_present_count;
    public UserMissionInfo[] missions;
    public bool is_hard_quest_unlocked;
    public SpecialBattleInfo special_battle_info;
    public EventQuizInfo[] quiz;
    public int[] unchoiced_dear_story_id_list;
    public EventSpecialBattleExRankingInfo[] ex_mode_ranking;
    public int[] release_minigame;
    public int[] release_diary_ids;
    public HatsuneSeriesInfo[] series_info_list;
    public bool uek_mission_acceptable_flg;
    public int[] new_omp_story_ids;
    public HatsuneEventBossStatus[] bosses;
    public HatsuneEventBossStatus[] boss_battle_info;
    public HatsuneEventBossEnemyInfo[] boss_enemy_info;
}

public class HomeIndexResponse : ResponseBase
{
    public UnreadMessageList unread_message_list;
    public UserMissionInfo[] missions;
    public UserSeasonPackInfo[] season_pack;
    public long daily_reset_time;
    public LimitedShop[] limited_shop;
    public DailyShop daily_shop;
    public UserClan user_clan;
    public int have_clan_invitation;
    public EquipRequests new_equip_donation;
    public int have_join_request;
    public UserQuestInfo[] quest_list;
    public DungeonInfo dungeon_info;
    public TrainingQuestCount training_quest_count;
    public TrainingQuestCount training_quest_max_count;
    public long training_quest_pack_end_time;
    public int have_clan_battle_reward;
    public int[] gold;
    public int paid_jewel;
    public int free_jewel;
    public AlchemyReward[] alchemy_reward_list;
    public long alchemy_reward_time;
    public int season_pack_alert;
    public long season_pack_end_time;
    public long daily_jewel_pack_end;
    public LastFriendTime last_friend_time;
    public int clan_battle_remaining_count;
    public bool campaign_target_flag;
    public bool everyday_jewel_pack_buy;
    public CharaExchangeTicketProductData[] chara_e_ticket_purchased_times;
    public int[] purchased_arcade_id_list;
    public ShioriQuestInfo shiori_quest_info;
    public int[] srt_story_id_list;
    public SeasonPassData season_ticket;
    public int[] custom_season_pack_alert;
    public long[] custom_season_pack_end_time;
}

public class ItemETicketExchangeResponse : ResponseBase
{
    public InventoryInfo[] reward_list;
    public InventoryInfo[] item_data;
    public int add_present_count;
    public bool upper_limit_flag;
}

public class KaiserBattleGetMainBossInfoResponse : ResponseBase
{
    public KaiserBossInfo main_boss_info;
    public DeckData[] deck_list;
}

public class KaiserBattleMainFinishResponse : ResponseBase
{
    public int damage_result;
    public int acquired_gold;
    public UserGold user_gold;
    public InventoryInfo[] boss_rewards;
    public InventoryInfo[] item_list;
    public int add_present_count;
    public int attack_count;
}

public class KaiserBattleMainRetireResponse : ResponseBase
{
}

public class KaiserBattleMainStartResponse : ResponseBase
{
    public int battle_log_id;
    public EventEnemyInfo[] enemy_info;
    public UnitData[] support_unit_info;
    public SkinDataForRequest[] skin_data_for_request;
}

public class KaiserBattleMySupportListResponse : ResponseBase
{
    public SupportUnitSetting[] my_support_list;
}

public class KaiserBattleSetSupportUnitResponse : ResponseBase
{
    public InventoryInfo[] rewards;
    public int add_present_count;
    public SupportUnitSetting my_support_info;
}

public class KaiserBattleSubFinishResponse : ResponseBase
{
    public int damage_result;
    public int acquired_gold;
    public UserGold user_gold;
    public InventoryInfo[] boss_rewards;
    public int add_present_count;
}

public class KaiserBattleSubStartResponse : ResponseBase
{
    public int battle_log_id;
    public int seed;
    public UnitData[] support_unit_info;
    public SkinDataForRequest[] skin_data_for_request;
}

public class KaiserBattleSupportListResponse : ResponseBase
{
    public SupportUnitStatus[] friend_support_unit_list;
    public SupportUnitStatus[] general_support_unit_list;
}

public class KaiserBattleTopResponse : ResponseBase
{
    public int remaining_count;
    public KaiserBossInfo[] sub_boss_list;
    public InventoryInfo[] sub_boss_reward;
    public int add_present_count;
    public int[] extermination_boss_id_list;
    public KaiserBossInfo main_boss_info;
    public DeckData[] deck_list;
    public SupportUnitSetting[] my_support_list;
}

public class KaiserBattleUpdateDeckResponse : ResponseBase
{
}

public class KmkFinishResponse : ResponseBase
{
    public int current_score;
    public int total_score_all;
    public int is_opened_extra_first;
    public InventoryInfo special_reward_list;
    public KmkKillList kill_list;
    public int max_combo_count_score;
    public int after_hp_score;
    public int fever_score;
    public int add_present_count;
}

public class KmkStartResponse : ResponseBase
{
    public int play_id;
    public int seed;
}

public class KmkTopResponse : ResponseBase
{
    public int total_score_all;
    public int normal_high_score;
    public int hard_high_score;
    public int extra_high_score;
}

public class LoadIndexResponse : ResponseBase
{
    public UserInfo user_info;
    public UserJewel user_jewel;
    public UserGold user_gold;
    public UnitData[] unit_list;
    public UserChara[] user_chara_info;
    public LoadDeckData[] deck_list;
    public InventoryInfo[] material_list;
    public InventoryInfo[] item_list;
    public InventoryInfo[] user_equip;
    public int today_start_level;
    public Shop shop;
    public int[] tips_id_list;
    public IniSetting ini_setting;
    public long daily_reset_time;
    public int present_count;
    public LoginBonusList login_bonus_list;
    public int max_storage_num;
    public int can_free_gacha;
    public int can_receive_clan_battle_reward;
    public int[] campaign_list;
    public int[] read_story_ids;
    public int clan_like_count;
    public UnitDataForClanMember[] dispatch_units;
    public ClanBattleData clan_battle;
    public EventStatus[] event_statuses;
    public TowerStatus tower_status;
    public MusicIdData[] bgm;
    public int[] unlock_story_ids;
    public int can_campaign_gacha;
    public int can_guarantee_gacha;
    public int can_limited_guarantee_gacha;
    public StartDashFesInfo[] start_dash_fes_info_list;
    public ReturnFesInfo[] return_fes_info_list;
    public GrowthInfo[] growth_unit_list;
    public int pa;
    public long sdg_start;
    public long sdg_end;
    public RaceLoginBonusInfo cf;
    public CampaignDate drj;
    public GachaPointInfo[] gacha_point_info_list;
    public GachaPointInfo gacha_point_info;
    public UserBirthDayVoice voice;
    public MaintenanceStatus maintenance_status;
    public UserMyParty[] user_my_party;
    public UserMyPartyTab[] user_my_party_tab;
    public UserMyQuest[] user_my_quest;
    public CounterStopCoinExchange csc;
    public long tt;
    public long cgl;
    public long ab;
    public long ebm;
    public long lsm;
    public long last_login_bonus_time;
    public SupportUnitSetting[] friend_support_units;
    public bool my_page_exists;
    public MyPage[] my_page;
    public int[] limit_still_ids;
    public int[] read_diary_ids;
    public int[] unlock_diary_ids;
    public int[] read_relay_story_ids;
    public int[] unlock_relay_story_ids;
    public int[] read_omp_story_ids;
    public int[] unlock_omp_story_ids;
    public int[] read_nyx_story_ids;
    public int[] unlock_nyx_story_ids;
    public int nyx_color_id;
    public long cbm;
    public long csm;
    public long cbs;
    public long tbm;
    public long dbm;
    public long fst;
    public int force_release_chapter;
    public long cr;
    public long fsr;
    public long sfr;
    public long pff;
    public int een_n;
    public int een_r;
    public long serialcode_restrict_release_time;
    public long chr;
    public long nls;
    public EventSubStory[] event_sub_story;
    public long evmb;
    public long gi;
    public long erdr;
    public long lbme;
}

public class LoadNextDayIndexResponse : ResponseBase
{
    public long daily_reset_time;
    public LoginBonusList login_bonus_list;
    public int can_free_gacha;
    public int can_receive_clan_battle_reward;
    public int[] campaign_list;
    public int present_count;
    public Shop shop;
    public EventStatus[] event_statuses;
    public int can_campaign_gacha;
    public UnitDataForClanMember[] dispatch_units;
    public RaceLoginBonusInfo cf;
    public MaintenanceStatus maintenance_status;
    public CounterStopCoinExchange csc;
    public SupportUnitSetting[] friend_support_units;
    public StartDashFesInfo[] start_dash_fes_info_list;
    public ReturnFesInfo[] return_fes_info_list;
    public int[] unlock_story_ids;
}

public class MissionAcceptResponse : ResponseBase
{
    public int team_level;
    public int team_exp;
    public UserStaminaInfo stamina_info;
    public InventoryInfo[] rewards;
    public bool flag_exchange_team_exp;
    public int add_present_count;
    public ReleaseContentData[] release_contents;
    public int[] room_item_level_mission;
}

public class MissionIndexResponse : ResponseBase
{
    public UserMissionInfo[] missions;
    public UserSeasonPackInfo[] season_pack;
    public long daily_reset_time;
}

public class MultiUnlockRaritySixSlotResponse : ResponseBase
{
    public UnitData unit_data;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class MusicBuyResponse : ResponseBase
{
    public int music_id;
    public long purchased_time;
    public InventoryInfo[] item_data;
}

public class MusicSetResponse : ResponseBase
{
}

public class MusicTopResponse : ResponseBase
{
    public int[] bgm_keys;
    public MusicPurchasedData[] music_list_purchased;
}

public class MyPageSetMyPageResponse : ResponseBase
{
}

public class OtherClanInfoResponse : ResponseBase
{
    public OtherClanData clan;
    public int current_clan_battle_mode;
    public int current_battle_joined;
}

public class PctFinishResponse : ResponseBase
{
    public PctBonusInfo[] bonus_list;
    public int final_pct_point;
    public int after_pct_point;
    public PctUnitPointInfo after_pct_unit_point;
    public int add_present_count;
}

public class PctStartResponse : ResponseBase
{
    public int seed;
    public int pct_play_id;
}

public class PctTopResponse : ResponseBase
{
    public int pct_point;
    public PctUnitPointInfo[] unit_pct_point_list;
    public PctCacaoInfo[] cacao_list;
}

public class PictureBookResponse : ResponseBase
{
    public InventoryInfoShort[] item_list;
    public InventoryInfoShort[] user_equip;
}

public class PkbFinishSoloResponse : ResponseBase
{
    public int current_score;
    public int total_score;
    public InventoryInfo[] special_reward_list;
    public int add_present_count;
}

public class PkbFinishVsResponse : ResponseBase
{
    public int current_score;
    public int total_score;
    public InventoryInfo[] special_reward_list;
    public int add_present_count;
}

public class PkbReadCatalogResponse : ResponseBase
{
}

public class PkbReadRankingResponse : ResponseBase
{
}

public class PkbStartSoloResponse : ResponseBase
{
    public int play_id;
    public int seed;
}

public class PkbStartVsResponse : ResponseBase
{
    public int play_id;
    public int seed;
}

public class PkbTopResponse : ResponseBase
{
    public int total_score;
    public int total_score_solo;
    public int total_score_vs;
    public PkbHighScoreInfo solo_high_score_info;
    public PkbHighScoreInfo vs_high_score_info;
    public PkbHighScoreInfo simple_solo_high_score_info;
    public PkbHighScoreInfo simple_vs_high_score_info;
    public PkbCatalogInfo catalog_info;
    public PkbRankingInfo ranking_info;
    public PkbRankingInfo simple_ranking_info;
}

public class PresentHistoryResponse : ResponseBase
{
    public PresentHistoryInfo[] present_history;
}

public class PresentIndexResponse : ResponseBase
{
    public PresentParameter[] present_info_list;
    public int present_count;
}

public class PresentReceiveAllResponse : ResponseBase
{
    public InventoryInfo[] rewards;
    public UserStaminaInfo stamina_info;
    public int flag_over_limit;
    public int flag_expiration;
    public PresentParameter[] present_info_list;
    public ArenaCountInfo arena_count_info;
    public GrandArenaCountInfo grand_arena_count_info;
}

public class PresentReceiveSingleResponse : ResponseBase
{
    public InventoryInfo[] rewards;
    public UserStaminaInfo stamina_info;
    public int flag_over_limit;
    public int flag_expiration;
    public ArenaCountInfo arena_count_info;
    public GrandArenaCountInfo grand_arena_count_info;
}

public class ProfileFavoriteUnitResponse : ResponseBase
{
}

public class ProfileGetResponse : ResponseBase
{
    public ProfileUserInfo user_info;
    public ProfileQuestInfo quest_info;
    public UnitDataForView favorite_unit;
    public string clan_name;
    public int own_clan_role;
    public int clan_invite_result_code;
    public long invite_enable_time;
    public SupportUnitForProfile[] friend_support_units;
    public SupportUnitForProfile[] clan_support_units;
    public CampaignTarget[] campaign_target_list;
}

public class ProfileMakerGetClanProfileResponse : ResponseBase
{
    public ClanProfileCardSetting profile;
    public ClanProfileCardClanInfo clan;
}

public class ProfileMakerGetMyProfileResponse : ResponseBase
{
    public MyProfileCardSetting profile;
    public MyProfileCardScore score;
}

public class ProfileMakerSetClanProfileResponse : ResponseBase
{
}

public class ProfileMakerSetMyProfileResponse : ResponseBase
{
}

public class ProfileRenameResponse : ResponseBase
{
}

public class ProfileSetBirthDayResponse : ResponseBase
{
    public int birthday;
    public int birthday_period;
}

public class ProfileUpdateCommentResponse : ResponseBase
{
}

public class QuestFinishResponse : ResponseBase
{
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public InventoryInfo[] reward_list;
    public bool flag_exchange_team_exp;
    public int[] unlock_quest_list;
    public int unlock_dungeon_area_id;
    public LimitedShop[] limited_shop_list;
    public DailyShop daily_shop;
    public UserStory[] open_story_ids;
    public int quest_id;
    public int clear_flag;
    public int result_type;
    public int daily_clear_count;
    public int add_present_count;
    public ReleaseContentData[] release_contents;
    public ClanPoint clan_point;
    public eExchangeStaminaState state_exchange_stamina;
    public UserGold user_gold;
}

public class QuestRecoverChallengeMultipleResponse : ResponseBase
{
    public UserJewel user_jewel;
    public QuestRecoverInfo[] user_quest;
}

public class QuestRecoverChallengeResponse : ResponseBase
{
    public UserJewel user_jewel;
    public QuestRecoverInfo user_quest;
}

public class QuestReplayListResponse : ResponseBase
{
    public QuestReplayData[] replay_list;
}

public class QuestReplayResponse : ResponseBase
{
    public UnitData[] user_unit_list;
    public WaveEnemyInfoList[] quest_wave_info;
    public UnitData[] enemy_list;
}

public class QuestReplayReportResponse : ResponseBase
{
}

public class QuestRetireResponse : ResponseBase
{
}

public class QuestSkipMultipleResponse : ResponseBase
{
    public QuestResultList[] quest_result_list;
    public InventoryInfo[] bonus_reward_list;
    public LevelInfo level_info;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
    public InventoryInfo[] item_list;
    public UserStaminaInfo user_info;
    public int daily_clear_count;
    public int daily_challenge_count;
    public LimitedShop[] limited_shop_list;
    public DailyShop daily_shop;
    public bool flag_exchange_team_exp;
    public int add_present_count;
    public ClanPoint clan_point;
    public eExchangeStaminaState state_exchange_stamina;
}

public class QuestSkipResponse : ResponseBase
{
    public QuestResult[] quest_result_list;
    public InventoryInfo[] bonus_reward_list;
    public LevelInfo level_info;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
    public InventoryInfo[] item_list;
    public UserStaminaInfo user_info;
    public int daily_clear_count;
    public int daily_challenge_count;
    public LimitedShop[] limited_shop_list;
    public DailyShop daily_shop;
    public bool flag_exchange_team_exp;
    public int add_present_count;
    public ClanPoint clan_point;
    public eExchangeStaminaState state_exchange_stamina;
}

public class QuestStartResponse : ResponseBase
{
    public WaveEnemyInfoList[] quest_wave_info;
    public int limit_time;
    public int quest_id;
    public UnitData[] enemy_list;
    public UserStaminaInfo user_info;
    public int battle_log_id;
    public int seed;
    public SkinDataForRequest[] skin_data_for_request;
    public UserGold user_gold;
    public int support_position;
    public InventoryInfo[] sub_drop;
}

public class RaceLoginBonusCharaSelectDataResponse : ResponseBase
{
    public InventoryInfo[] reward_list;
    public int add_present_count;
}

public class RaritySixQuestFinishResponse : ResponseBase
{
    public int quest_id;
    public int clear_flag;
    public int result_type;
    public int add_present_count;
}

public class RaritySixQuestStartResponse : ResponseBase
{
    public int limit_time;
    public int quest_id;
    public UnitData[] enemy_list;
    public int battle_log_id;
    public int seed;
    public SkinDataForRequest[] skin_data_for_request;
}

public class RoomClanMemberResponse : ResponseBase
{
    public RoomUserInfo[] clan_members;
}

public class RoomExtendStorageResponse : ResponseBase
{
    public int max_storage_num;
    public UserJewel user_jewel;
}

public class RoomFreeGiftResponse : ResponseBase
{
    public LevelInfo level_info;
}

public class RoomGiveGiftResponse : ResponseBase
{
    public LevelInfo level_info;
    public InventoryInfo[] user_gift_item_list;
}

public class RoomItemBuyResponse : ResponseBase
{
    public RoomUserItem[] user_room_item_list;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class RoomItemSellResponse : ResponseBase
{
    public RoomUserItem[] user_room_item_list;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
    public int add_present_count;
}

public class RoomLevelUpEndResponse : ResponseBase
{
    public RoomUserItem user_room_item;
    public MaxExecNumList max_exec_num_list;
}

public class RoomLevelUpShorteningResponse : ResponseBase
{
    public RoomUserItem user_room_item;
    public UserJewel user_jewel;
    public MaxExecNumList max_exec_num_list;
}

public class RoomLevelUpStartResponse : ResponseBase
{
    public RoomUserItem user_room_item;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class RoomLevelUpStopResponse : ResponseBase
{
    public RoomUserItem user_room_item;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
    public int add_present_count;
}

public class RoomLikeHistoryResponse : ResponseBase
{
    public int total_like;
    public int total_be_liked;
    public int today_like_count;
    public int today_be_liked_count;
    public RoomUserInfo[] like_history;
    public int unread_count;
    public RoomUserInfo[] be_liked_history;
    public InventoryInfo[] reward_list;
}

public class RoomLikeResponse : ResponseBase
{
    public int total_like;
    public int daily_like;
    public RoomUserInfo[] like_history;
    public InventoryInfo[] reward_list;
    public RoomUserInfo room_user_info;
}

public class RoomMultiGiveGiftResponse : ResponseBase
{
    public LevelInfo level_info;
    public InventoryInfo[] user_gift_item_list;
}

public class RoomMultiLevelUpEndResponse : ResponseBase
{
    public RoomUserItem[] user_room_item_list;
}

public class RoomMysetDeleteResponse : ResponseBase
{
}

public class RoomMysetListResponse : ResponseBase
{
    public RoomMysetElement[] myset_list;
}

public class RoomMysetRenameResponse : ResponseBase
{
}

public class RoomMysetSaveResponse : ResponseBase
{
    public string myset_update_time;
}

public class RoomReceiveItemAllResponse : ResponseBase
{
    public RoomUserItem[] user_room_item_list;
    public InventoryInfo[] reward_list;
    public UserStaminaInfo stamina_info;
    public int add_present_count;
}

public class RoomReceiveItemResponse : ResponseBase
{
    public RoomUserItem user_room_item;
    public InventoryInfo[] reward_list;
    public UserStaminaInfo stamina_info;
    public int add_present_count;
}

public class RoomStartResponse : ResponseBase
{
    public RoomWholeLayout room_layout;
    public int max_storage_num;
    public int unread_count;
    public RoomUserItem[] user_room_item_list;
    public RoomItemGetTime[] event_room_item_get_time_list;
}

public class RoomUpdateResponse : ResponseBase
{
    public RoomUserItem[] user_room_item_list;
}

public class RoomVisitResponse : ResponseBase
{
    public RoomWholeLayout room_layout;
    public RoomUserItem[] user_room_item_list;
    public RoomUserInfo room_user_info;
    public DeckListDataForView[] deck_list;
    public int unread_count;
    public RoomExtensionItem extension_key;
}

public class SeasonPassBuyLevelResponse : ResponseBase
{
    public UserJewel user_jewel;
    public int seasonpass_level;
    public int user_point;
    public int point_limit_flag;
    public ExchangeRewards[] exchange_rewards;
}

public class SeasonPassIndexResponse : ResponseBase
{
    public int is_buy;
    public int seasonpass_level;
    public int user_point;
    public int weekly_point;
    public UserMissionInfo[] missions;
    public int[] received_rewards;
    public long daily_reset_time;
    public long weekly_reset_time;
}

public class SeasonPassMissionAcceptResponse : ResponseBase
{
    public int seasonpass_level;
    public int user_point;
    public int weekly_point;
    public int point_limit_flag;
    public ExchangeRewards[] exchange_rewards;
    public InventoryInfo[] rewards;
    public int add_present_count;
    public ReleaseContentData[] release_contents;
    public int[] room_item_level_mission;
}

public class SeasonPassRewardAcceptResponse : ResponseBase
{
    public UserStaminaInfo stamina_info;
    public InventoryInfo[] rewards;
    public int add_present_count;
    public int[] received_rewards;
}

public class SekaiBossInfoResponse : ResponseBase
{
    public DamageHistory damage_history;
    public long current_hp;
}

public class SekaiFinishResponse : ResponseBase
{
}

public class SekaiHistoryReportResponse : ResponseBase
{
    public HistoryReport[] history_report;
}

public class SekaiRankingInClanResponse : ResponseBase
{
    public int sekai_id;
    public int my_rank;
    public long my_damage;
    public SekaiRanking[] ranking;
}

public class SekaiRankingResponse : ResponseBase
{
    public int sekai_id;
    public int my_rank;
    public long my_damage;
    public SekaiRanking[] ranking;
}

public class SekaiRetireResponse : ResponseBase
{
    public int sekai_id;
    public int my_rank;
    public long my_damage;
    public SekaiRanking[] ranking;
}

public class SekaiStartResponse : ResponseBase
{
    public UnitData enemy_data;
    public int battle_log_id;
    public long current_hp;
    public UnitData[] user_unit;
    public int seed;
}

public class SekaiSupportUnitList2Response : ResponseBase
{
    public ClanBattleSupportUnitLight[] support_unit_list;
}

public class SekaiTopResponse : ResponseBase
{
    public int sekai_id;
    public long current_hp;
    public DamageHistory[] damage_history;
    public int rank;
    public int remaining_count;
}

public class SellItemResponse : ResponseBase
{
    public InventoryInfo[] item_list;
    public InventoryInfo[] material_list;
    public InventoryInfo[] user_equip;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
    public int add_present_count;
}

public class SendBattleLogCsvResponse : ResponseBase
{
}

public class SerialCodeRegisterResponse : ResponseBase
{
    public InventoryInfo[] reward_list;
    public int serial_campaign_id;
    public InventoryInfo[] group_reward_list;
    public int serial_group_id;
    public int add_present_count;
}

public class SetMyPartyResponse : ResponseBase
{
}

public class SetMyPartyTabResponse : ResponseBase
{
}

public class ShioriBossBattleFinishResponse : ResponseBase
{
    public LevelInfo level_info;
    public int result_type;
    public int[] unlock_quest_list;
    public HatsuneEventBossStatus[] unlock_bosses;
    public int unlock_story_id;
    public int[] unlock_story_id_list;
    public InventoryInfo[] quest_rewards;
    public InventoryInfo[] first_clear_rewards;
    public int acquired_gold;
    public UserGold user_gold;
    public int damage_result;
    public int add_present_count;
    public bool upper_limit_flag;
    public InventoryInfo[] treasure_rewards;
    public HatsuneEventBossStatus next_boss;
    public InventoryInfo[] item_list;
    public UnitData unlock_unit;
    public int[] event_present_list;
    public int[] new_dear_story_id_list;
    public int[] release_diary_ids;
    public int[] new_omp_story_ids;
}

public class ShioriBossBattleRetireResponse : ResponseBase
{
}

public class ShioriBossBattleStartResponse : ResponseBase
{
    public UnitData boss_unit_data;
    public int limit_time;
    public int[] hit_treasure_nums;
    public int battle_log_id;
    public int seed;
}

public class ShioriDearFinishResponse : ResponseBase
{
    public DearPointInfo before_dear_point_info;
    public DearPointInfo after_dear_point_info;
    public int add_present_count;
}

public class ShioriDearTopResponse : ResponseBase
{
    public DearStoryInfo[] unlock_dear_story_info_list;
    public DearPointInfo[] dear_point_info_list;
}

public class ShioriEventTopResponse : ResponseBase
{
    public HatsuneEventBossStatus[] bosses;
    public DeckData[] event_decks;
    public int login_count;
    public UserMissionInfo[] missions;
    public UserQuestInfo[] quest_list;
    public EventQuizInfo[] quiz;
    public int[] unchoiced_dear_story_id_list;
    public int[] release_diary_ids;
    public HatsuneSeriesInfo[] series_info_list;
}

public class ShioriFavoriteResponse : ResponseBase
{
}

public class ShioriMissionAcceptResponse : ResponseBase
{
    public int team_level;
    public int team_exp;
    public UserStaminaInfo stamina_info;
    public InventoryInfo[] rewards;
    public bool flag_exchange_team_exp;
    public int add_present_count;
    public ReleaseContentData[] release_contents;
}

public class ShioriMissionIndexResponse : ResponseBase
{
    public UserMissionInfo[] missions;
    public UserSeasonPackInfo[] season_pack;
    public long daily_reset_time;
}

public class ShioriQuestFinishResponse : ResponseBase
{
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public InventoryInfo[] reward_list;
    public bool flag_exchange_team_exp;
    public int[] unlock_quest_list;
    public HatsuneEventBossStatus[] unlock_bosses;
    public int unlock_story_id;
    public int quest_id;
    public int clear_flag;
    public int result_type;
    public int add_present_count;
    public bool upper_limit_flag;
    public int daily_clear_count;
    public LimitedShop[] limited_shop_list;
    public DailyShop daily_shop;
    public int has_drop;
    public ClanPoint clan_point;
    public InventoryInfo[] drop_rewards;
    public int[] event_present_list;
    public int[] unlock_quiz;
    public eExchangeStaminaState state_exchange_stamina;
    public int[] release_diary_ids;
    public int[] new_relay_story_ids;
    public int[] new_omp_story_ids;
    public UserGold user_gold;
}

public class ShioriQuestRetireResponse : ResponseBase
{
}

public class ShioriQuestSkipResponse : ResponseBase
{
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public bool flag_exchange_team_exp;
    public QuestResult[] quest_result_list;
    public InventoryInfo[] bonus_reward_list;
    public UserGold user_gold;
    public int add_present_count;
    public bool upper_limit_flag;
    public InventoryInfo[] item_list;
    public int daily_clear_count;
    public LimitedShop[] limited_shop_list;
    public DailyShop daily_shop;
    public ClanPoint clan_point;
    public eExchangeStaminaState state_exchange_stamina;
    public int[] release_diary_ids;
}

public class ShioriQuestStartResponse : ResponseBase
{
    public WaveEnemyInfoList[] quest_wave_info;
    public UserStaminaInfo user_info;
    public int quest_id;
    public int battle_log_id;
    public int seed;
    public UserGold user_gold;
    public int support_position;
}

public class ShioriQuizAnswerResponse : ResponseBase
{
    public int is_correct;
    public int[] unlock_quest_list;
    public int[] unlock_quiz;
    public int add_present_count;
}

public class ShioriTopResponse : ResponseBase
{
    public int[] new_event_list;
    public int[] clear_event_list;
    public int[] my_select_list;
}

public class ShopAlchemyResponse : ResponseBase
{
    public int team_level;
    public int[] gold;
    public AlchemyReward[] alchemy_reward_list;
    public int paid_jewel;
    public int free_jewel;
    public int paid_gold;
    public int free_gold;
    public Alchemy alchemy;
    public UserJewel user_jewel;
    public UserGold user_gold;
    public long alchemy_reward_time;
}

public class ShopBuyMultipleResponse : ResponseBase
{
    public InventoryInfo[] purchase_list;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
}

public class ShopBuyResponse : ResponseBase
{
    public InventoryInfo[] purchase_list;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
    public UserJewel user_jewel;
}

public class ShopCloseDailyShopResponse : ResponseBase
{
}

public class ShopCloseLimitedShopResponse : ResponseBase
{
}

public class ShopComebackTutorialDailyShopResponse : ResponseBase
{
    public DailyShop daily_shop;
}

public class ShopItemListResponse : ResponseBase
{
    public ShopInfo[] shop_list;
    public int is_got_csc;
}

public class ShopRecoverStaminaResponse : ResponseBase
{
    public RecoverStamina recover_stamina;
    public UserJewel user_jewel;
    public UserStaminaInfo user_info;
}

public class ShopResetResponse : ResponseBase
{
    public ShopInfo shop;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
    public UserJewel user_jewel;
}

public class SkillLevelUpResponse : ResponseBase
{
    public UnitData unit_data;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class SkillRemoveFreeResponse : ResponseBase
{
    public UnitData unit_data;
}

public class SkillSetFreeResponse : ResponseBase
{
    public UnitData unit_data;
}

public class SpaceFinishResponse : ResponseBase
{
    public int damage_result;
    public InventoryInfo[] rewards;
    public UserGold user_gold;
    public int add_present_count;
}

public class SpaceRetireResponse : ResponseBase
{
}

public class SpaceStartResponse : ResponseBase
{
    public UnitData boss_unit_data;
    public long limit_time;
    public int battle_log_id;
    public int seed;
}

public class SpaceStoryCheckResponse : ResponseBase
{
}

public class SpaceStoryStartResponse : ResponseBase
{
}

public class SpaceSupportUnitList2Response : ResponseBase
{
    public ClanBattleSupportUnitLight[] support_unit_list;
}

public class SpaceTopResponse : ResponseBase
{
    public int space_id;
    public int progress;
    public int space_battle_id;
    public int boss_hp;
}

public class SrtFinishResponse : ResponseBase
{
    public int turn_num_bonus;
    public int answer_time_bonus;
    public int wrong_num_bonus;
    public int current_score;
    public int total_score_all;
    public InventoryInfo[] special_reward_list;
    public int add_present_count;
}

public class SrtReadCatalogResponse : ResponseBase
{
}

public class SrtStartResponse : ResponseBase
{
    public int play_id;
    public int seed;
    public int answer_limit_time;
}

public class SrtTopResponse : ResponseBase
{
    public int total_score_all;
    public SrtHighScoreInfo high_score_info;
    public SrtCatalogInfo[] catalog_info;
}

public class StoryForceReleaseResponse : ResponseBase
{
}

public class StoryMaintenanceCheckResponse : ResponseBase
{
}

public class StoryQuestStartResponse : ResponseBase
{
    public WaveEnemyInfoList[] quest_wave_info;
    public int limit_time;
    public int quest_id;
    public UnitData[] enemy_list;
    public UserStaminaInfo user_info;
    public UnitData[] guest_data;
}

public class StoryViewingResponse : ResponseBase
{
    public InventoryInfo[] reward_info;
    public ReleaseContentData[] release_contents;
    public int add_present_count;
    public int[] unlock_story_ids;
    public int event_id;
    public int[] unlocked_sub_story_list;
}

public class SubStoryLtoReadStoryResponse : ResponseBase
{
    public InventoryInfo[] reward_info;
}

public class SubStorySkeConfirmResponse : ResponseBase
{
}

public class SubStorySkeReadStoryResponse : ResponseBase
{
    public EventSubStoryInfo new_sub_story_info;
}

public class SubStorySspReadSspStoryResponse : ResponseBase
{
}

public class SupportUnitChangeSettingResponse : ResponseBase
{
    public SupportUnitSetting support_units;
    public InventoryInfo[] support_time_bonus;
    public InventoryInfo[] support_count_bonus;
    public int add_present_count;
}

public class SupportUnitGetSettingResponse : ResponseBase
{
    public SupportUnitSetting[] friend_support_units;
    public SupportUnitSetting[] clan_support_units;
    public int clan_support_available_status;
}

public class TestBuyTicketResponse : ResponseBase
{
    public int ticket_status;
}

public class TowerBattleFinishResponse : ResponseBase
{
    public int quest_id;
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public UserGold user_gold;
    public bool flag_exchange_team_exp;
    public InventoryInfo[] reward_list;
    public int add_present_count;
    public ClanPoint clan_point;
    public TowerClanMemberInfo[] clan_member_info;
    public int is_joined_clan;
}

public class TowerBattleRetireResponse : ResponseBase
{
    public TowerClanMemberInfo[] clan_member_info;
    public int is_joined_clan;
}

public class TowerBattleSkipResponse : ResponseBase
{
    public UserGold user_gold;
    public int add_present_count;
}

public class TowerBattleStartResponse : ResponseBase
{
    public UnitData[] user_unit;
    public UnitData[] versus_user_unit;
    public UserStaminaInfo user_info;
    public UserGold user_gold;
    public int battle_log_id;
    public int seed;
    public int support_unit_hp;
}

public class TowerCloisterBattleFinishResponse : ResponseBase
{
    public int quest_id;
    public UserGold user_gold;
    public int add_present_count;
    public TowerClanMemberInfo[] clan_member_info;
    public int cloister_remain_clear_count;
    public int is_joined_clan;
}

public class TowerCloisterBattleRetireResponse : ResponseBase
{
    public TowerClanMemberInfo[] clan_member_info;
    public int is_joined_clan;
}

public class TowerCloisterBattleStartResponse : ResponseBase
{
    public UnitData[] user_unit;
    public UnitData[] versus_user_unit1;
    public UnitData[] versus_user_unit2;
    public UnitData[] versus_user_unit3;
    public UserGold user_gold;
    public int battle_log_id;
    public int seed;
    public InventoryInfo[] reward_list;
    public int support_unit_hp;
}

public class TowerExBattleFinishResponse : ResponseBase
{
    public int quest_id;
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public UserGold user_gold;
    public bool flag_exchange_team_exp;
    public int add_present_count;
    public ClanPoint clan_point;
    public TowerClanMemberInfo[] clan_member_info;
    public int is_joined_clan;
}

public class TowerExBattleRetireResponse : ResponseBase
{
}

public class TowerExBattleStartResponse : ResponseBase
{
    public int[] battle_log_ids;
    public int[] seed_list;
    public TowerExPartyInfo user_party_list;
    public UnitData[] versus_user_unit;
    public UserStaminaInfo user_info;
    public UserGold user_gold;
}

public class TowerExSupportUnitList2Response : ResponseBase
{
    public TowerExDispatchUnitLight[] support_unit_list;
}

public class TowerExSupportUnitListResponse : ResponseBase
{
    public TowerExDispatchUnit[] support_unit_list;
}

public class TowerRehearsalFinishResponse : ResponseBase
{
    public TowerClanMemberInfo[] clan_member_info;
    public int is_joined_clan;
}

public class TowerRehearsalRetireResponse : ResponseBase
{
    public TowerClanMemberInfo[] clan_member_info;
    public int is_joined_clan;
}

public class TowerRehearsalStartResponse : ResponseBase
{
    public UnitData[] user_unit;
    public UnitData[] versus_user_unit;
    public int battle_log_id;
    public int seed;
    public int support_unit_hp;
}

public class TowerReplayListResponse : ResponseBase
{
    public TowerReplaySummary[] replay_list;
}

public class TowerReplayResponse : ResponseBase
{
    public int[] seed_list;
    public TowerReplayPartyStatusList party_status_list;
    public TowerReplayPartyList party_list;
    public UnitData[] versus_user_unit;
}

public class TowerReplayReportResponse : ResponseBase
{
}

public class TowerResetResponse : ResponseBase
{
    public int remain_reset_count;
}

public class TowerSupportUnitList2Response : ResponseBase
{
    public ClanDispatchUnitLight[] support_unit_list;
}

public class TowerSupportUnitListResponse : ResponseBase
{
    public ClanDispatchUnit[] support_unit_list;
}

public class TowerTopResponse : ResponseBase
{
    public int next_quest_id;
    public TowerUnit[] user_unit;
    public TowerUnit[] versus_user_unit;
    public TowerClanMemberInfo[] clan_member_info;
    public int remain_reset_count;
    public int[] cleared_ex_quest_ids;
    public int is_joined_clan;
    public int last_login_schedule_id;
    public int wave;
    public int cloister_remain_clear_count;
    public int cloister_first_cleared_flag;
}

public class TrainingQuestFinishResponse : ResponseBase
{
    public LevelInfo level_info;
    public int quest_id;
    public int clear_flag;
    public int result_type;
    public TrainingQuestCount quest_challenge_count;
    public InventoryInfo[] rewards;
    public int add_present_count;
    public UserStaminaInfo user_info;
    public UserGold user_gold;
}

public class TrainingQuestRetireResponse : ResponseBase
{
}

public class TrainingQuestSkipResponse : ResponseBase
{
    public QuestResult[] quest_result_list;
    public InventoryInfo[] bonus_reward_list;
    public LevelInfo level_info;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
    public InventoryInfo[] item_list;
    public UserStaminaInfo user_info;
    public int daily_clear_count;
    public TrainingQuestCount quest_challenge_count;
    public int add_present_count;
}

public class TrainingQuestStartResponse : ResponseBase
{
    public WaveEnemyInfoList[] quest_wave_info;
    public int limit_time;
    public int quest_id;
    public UnitData[] enemy_list;
    public UserStaminaInfo user_info;
    public int battle_log_id;
    public SkinDataForRequest[] skin_data_for_request;
    public int seed;
    public UserGold user_gold;
    public int support_position;
}

public class TtkChooseWeaponResponse : ResponseBase
{
}

public class TtkFinishResponse : ResponseBase
{
    public int life_num_bonus;
    public int coin_num_bonus;
    public int current_score;
    public int total_score_all;
    public InventoryInfo[] special_reward_list;
    public int add_present_count;
}

public class TtkReadCatalogResponse : ResponseBase
{
}

public class TtkReadStoryResponse : ResponseBase
{
}

public class TtkStartResponse : ResponseBase
{
    public int play_id;
    public int seed;
}

public class TtkTopResponse : ResponseBase
{
    public int total_score_all;
    public TtkHighScoreInfo high_score_info;
    public int total_coin;
    public int weapon_in_equipment;
    public int[] unlocked_ttk_story_ids;
    public int[] read_ttk_story_ids;
    public TtkCatalogInfo[] catalog_info;
    public int condition_emblem_coin;
}

public class TutorialUpdateResponse : ResponseBase
{
    public int step;
    public InventoryInfo[] reward_info_list;
    public DeckData[] deck_list;
    public UserStaminaInfo stamina_info;
    public PrologueFirstStep prologue_first;
    public PrologueLatterDStep prologue_latter_d;
    public QuestOneStep quest_one;
    public EquipStep equip;
    public GachaStep gacha;
    public QuestTwoStep quest_two;
    public MissionStep mission;
}

public class UekBossBattleFinishResponse : ResponseBase
{
    public int result_type;
    public int damage_result;
    public InventoryInfo[] treasure_rewards;
}

public class UekBossBattleRetireResponse : ResponseBase
{
}

public class UekBossBattleStartResponse : ResponseBase
{
    public int battle_log_id;
    public int seed;
}

public class UekTopResponse : ResponseBase
{
    public int current_area;
    public UserMissionInfo[] missions;
    public UekBossInfo boss_info;
    public InventoryInfo[] rewards;
    public int add_present_count;
    public bool upper_limit_flag;
    public int[] unlocked_uek_story_ids;
}

public class UniqueEquipCraftResponse : ResponseBase
{
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_list;
    public UserGold user_gold;
}

public class UniqueEquipEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
    public UserGold user_gold;
    public InventoryInfo[] item_list;
}

public class UniqueEquipMultiEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
    public UserGold user_gold;
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_list;
}

public class UniqueEquipRankupResponse : ResponseBase
{
    public UnitData unit_data;
    public UserGold user_gold;
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_list;
}

public class UnitCraftEquipResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
}

public class UnitCraftEquipUniqueResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_data;
    public UserGold user_gold;
}

public class UnitEquipResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo equip_data;
}

public class UnitEvolutionRaritySixResponse : ResponseBase
{
    public UnitData unit_data;
}

public class UnitEvolutionResponse : ResponseBase
{
    public UnitData[] unit_data_list;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class UnitFavoriteResponse : ResponseBase
{
}

public class UnitFreeAutomaticEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] equip_list;
}

public class UnitFreeEquipResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] equip_list;
}

public class UnitFreeEvolutionResponse : ResponseBase
{
    public UnitData unit_data;
}

public class UnitFreeLevelUpResponse : ResponseBase
{
    public UnitData unit_data;
}

public class UnitFreeMultiEvolutionResponse : ResponseBase
{
    public UnitData unit_data;
}

public class UnitFreePromotionResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] refund_items;
    public int add_present_count;
    public InventoryInfo[] equip_list;
}

public class UnitGrowthEnhanceResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] refund_items;
    public int add_present_count;
    public InventoryInfo[] equip_list;
}

public class UnitMultiEquipResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] equip_list;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class UnitMultiEvolutionResponse : ResponseBase
{
    public UnitData[] unit_data_list;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class UnitMultiPromotionResponse : ResponseBase
{
    public InventoryInfo[] equip_list;
    public InventoryInfo[] item_data;
    public InventoryInfo[] refund_items;
    public UnitData unit_data;
    public UserGold user_gold;
    public int add_present_count;
}

public class UnitPromotionResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] refund_items;
    public int add_present_count;
}

public class UnitSetGrowthItemResponse : ResponseBase
{
    public InventoryInfo[] item_data;
    public GrowthInfo growth_unit_info;
}

public class UnitUniqueEquipResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo equip_data;
}

public class UnlockRaritySixSlotResponse : ResponseBase
{
    public UnitData unit_data;
    public UserGold user_gold;
    public InventoryInfo[] item_data;
}

public class UnlockUnitResponse : ResponseBase
{
    public UnitData unit_data;
    public InventoryInfo[] item_data;
}

public class UpdateSkipQuestListResponse : ResponseBase
{
}

public class UpdateTabResponse : ResponseBase
{
}

public class UseExpItemResponse : ResponseBase
{
    public InventoryInfo[] item_data;
    public UnitData unit_data;
}

public class UserInviteClanListResponse : ResponseBase
{
    public InviteClanDetail[] list;
}

public class VoteExecResponse : ResponseBase
{
}

public class VoteTopResponse : ResponseBase
{
    public VotedUnit voted_unit;
    public VoteRanking ranking;
}


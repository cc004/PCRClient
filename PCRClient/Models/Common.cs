namespace PCRClient.Models;
// ReSharper disable InconsistentNaming
#pragma warning disable CS8618

public class AgreementStatus
{
    public int ver;
    public int state;
}

public class Alchemy
{
    public int max_count;
    public int exec_count;
}

public class AlchemyReward
{
    public InventoryInfo[] reward_info_list;
}

public class ArenaCountInfo
{
    public int battle_number;
}

public class ArenaInfo
{
    public float max_battle_number;
    public int battle_number;
    public long interval_end_time;
    public int yesterday_defend_number;
    public int highest_rank;
    public int season_highest_rank;
    public int rank;
    public int group;
    public int group_moving_release_time;
}

public class ArenaSetting
{
    public int time_reset_cost;
    public int count_reset_cost;
}

public class ArenaWaveInfo
{
    public UnitData[] user_arena_deck;
    public UnitData[] vs_user_arena_deck;
    public int seed;
    public int battle_log_id;
    public int wave_num;
}

public class ArenaWaveResult
{
    public UnitDamageInfo[] unit_damage_list;
    public UnitHpInfo[] unit_hp_list;
    public int wave_num;
    public int remain_time;
}

public class BattleLogData
{
    public int battle_log_type;
    public int type;
    public int target_unit_id;
    public int target_is_own_unit;
    public int source_unit_id;
    public int source_is_own_unit;
    public int action_id;
    public int frame;
    public long value1;
    public int value2;
    public int value3;
    public int duration;
    public long current_value;
    public int wave_count;
}

public class BattleLogType
{
    public int miss;
    public int set_damage;
    public int set_abnormal;
    public int set_recovery;
    public int set_buff_debuff;
    public int set_state;
    public int button_tap;
    public int set_energy;
    public int damage_charge;
    public int give_value_additional;
    public int give_value_multiply;
    public int wave_end_hp;
    public int wave_end_damage_amount;
    public int @break;
}

public class BlockUserDetail
{
    public int block_id;
    public string clan_name;
    public int team_level;
    public string owner_name;
    public UnitDataForView favorite_unit;
    public long owner_last_login_time;
}

public class BossBattleFinishUnit
{
    public UnitDamageInfo[] unit_damage_list;
    public UnitHpInfo[] unit_hp_list;
}

public class BossHistory
{
    public int id;
    public int difficulty;
    public int lap_num;
    public int order_num;
    public long clear_time;
    public int attack_count;
}

public class BossInfo
{
    public int order_num;
    public int enemy_id;
    public int max_hp;
    public int current_hp;
}

public class BossRank
{
    public int enemy_id;
    public int rank;
}

public class BossRankingInClan
{
    public int order_num;
    public int latest_phase_num;
    public BossRankingInClanPhase[] phases;
}

public class BossRankingInClanPhase
{
    public int phase_num;
    public int enemy_id;
    public int my_rank_pos;
    public MemberScoreRanking[] ranking;
}

public class BossRankingInClanSummary
{
    public int latest_phase_num;
    public BossRankingInClanSummaryPhase[] phases;
}

public class BossRankingInClanSummaryPhase
{
    public int phase_num;
    public int my_member_pos;
    public MemberBossRanks[] members;
}

public class BossReward
{
    public int clan_battle_id;
    public int period;
    public int lap_num;
    public int id;
    public long kill_time;
    public InventoryInfo[] reward_info;
}

public class BulkSkipSetting
{
    public int default_skip_count;
    public int max_skip_count;
}

public class CampaignDate
{
    public string start_time;
    public string end_time;
}

public class CampaignGachaInfo
{
    public int campaign_id;
    public int fg1_exec_cnt;
    public int fg1_last_exec_time;
    public int fg10_exec_cnt;
    public int fg10_last_exec_time;
}

public class CampaignTarget
{
    public long viewer_id;
    public bool target_flag;
}

public class CartoonSetting
{
    public long open_time_sp;
    public long open_time_dmm;
}

public class ChangeRarityUnit
{
    public int unit_id;
    public int battle_rarity;
}

public class ChangeToMaterial
{
    public int key;
    public int val;
}

public class CharaExchangeTicketProductData
{
    public string csv_data_id;
    public int number_of_product_purchased;
    public long start_time;
    public long end_time;
}

public class CharaExchangeTicketReward
{
    public int unit_id;
    public int unit_rarity;
    public eInventoryType reward_type;
    public int reward_id;
    public int reward_count;
}

public class ChatMemberInfo
{
    public long viewer_id;
    public string name;
    public int level;
    public UnitDataForView favorite_unit;
    public EmblemData emblem;
}

public class ChatMessageInfo
{
    public long viewer_id;
    public int message_id;
    public eClanChatMessageType message_type;
    public string message;
    public long create_time;
    public eClanChatPlayButtonCondition disp_minigame_button;
}

public class ClanBattleData
{
    public int now_open;
    public int is_interval;
    public long next_open_time;
    public long mode_change_limit_time;
    public long mode_change_limit_start_time;
    public long mode_change_limit_remind_time;
    public int is_extra_battle_cleared;
}

public class ClanBattleExtraBattleChallengeRewardInfo
{
    public int challenge_count;
    public InventoryInfo[] reward_info;
}

public class ClanBattleFinishUnit
{
    public UnitDamageInfo[] unit_damage_list;
    public UnitHpInfo[] unit_hp_list;
}

public class ClanBattleSetting
{
    public int default_difficulty;
    public int default_challenge_count;
    public int clan_point_coefficient;
    public int support_rental_cost_coefficient;
    public int border_unit_level;
    public int grace_time;
    public int dispatch_count_bonus_limit;
    public int dispatch_time_bonus_limit;
    public int hp_recovery_time;
    public int can_use_hp_border;
    public int support_lv_band;
    public int monster_detail_reload_interval;
    public int mode_change_limit_hours;
    public int mode_change_limit_start_hours;
    public int mode_change_limit_remind_hours;
    public long party_copy_open_time;
}

public class ClanBattleSuggestDeck
{
    public int total_damage;
    public int level_id;
    public int party_type;
    public int battle_time;
    public int start_remain_time;
    public int win_or_lose;
    public string enc_key;
    public UnitDataForView[] deck;
}

public class ClanBattleSupportUnit
{
    public UnitData unit_data;
    public int current_support_unit;
    public long owner_viewer_id;
    public string owner_name;
    public int remaining_count;
}

public class ClanBattleSupportUnitLight
{
    public UnitDataLight unit_data;
    public int current_support_unit;
    public long owner_viewer_id;
    public string owner_name;
    public int remaining_count;
}

public class ClanBattleTopUserClanInformation
{
    public string clan_name;
    public int clan_role;
}

public class ClanData
{
    public ClanInfo detail;
    public ClanMemberInfo[] members;
}

public class ClanDetailMemberInfo
{
    public string user_name;
    public int team_level;
    public long last_login_time;
    public UnitDataForView favorite_unit;
}

public class ClanDispatchUnit
{
    public long owner_viewer_id;
    public string owner_name;
    public int enable;
    public int current_support_unit;
    public int hp;
    public int energy;
    public UnitData unit_data;
}

public class ClanDispatchUnitLight
{
    public int current_support_unit;
    public int enable;
    public int energy;
    public int hp;
    public string owner_name;
    public long owner_viewer_id;
    public UnitDataLight unit_data;
}

public class ClanInfo
{
    public int clan_id;
    public long leader_viewer_id;
    public string leader_name;
    public UnitDataForView leader_favorite_unit;
    public string clan_name;
    public string description;
    public eClanJoinCondition join_condition;
    public int member_num;
    public eClanActivityGuideline activity;
    public int grade_rank;
    public int current_period_ranking;
    public int clan_battle_mode;
}

public class ClanMemberInfo
{
    public long viewer_id;
    public string name;
    public EmblemData emblem;
    public eClanRole role;
    public int level;
    public UnitDataForView favorite_unit;
    public UnitDataForClanMember[] dispatch_units;
    public long last_login_time;
    public int total_power;
}

public class ClanPoint
{
    public int before_point;
    public int after_point;
    public int before_count;
    public int after_count;
    public int cost_group_id;
}

public class ClanProfileCardClanInfo
{
    public string clan_name;
    public int clan_battle_id;
    public int period;
    public int rank;
    public int grade_rank;
    public int level;
    public int member_num;
    public int join_condition;
    public int activity;
    public int last_clan_battle_mode;
    public int last_battle_joined;
}

public class ClanProfileCardDisplayStatus
{
    public bool level;
    public bool member;
}

public class ClanProfileCardSetting
{
    public int unit_id;
    public int skin;
    public int background;
    public int frame;
    public ClanProfileCardDisplayStatus disp_status;
    public string invite_comment;
    public string comment;
}

public class ClanSetting
{
    public int max_member_num;
    public int max_leader_num;
    public int max_sub_leader_num;
    public int dispatch_interval;
    public int chat_num_per_time;
    public int chat_max_num;
    public int chat_expire_sec;
    public int chat_polling_time;
    public int gold_unit_period;
    public int gold_base;
    public float gold_rate_power;
    public int gold_per_dispatch_count;
    public int rejoin_restriction_time;
    public int like_reward;
    public int daily_like_reward_limit;
    public int be_liked_reward;
    public int daily_be_liked_reward_limit;
    public int equipment_request_interval;
    public int search_clan_default_activity;
    public int search_clan_default_join_condition;
    public int search_clan_default_member_condition_range;
    public int notify_support_gold_border;
    public int clan_activity_max;
    public int rental_cost_fixed_border_team_lv;
    public int rental_cost_rate_per_team_lv;
    public int rental_cost_fixed;
}

public class ClearedExQuestList
{
    public int quest_id;
    public long ex_cleared_time;
}

public class ClearRewardInfo
{
    public int type;
    public InventoryInfo[] reward_info;
}

public class CounterStopCoinExchange
{
    public CounterStopCoinInfo weekly;
}

public class CounterStopCoinInfo
{
    public int count;
    public int max;
}

public class DailyShop
{
    public int system_id;
    public ShopItem[] item_list;
    public ShopItem[] add_item_list;
    public int remaining_appear_count;
    public int max_appear_num;
}

public class DamageHistory
{
    public long viewer_id;
    public int enemy_id;
    public string name;
    public int damage;
    public int kill;
    public long create_time;
    public int history_id;
    public int lap_num;
    public int order_num;
}

public class DamageReport
{
    public long viewer_id;
    public string name;
    public UnitDataForView favorite_unit;
    public int damage;
    public int rank;
    public EmblemData emblem;
}

public class DearPointInfo
{
    public int chara_index;
    public int dear_point;
}

public class DearStoryInfo
{
    public int story_id;
    public int is_choiced;
}

public class DeckData
{
    public ePartyType deck_number;
    public int unit_id1;
    public int unit_id2;
    public int unit_id3;
    public int unit_id4;
    public int unit_id5;
}

public class DeckListData
{
    public int deck_number;
    public int[] unit_list;
}

public class DeckListDataForView
{
    public int deck_number;
    public UnitDataForView[] deck_data_for_view;
}

public class DispatchUnitStatus
{
    public long owner_viewer_id;
    public int unit_id;
    public int hp;
}

public class DungeonArea
{
    public int dungeon_type;
    public int[] dungeon_area_ids;
}

public class DungeonBattleMission
{
    public int mission_id;
    public int condition_value;
    public bool is_complete;
}

public class DungeonBattleStartUnit
{
    public long owner_viewer_id;
    public int unit_id;
}

public class DungeonInfo
{
    public int enter_area_id;
    public RestChallengeInfo[] rest_challenge_count;
    public DungeonArea[] dungeon_area;
}

public class DungeonQueryUnit
{
    public long owner_viewer_id;
    public int unit_id;
    public int retired;
    public int hp;
    public int energy;
    public SkillLimitCounter[] skill_limit_counter;
    public PartsInfo[] parts_list;
}

public class DungeonQuest
{
    public int quest_id;
    public int limit_time;
    public int background;
    public int chest_id;
    public long versus_viewer_id;
    public string name;
    public DungeonUnit[] versus_unit_list;
}

public class DungeonSetting
{
    public int support_rental_cost_coefficient;
    public int border_unit_level;
    public int support_lv_band;
}

public class DungeonUnit
{
    public int unit_id;
    public int hp;
    public int energy;
    public SkillLimitCounter[] skill_limit_counter;
    public int max_hp;
    public int power;
    public int level;
    public int rarity;
    public int promotion_level;
    public SkinData skin_data;
    public int[] unique_equipped_list;
    public PartsInfo[] parts_list;
}

public class DuplicateUnitInfo
{
    public int unit_id;
    public int rarity;
    public int count;
}

public class EmblemData
{
    public int emblem_id;
    public int ex_value;
}

public class EnhanceRecipe
{
    public int id;
    public int type;
    public int count;
    public int current_count;
}

public class EquipDonate
{
    public int equip_id;
    public int num;
    public string name;
}

public class EquipDonateNotification
{
    public EquipDonate[] donation_list;
    public InventoryInfo[] equip_list;
    public EquipRequests request;
}

public class EquipRequests
{
    public int message_id;
    public int equip_id;
    public int request_num;
    public int donation_num;
    public int user_donation_num;
    public EquipDonate[] history;
    public int is_finish_checked;
    public long viewer_id;
}

public class EquipSlot
{
    public int id;
    public bool is_slot;
    public int enhancement_level;
    public int enhancement_pt;
    public int rank;
    public int status;
}

public class EquipSlotLight
{
    public bool is_slot;
    public int enhancement_pt;
    public int rank;
}

public class EquipStep
{
    public TutorialUnitEquip unit_equip1;
    public TutorialUnitEquip unit_equip2;
}

public class EquipStrSetting
{
    public int lower_rank;
    public StrCoinCost[] coin_cost;
    public StrJewelCost[] jewel_cost;
}

public class EventBoxGachaHitRewardInfo
{
    public int box_set_id;
    public int hit_reward_count;
}

public class EventBoxGachaSet
{
    public int box_set_id;
    public int step;
    public eInventoryType reward_type;
    public int reward_id;
    public int reward_count;
    public int inbox_count;
    public int remain_inbox_count;
    public int reset_target;
    public int disp_group;
    public string odds_file;
}

public class EventEnemyDamageInfo
{
    public int enemy_identify;
    public int total_damage;
}

public class EventEnemyInfo
{
    public EventSpecialEnemyUnit[] enemy_unit;
    public int enemy_point;
    public int seed;
    public int mode;
    public int[] kill_order;
}

public class EventGachaInfo
{
    public int gacha_step;
    public EventBoxGachaSet[] box_set_list;
}

public class EventHitTreasureInfo
{
    public int enemy_identify;
    public int[] hit_treasure_index_list;
}

public class EventQuizInfo
{
    public int quiz_id;
    public int is_correct;
}

public class EventSpecialBattleExHistory
{
    public int attack_num;
    public int total_power;
    public int damage;
    public int mode;
    public ReplayUnitDataForView[] unit_data;
    public int manual_flags;
}

public class EventSpecialBattleExRankingInfo
{
    public int rank;
    public int appear_num;
    public int total_attack_num;
    public int total_attack_num_mode1;
    public int total_attack_num_mode2;
    public int total_attack_num_mode3;
    public int @new;
}

public class EventSpecialEnemyUnit
{
    public int unit_id;
    public int hp;
    public int order;
}

public class EventStatus
{
    public int event_type;
    public int event_id;
    public int period;
}

public class EventSubStory
{
    public int event_id;
    public int[] unlocked;
    public int[] read;
    public EventSubStoryInfo[] sub_story_info_list;
}

public class EventSubStoryInfo
{
    public int sub_story_id;
    public eEventSubStoryStatus status;
}

public class ExchangeRewards
{
    public int id;
    public int type;
    public int count;
    public int stock;
    public int received;
}

public class FriendBattleInfo
{
    public long viewer_id;
    public string name;
    public EmblemData emblem;
    public int level;
    public UnitDataForView favorite_unit;
    public FriendDeckInfo[] deck_list;
}

public class FriendBattleResult
{
    public UnitDamageInfo[] unit_damage_list;
    public UnitHpInfoForFriendBattle[] unit_hp_list;
    public int wave_num;
    public int remain_time;
}

public class FriendDeckInfo
{
    public int deck_number;
    public int mask_bif_flag;
    public UnitDataForView[] unit_data;
}

public class FriendInfo
{
    public long viewer_id;
    public string name;
    public EmblemData emblem;
    public int level;
    public UnitDataForView favorite_unit;
    public long last_login_time;
    public int total_power;
    public int friend_num;
}

public class FriendSetting
{
    public int limit_accept;
    public int limit_request;
    public int limit_pending;
}

public class FriendSupportUnitIniSetting
{
    public int support_interval;
    public int gold_unit_period;
    public int gold_base;
    public float gold_rate_power;
    public int gold_per_support_count;
    public int support_count_bonus_daily_limit;
    public int support_count_bonus_limit;
    public int support_time_bonus_limit;
    public int limit_unit_level;
    public int consume_gold_rate;
    public int consume_gold_limit;
    public int support_lv_band;
}

public class GachaBonusItem
{
    public int target_unit_id;
    public eInventoryType reward_type;
    public int reward_id;
    public int reward_count;
}

public class GachaBonusResult
{
    public InventoryInfo bonus1;
    public InventoryInfo bonus2;
    public InventoryInfo bonus3;
    public InventoryInfo bonus4;
    public InventoryInfo bonus5;
    public InventoryInfo bonus6;
    public InventoryInfo bonus7;
    public InventoryInfo bonus8;
    public InventoryInfo bonus9;
    public InventoryInfo bonus10;
}

public class GachaGrowthUnitInfo
{
    public GrowthInfo growth1;
    public GrowthInfo growth2;
    public GrowthInfo growth3;
    public GrowthInfo growth4;
    public GrowthInfo growth5;
    public GrowthInfo growth6;
    public GrowthInfo growth7;
    public GrowthInfo growth8;
    public GrowthInfo growth9;
    public GrowthInfo growth10;
}

public class GachaParameter
{
    public int id;
    public eGachaType type;
    public long start_time;
    public long end_time;
    public int cost_num_single;
    public int ticket_id;
    public int free_gacha_interval_time;
    public int discount_price;
    public int exchange_id;
    public int free_exec_times;
    public long last_free_gacha_time;
    public int discount_exec_times;
    public long last_discount_gacha_time;
    public RecommendUnit[] recommend_unit;
    public string url_param;
    public int ticket_id10;
    public int selected_item_id;
    public GachaBonusItem[] bonus_item_list;
    public int free_gacha_campaign_id;
    public int exec_count;
}

public class GachaPointInfo
{
    public int exchange_id;
    public int current_point;
    public int max_point;
}

public class GachaPointReset
{
    public int exchange_id;
    public int lost_gacha_point;
}

public class GachaPrizeHistoryList
{
    public int exec_count;
    public int rarity;
    public long exec_time;
}

public class GachaPrizeItemDetail
{
    public int rarity;
    public float odds;
    public float odds_in10th;
    public InventoryInfo[] reward_list;
}

public class GachaStep
{
    public TutorialGachaIndex gacha_index;
}

public class GaugeInfo
{
    public int start_level;
    public int total;
    public int unit_id;
    public int chara_id;
}

public class GrandArenaCountInfo
{
    public int battle_number;
}

public class GrandArenaDamageInfo
{
    public UnitDamageInfo[] first_result;
    public UnitDamageInfo[] second_result;
    public UnitDamageInfo[] third_result;
}

public class GrandArenaDeck
{
    public UnitDataForView[] first;
    public UnitDataForView[] second;
    public UnitDataForView[] third;
}

public class GrandArenaHistoryDetailInfo
{
    public int log_id;
    public int is_challenge;
    public long vs_user_viewer_id;
    public int vs_user_team_level;
    public string vs_user_name;
    public int[] win_or_lose;
    public EmblemData emblem;
    public GrandArenaDeck user_grand_arena_deck;
    public GrandArenaDeck vs_user_grand_arena_deck;
    public GrandArenaDamageInfo damage_list;
}

public class GrandArenaHistoryInfo
{
    public int log_id;
    public long versus_time;
    public int is_challenge;
    public int win_or_lose;
    public EmblemData emblem;
    public int win_number;
    public int lose_number;
    public GrandArenaOppnentUserInfo opponent_user;
}

public class GrandArenaInfo
{
    public int max_battle_number;
    public int battle_number;
    public int interval_end_time;
    public int winning_number;
    public int yesterday_defend_number;
    public int highest_rank;
    public int season_highest_rank;
    public int rank;
    public int group;
    public int group_moving_release_time;
}

public class GrandArenaOppnentUserInfo
{
    public long viewer_id;
    public string user_name;
    public int team_level;
    public UnitDataForView favorite_unit;
    public int total_power;
    public EmblemData emblem;
}

public class GrandArenaSearchOpponent
{
    public long viewer_id;
    public int rank;
    public int winning_number;
    public string user_name;
    public int team_level;
    public UnitDataForView favorite_unit;
    public EmblemData emblem;
    public GrandArenaDeck grand_arena_deck;
}

public class GrandArenaSetting
{
    public int time_reset_cost;
    public int count_reset_cost;
}

public class GrowthInfo
{
    public int unit_id;
    public GrowthParameterList growth_parameter_list;
}

public class GrowthParameterList
{
    public int unit_rarity;
    public int unit_level;
    public int skill_level;
    public int promotion_level;
    public int equipment1;
    public int equipment2;
    public int equipment3;
    public int equipment4;
    public int equipment5;
    public int equipment6;
    public int love_level;
    public int[] growth_id_list;
    public int[] equip_slot;
}

public class HatsuneBossBattleFinishUnit
{
    public UnitDamageInfo[] unit_damage_list;
    public UnitOriginalHpInfo[] unit_hp_list;
}

public class HatsuneEventBossEnemyInfo
{
    public int boss_id;
    public int enemy_identify;
    public int hp;
}

public class HatsuneEventBossStatus
{
    public int boss_id;
    public int hp;
    public int is_unlocked;
    public int appear_num;
    public int attack_num;
    public int kill_num;
    public int is_force_unlocked;
    public int daily_kill_count;
    public int oneblow_kill_count;
    public int enemy_identify;
}

public class HatsuneEventStatus
{
    public int event_type;
    public int event_id;
    public int period;
}

public class HatsuneEventStoryState
{
    public int story_id;
    public int is_unlocked;
    public bool is_readed;
}

public class HatsuneLoginBonusData
{
    public int todays_count;
    public InventoryInfo[] rewards;
}

public class HatsuneSeriesInfo
{
    public int event_id;
    public bool is_hard_quest_unlocked;
    public HatsuneEventBossStatus[] bosses;
}

public class HatsuneUserEventQuest
{
    public int quest_id;
    public int clear_flag;
    public int result_type;
    public int is_unlocked;
    public int limit_time;
    public int[] wave_pattern_ids;
    public int daily_clear_count;
    public int daily_recovery_count;
}

public class HistoryReport
{
    public long viewer_id;
    public int unit_id;
    public int unit_rarity;
    public int damage;
    public SkinData skin_data;
}

public class IniPair
{
    public int key;
    public int val;
}

public class IniSetting
{
    public EquipStrSetting equipment_enhance;
    public QuestSetting quest;
    public DungeonSetting dungeon;
    public UnitSetting unit;
    public ArenaSetting arena;
    public GrandArenaSetting grand_arena;
    public LimitSetting limit;
    public ClanSetting clan;
    public ClanBattleSetting clan_battle;
    public FriendSetting friend;
    public RoomSetting room;
    public TowerSetting tower;
    public RecoverChallengeCountSetting recover_challenge_count;
    public RecoverChallengeCountSetting very_hard_recover_challenge_count;
    public SendApi send_api;
    public BattleLogType battle_log_type;
    public NormalGachaSetting normal_gacha;
    public int require_exchange_point;
    public RecoverChallengeCountSetting hatsune_recover_challenge_count;
    public CartoonSetting cartoon;
    public UniqueEquipSetting unique_equip;
    public RecoverChallengeCountSetting equip_recover_challenge_count;
    public RecoverChallengeCountSetting high_rarity_equip_recover_challenge_count;
    public UnreadStoryNoticeSetting unread_story_notice;
    public int max_boss_battle_skip_num;
    public int max_gacha_count;
    public BulkSkipSetting multiple_skip;
    public FriendSupportUnitIniSetting friend_support_unit;
    public KaiserBattleIniSetting kaiser_battle;
    public SerialCodeIniSetting serial_code;
    public int arena_skip_upper_rank;
    public int loop_box_multi_gacha_count;
}

public class InventoryInfo
{
    public int id;
    public eInventoryType type;
    public int count;
    public int received;
    public int stock;
    public UnitData unit_data;
    public DuplicateUnitInfo exchange_data;
}

public class InventoryInfoPost
{
    public int id;
    public int type;
    public int count;
}

public class InventoryInfoShort
{
    public int id;
    public int stock;
    public long create_time;
}

public class InviteClanDetail
{
    public int clan_id;
    public long leader_viewer_id;
    public int invite_id;
    public string leader_name;
    public UnitDataForView leader_favorite_unit;
    public string clan_name;
    public string description;
    public string invite_message;
    public eClanJoinCondition join_condition;
    public eClanActivityGuideline activity;
    public int clan_battle_mode;
    public int member_num;
    public int grade_rank;
}

public class InvitedUserDetail
{
    public long viewer_id;
    public int invite_id;
    public string user_name;
    public UnitDataForView favorite_unit;
    public int team_level;
    public long user_last_login_time;
    public EmblemData emblem;
}

public class ItemInfo
{
    public int item_id;
    public int item_num;
    public int current_num;
}

public class ItemListRequest
{
    public int item_type;
    public int item_id;
    public int item_num;
}

public class JoinRequestUserInfo
{
    public long viewer_id;
    public string name;
    public int level;
    public string comment;
    public UnitDataForView favorite_unit;
    public EmblemData emblem;
}

public class KaiserBattleIniSetting
{
    public int support_lv_band;
    public int support_limit;
    public float allowable_damage_coefficient;
    public int allowable_enemy_point;
    public int allowable_barrier_point;
    public int remaining_count_max;
}

public class KaiserBattleSupportRental
{
    public int support_num;
    public long owner_viewer_id;
    public int support_unit_id;
}

public class KaiserBossInfo
{
    public int kaiser_boss_id;
    public int progress;
    public int condition_count;
    public int current_hp;
    public int kill_count;
    public int mode;
    public int enemy_point;
    public int attack_count;
}

public class KmkKillList
{
    public int low;
    public int middle;
    public int high;
}

public class LastFriendTime
{
    public long accept;
    public long pending;
}

public class LevelInfo
{
    public GaugeInfo team;
    public GaugeInfo[] unit;
    public GaugeInfo[] love;
}

public class LimitedShop
{
    public int system_id;
    public long close_time;
}

public class LimitSetting
{
    public int limit_equipment_num;
    public int limit_gold;
    public int limit_jewel;
    public int limit_free_jewel;
}

public class LoadDeckData
{
    public ePartyType deck_number;
    public int unit_id1;
    public int unit_id2;
    public int unit_id3;
    public int unit_id4;
    public int unit_id5;
    public int battle_rarity1;
    public int battle_rarity2;
    public int battle_rarity3;
    public int battle_rarity4;
    public int battle_rarity5;
}

public class LoginBonusData
{
    public int campaign_id;
    public int total_count;
    public int count_num;
    public string type;
    public eInventoryType reward_type;
    public int reward_id;
    public int reward_count;
    public int lottery_type;
}

public class LoginBonusList
{
    public LoginBonusData[] first;
    public LoginBonusData[] normal;
    public LoginBonusData[] campaign;
    public LoginBonusData[] lottery;
    public LoginBonusData[] adv;
    public LoginBonusData[] countdown;
    public LoginBonusData[] birthday;
    public LoginBonusData[] story_read_process;
}

public class MaintenanceStatus
{
    public long from;
    public long to;
    public long from_date_time;
    public long to_date_time;
}

public class MaterialInfo
{
    public int material_id;
    public int consume_num;
    public int possession_num;
}

public class MaterialParameter
{
    public int material_id;
    public int material_count;
}

public class MaxExecNumList
{
    public int arena_limit;
    public int convert_rupee_limit;
    public int dungeon_limit;
    public int special_quest_limit;
    public int stamina_limit;
}

public class MemberBossRanks
{
    public string name;
    public UnitDataForView favorite_unit;
    public EmblemData emblem;
    public BossRank[] bosses;
    public long viewer_id;
    public long score;
}

public class MemberScoreRanking
{
    public string name;
    public UnitDataForView favorite_unit;
    public int rank;
    public long score;
    public long total_power;
    public EmblemData emblem;
    public long viewer_id;
}

public class MessageIni
{
    public int message_id;
    public string message;
}

public class MissionNotice
{
    public int mission_id;
    public int count;
    public int max_times;
}

public class MissionRequestFlag
{
    public int quest_clear_rank;
}

public class MissionStep
{
    public TutorialMissionIndex mission_index;
    public TutorialMissionAccept mission_accept;
}

public class MusicIdData
{
    public eBGMKey bgm_key;
    public int music_id;
}

public class MusicPurchasedData
{
    public int music_id;
    public long purchased_time;
}

public class MyLog
{
    public int mylog_id;
    public int battle_log_id;
    public int is_auto;
    public int lap_num;
    public int phase_num;
    public int order_num;
    public long battle_time;
    public int total_damage;
    public MyLogUnitData[] units;
    public MyLogEnemyData enemy;
    public int clan_battle_mode;
}

public class MyLogEnemyData
{
    public int enemy_id;
    public int damage;
}

public class MyLogUnitData
{
    public int unit_id;
    public int unit_rarity;
    public int unit_level;
    public int promotion_level;
    public int damage;
    public SkinData skin_data;
    public EquipSlot[] unique_equip_slot;
    public long viewer_id;
}

public class MyPage
{
    public int type;
    public int id;
    public int music_id;
    public int still_skin_id;
}

public class MyPartyInfo
{
    public UserMyPartyTab tab;
    public UserMyParty[] party;
}

public class MyProfileCardDisplayStatus
{
    public bool viewer_id;
    public bool level;
    public bool power;
    public bool clan_battle;
    public bool arena;
    public bool grand_arena;
    public bool tower;
}

public class MyProfileCardScore
{
    public int clan_battle_id;
    public int clan_battle_score;
    public int arena_rank;
    public int grand_arena_rank;
    public int tower_cleared_floor_num;
    public int tower_cleared_ex_quest_count;
    public int clan_id;
    public int[] emblem_id_list;
    public int last_clan_battle_mode;
}

public class MyProfileCardSetting
{
    public int unit_id;
    public int skin;
    public int emblem_id;
    public int background;
    public int frame;
    public MyProfileCardDisplayStatus disp_status;
    public string comment;
}

public class NormalGachaSetting
{
    public NormalGachaTerm[] term_list;
}

public class NormalGachaTerm
{
    public string time;
}

public class Notification
{
    public EquipDonateNotification equip_donation;
    public MissionNotice[] mission;
}

public class OpponentUser
{
    public long viewer_id;
    public string user_name;
    public int team_level;
    public UnitDataForView favorite_unit;
    public int total_power;
    public EmblemData emblem;
}

public class OtherClanData
{
    public ClanInfo detail;
    public ClanMemberInfo[] members;
    public int invite_id;
    public int block_id;
}

public class OthersClanInfo
{
    public int message_id;
    public int quest_id;
    public int lobby_id;
    public int level_limit;
    public long create_time;
    public int accept_quest_time;
    public int member_count;
}

public class PartsInfo
{
    public int parts_id;
    public int hp;
}

public class PctBonusInfo
{
    public int bonus_type;
    public int bonus_count;
    public int add_point;
}

public class PctCacaoInfo
{
    public int cacao_id;
    public int stock;
}

public class PctGradeInfo
{
    public int grade_type;
    public int grade_count;
}

public class PctUnitPointInfo
{
    public int unit_id;
    public int pct_point;
}

public class PeriodRanking
{
    public string clan_name;
    public int member_num;
    public long leader_viewer_id;
    public string leader_name;
    public EmblemData emblem;
    public UnitDataForView leader_favorite_unit;
    public int rank;
    public long damage;
    public int grade_rank;
}

public class PkbBattingResultInfo
{
    public int batting_distance;
    public PkbReplay replay;
}

public class PkbCatalogBatter
{
    public int batter_id;
    public int batting_num;
    public int hit_num;
    public int status;
}

public class PkbCatalogInfo
{
    public PkbCatalogBatter[] batter;
    public PkbCatalogPitcher[] pitcher;
}

public class PkbCatalogPitcher
{
    public int pitcher_id;
    public int status;
    public int[] unlocked_ball_type;
}

public class PkbHighScoreInfo
{
    public int normal;
    public int hard;
    public int very_hard;
    public int extra;
}

public class PkbRankingInfo
{
    public PkbRankingSingle single_distance;
    public PkbRankingTotal total_distance;
    public PkbRankingTotal home_run_num;
}

public class PkbRankingRecordSingle
{
    public int record_value;
    public int status;
    public PkbReplay replay;
}

public class PkbRankingRecordTotal
{
    public int record_value;
    public int status;
    public PkbReplay[] replay_list;
}

public class PkbRankingSingle
{
    public PkbRankingRecordSingle[] normal;
    public PkbRankingRecordSingle[] hard;
    public PkbRankingRecordSingle[] very_hard;
    public PkbRankingRecordSingle[] extra;
}

public class PkbRankingTotal
{
    public PkbRankingRecordTotal[] normal;
    public PkbRankingRecordTotal[] hard;
    public PkbRankingRecordTotal[] very_hard;
    public PkbRankingRecordTotal[] extra;
}

public class PkbReadRankingInfo
{
    public int category;
    public int difficulty_level;
}

public class PkbReplay
{
    public int pitcher;
    public int batter;
    public int seed;
    public int batting_time;
    public double[] batting_pos;
    public int gauge;
    public int[] happen_triggers;
    public int adrenaline_count;
}

public class PostMultiUnlockRarity6Slot
{
    public int slot_id;
    public int current_unlock_level;
    public int after_unlock_level;
    public int current_material_num;
}

public class PracticeDeckData
{
    public int deck_number;
    public string deck_name;
    public int unit_id1;
    public int unit_id2;
    public int unit_id3;
    public int unit_id4;
    public int unit_id5;
    public int mask_bit_flag;
}

public class PracticeWaveInfo
{
    public int battle_log_id;
    public int seed;
    public UnitData[] user_deck;
    public UnitData[] vs_user_deck;
    public int wave_num;
}

public class PresentHistoryInfo
{
    public long present_id;
    public eInventoryType reward_type;
    public int reward_id;
    public int reward_count;
    public int message_id;
    public int message_param_value1;
    public int message_param_value2;
    public int message_param_value3;
    public int message_param_value4;
    public long create_time;
    public string message_text;
}

public class PresentParameter
{
    public long present_id;
    public eInventoryType reward_type;
    public int reward_id;
    public int reward_count;
    public int reward_rarity;
    public int message_id;
    public int message_param_value1;
    public int message_param_value2;
    public int message_param_value3;
    public int message_param_value4;
    public eRewardLimitType reward_limit_flag;
    public long reward_limit_time;
    public long create_time;
    public string message_text;
}

public class Price
{
    public int currency_id;
    public int currency_num;
}

public class PrizeRewardInfo
{
    public PrizeRewardInfoDetail prize1;
    public PrizeRewardInfoDetail prize2;
    public PrizeRewardInfoDetail prize3;
    public PrizeRewardInfoDetail prize4;
    public PrizeRewardInfoDetail prize5;
    public PrizeRewardInfoDetail prize6;
    public PrizeRewardInfoDetail prize7;
    public PrizeRewardInfoDetail prize8;
    public PrizeRewardInfoDetail prize9;
    public PrizeRewardInfoDetail prize10;
}

public class PrizeRewardInfoDetail
{
    public int rarity;
    public InventoryInfo[] rewards;
}

public class ProfileQuestInfo
{
    public int[] normal_quest;
    public int[] hard_quest;
    public int[] very_hard_quest;
}

public class ProfileUserInfo
{
    public long viewer_id;
    public string user_name;
    public string user_comment;
    public int team_level;
    public int team_exp;
    public int arena_rank;
    public int arena_group;
    public long arena_time;
    public int grand_arena_rank;
    public int grand_arena_group;
    public long grand_arena_time;
    public int open_story_num;
    public int unit_num;
    public int total_power;
    public int tower_cleared_floor_num;
    public int tower_cleared_ex_quest_count;
    public EmblemData emblem;
    public int last_login_time;
    public int friend_num;
}

public class PrologueFirstStep
{
    public TutorialStoryQuestStart story_quest_start;
}

public class PrologueLatterDStep
{
    public TutorialStoryQuestStart story_quest_start;
}

public class PurchasedTimesData
{
    public string csv_data_id;
    public int number_of_product_purchased;
}

public class QuestOneStep
{
    public TutorialHomeIndex home_index;
    public TutorialQuestStart quest_start;
    public TutorialQuestFinish quest_finish;
}

public class QuestRecoverInfo
{
    public int quest_id;
    public int daily_recovery_count;
}

public class QuestReplayData
{
    public int clear_flg;
    public int team_level;
    public int power;
    public int seed;
    public string enc_key;
    public UnitDataForView[] unit_info;
}

public class QuestResult
{
    public InventoryInfo[] reward_list;
    public int acquired_gold;
    public int acquired_team_exp;
    public SkipGoldRewardInfo[] acquired_gold_list;
}

public class QuestResultList
{
    public QuestResult[] quest_result;
    public int quest_id;
    public int daily_clear_count;
}

public class QuestSetting
{
    public int recovery_time;
    public int challenge_count_special_gold;
    public int challenge_count_special_exp;
}

public class QuestSkipInfo
{
    public int quest_id;
    public int skip_count;
}

public class QuestTwoStep
{
    public TutorialGachaExec gacha_exec;
    public TutorialHomeIndex home_index;
    public TutorialQuestStart quest_start;
    public TutorialQuestFinish quest_finish;
}

public class RaceLoginBonusInfo
{
    public int fortune_id;
    public int rank;
    public int seed;
    public int[] unit_list;
}

public class RaceLoginBonusRewardList
{
    public int type;
    public int id;
    public int received;
}

public class RankingGroupInfo
{
    public int group_id;
    public int is_destination;
}

public class RankingReward
{
    public int rank_from;
    public int rank_to;
    public InventoryInfo[] reward_list;
}

public class RankingSearchOpponent
{
    public long viewer_id;
    public int rank;
    public string user_name;
    public int team_level;
    public UnitDataForView favorite_unit;
    public UnitDataForView[] arena_deck;
    public EmblemData emblem;
}

public class RankResult
{
    public int clan_battle_id;
    public int period;
    public int clan_rank;
    public int rank_in_clan;
    public int clan_battle_mode;
    public int lap_num;
    public int total_kill_count;
    public int battle_joined;
}

public class RecommendUnit
{
    public int unit_id;
    public int display_order;
    public int growth_id;
}

public class RecoverChallengeCountSetting
{
    public int recovery;
    public int recovery_max_count;
    public int[] cost;
}

public class RecoverStamina
{
    public int count;
    public int exec_count;
    public int recovery;
    public int cost;
}

public class RefundItem
{
    public int item_id;
    public eItemType type;
    public int number;
}

public class ReleaseContentData
{
    public eSystemId system_id;
    public DeckData[] deck_list;
}

public class ReplayUnitDataForView
{
    public int id;
    public int unit_level;
    public int unit_rarity;
    public int battle_rarity;
    public ePromotionLevel promotion_level;
    public SkinData skin_data;
    public EquipSlot[] unique_equip_slot;
    public int is_alive;
}

public class RequiredMaterialList
{
    public UserEquipParameterIdCount[] equip_list;
}

public class RestChallengeInfo
{
    public int dungeon_type;
    public int count;
    public int max_count;
}

public class ReturnFesInfo
{
    public long end_time;
    public int original_gacha_id;
    public GachaPointInfo gacha_point_info;
    public int[] supply_unit_id_list;
    public int can_campaign_gacha;
}

public class RoleInfo
{
    public long viewer_id;
    public int role_id;
}

public class RoomExtensionItem
{
    public int serial_id;
    public int room_item_id;
    public int color_id;
}

public class RoomFloorLayout
{
    public RoomItemPosition[] floor;
    public RoomItemPosition[] wall;
    public RoomTheme theme;
}

public class RoomFloorLayoutForMyset
{
    public RoomItemPositionForMyset[] floor;
    public RoomItemPositionForMyset[] wall;
    public RoomTheme theme;
}

public class RoomItemGetTime
{
    public int room_item_id;
    public int get_time;
}

public class RoomItemPosition
{
    public int serial_id;
    public int direction;
    public int x;
    public int y;
}

public class RoomItemPositionForMyset
{
    public int room_item_id;
    public int direction;
    public int x;
    public int y;
}

public class RoomMysetElement
{
    public int myset_index;
    public string myset_name;
    public string myset_update_time;
    public RoomWholeLayoutForMyset myset_layout;
}

public class RoomSetting
{
    public int extension_room_storage_cost;
    public int extension_room_storage_num;
    public int max_room_storage_num;
    public int shortening_time;
    public int use_jewel;
    public int not_stock_term;
    public int max_stock_count;
}

public class RoomTheme
{
    public int floor_theme;
    public int wall_theme;
    public int background_theme;
}

public class RoomUserInfo
{
    public long viewer_id;
    public string name;
    public string comment;
    public int team_level;
    public bool today_like_flag;
    public long like_time;
    public bool flag_read;
    public int total_liked;
    public int like_reward;
    public UnitDataForView favorite_unit;
    public DeckListDataForView[] deck_list_for_client;
    public EmblemData emblem;
}

public class RoomUserItem
{
    public int serial_id;
    public int room_item_id;
    public int room_item_level;
    public int room_item_skin_id;
    public long level_up_end_time;
    public long item_base_time;
    public int item_count;
}

public class RoomWholeLayout
{
    public int background_theme;
    public RoomFloorLayout[] floor_layout;
}

public class RoomWholeLayoutForMyset
{
    public int background_theme;
    public RoomFloorLayoutForMyset floor_layout;
}

public class SearchOpponent
{
    public long viewer_id;
    public int rank;
    public string user_name;
    public int team_level;
    public UnitDataForView favorite_unit;
    public UnitData[] arena_deck;
    public EmblemData emblem;
}

public class SearchUserInfo
{
    public long viewer_id;
    public string user_name;
    public string user_comment;
    public int team_level;
    public long last_login_time;
}

public class SeasonPackRewardInfo
{
    public int reward_type;
    public int reward_id;
    public int reward_count;
}

public class SeasonPassData
{
    public bool has_buy;
    public int point_limit_flag;
    public InventoryInfo[] exchange_rewards;
    public int season_id;
    public int is_buy;
    public int seasonpass_level;
    public int user_point;
    public int weekly_point;
    public UserMissionInfo[] missions;
    public int[] received_rewards;
}

public class SekaiRanking
{
    public string name;
    public UnitDataForView favorite_unit;
    public int rank;
    public long damage;
    public int total_power;
}

public class SendApi
{
    public int notice;
    public int home;
}

public class SendGiftData
{
    public int item_id;
    public int item_num;
    public int current_item_num;
}

public class SerialCodeIniSetting
{
    public int restrict_release_sec;
}

public class ShioriQuestInfo
{
    public UserQuestInfo[] quest_list;
    public int[] dead_boss_list;
}

public class Shop
{
    public Alchemy alchemy;
    public RecoverStamina recover_stamina;
}

public class ShopBuyInfo
{
    public int system_id;
    public int slot_id;
    public int current_currency_num;
    public int number;
}

public class ShopInfo
{
    public int system_id;
    public int reset_count;
    public long next_renewal_time;
    public int reset_cost;
    public int reset_cost_id;
    public long close_time;
    public int remaining_appear_count;
    public int max_appear_num;
    public ShopItem[] item_list;
}

public class ShopItem
{
    public eInventoryType type;
    public int slot_id;
    public int item_id;
    public int num;
    public int sold;
    public int end_time;
    public Price price;
    public int exchange_count;
    public int available_num;
    public int price_group;
    public int seq_id;
    public int stock_count;
    public int purchase_count;
    public int renewal_time;
    public eShopItemBannerType banner_type;
    public int gojuon_order;
}

public class SkillLevelInfo
{
    public int skill_id;
    public int skill_level;
    public int slot_number;
}

public class SkillLevelInfoLight
{
    public int skill_level;
}

public class SkillLevelUpDetail
{
    public int location;
    public int step;
    public int current_level;
}

public class SkillLimitCounter
{
    public int skill_id;
    public int counter;
}

public class SkinChangeSetting
{
    public long open_time;
}

public class SkinData
{
    public int icon_skin_id;
    public int sd_skin_id;
    public int still_skin_id;
    public int motion_id;
}

public class SkinDataForRequest
{
    public int unit_id;
    public int icon_skin_id;
    public int sd_skin_id;
    public int still_skin_id;
    public int motion_id;
}

public class SkipGoldRewardInfo
{
    public int count;
}

public class SpecialBattleInfo
{
    public UnitHpInfo[] enemy_unit;
    public int enemy_point;
    public int mode;
    public int kill_limit;
}

public class SrtCatalogInfo
{
    public int reading_id;
    public eSrtCatalogStatus status;
}

public class SrtHighScoreInfo
{
    public int normal;
    public int hard;
    public int extra;
}

public class StartDashFesInfo
{
    public long end_time;
    public int original_gacha_id;
    public GachaPointInfo sdfes_gacha_point_info;
    public int[] supply_unit_id_list;
    public int can_campaign_gacha;
}

public class StatusParam
{
    public long hp;
    public int atk;
    public int def;
    public int magic_str;
    public int magic_def;
    public int physical_critical;
    public int magic_critical;
    public int wave_hp_recovery;
    public int wave_energy_recovery;
    public int hp_recovery_rate;
    public int physical_penetrate;
    public int magic_penetrate;
    public int life_steal;
    public int dodge;
    public int energy_reduce_rate;
    public int energy_recovery_rate;
    public int accuracy;
}

public class StatusParamShort
{
    public long hp;
    public int atk;
    public int def;
    public int matk;
    public int mdef;
    public int crt;
    public int mcrt;
    public int hrec;
    public int erec;
    public int hrec_rate;
    public int pnt;
    public int mpnt;
    public int life_steal;
    public int dodge;
    public int erec_rate;
    public int ered_rate;
    public int accuracy;
}

public class StrCoinCost
{
    public int idx;
    public int cost;
}

public class StrJewelCost
{
    public int idx;
    public int cost;
}

public class SupportUnitForProfile
{
    public int position;
    public UnitDataLight unit_data;
}

public class SupportUnitSetting
{
    public int unit_id;
    public int position;
    public long support_start_time;
    public int friend_support_count;
    public int general_support_count;
    public int clan_support_count;
    public int friend_support_reward;
    public int support_type;
}

public class SupportUnitStatus
{
    public string owner_name;
    public long owner_viewer_id;
    public UnitDataLight unit_data;
    public int user_position_status;
    public UnitData unit_param_data;
}

public class TicketGachaParameter
{
    public int id;
    public long start_time;
    public long end_time;
    public int ticket_id;
    public int exec_times;
    public string url_param;
    public bool is_chara_exchange_ticket;
}

public class TotalRanking
{
    public string clan_name;
    public int member_num;
    public long leader_viewer_id;
    public string leader_name;
    public UnitDataForView leader_favorite_unit;
    public int rank;
    public int[] period_rank;
    public int grade_rank;
}

public class TowerClanMemberInfo
{
    public TowerClearedUserInfo cleared_data;
    public int floor_num;
    public ClearedExQuestList[] cleared_ex_quest_list;
    public long cloister_cleared_time;
}

public class TowerClearedUserInfo
{
    public long viewer_id;
    public string user_name;
    public int team_level;
    public UnitDataForView favorite_unit;
    public long cleared_time;
    public EmblemData emblem;
}

public class TowerExDispatchUnit
{
    public long owner_viewer_id;
    public string owner_name;
    public int enable;
    public int current_support_unit;
    public UnitData unit_data;
}

public class TowerExDispatchUnitLight
{
    public long owner_viewer_id;
    public string owner_name;
    public int enable;
    public int current_support_unit;
    public UnitDataLight unit_data;
}

public class TowerExPartyInfo
{
    public UnitData[] first;
    public UnitData[] second;
    public UnitData[] third;
}

public class TowerQueryUnit
{
    public long owner_viewer_id;
    public int unit_id;
    public int identify_num;
    public int damage;
    public int hp;
    public int energy;
    public SkillLimitCounter[] skill_limit_counter;
}

public class TowerReplayPartyInfo
{
    public int power;
    public ReplayUnitDataForView[] unit_info;
}

public class TowerReplayPartyList
{
    public UnitData[] party1;
    public UnitData[] party2;
    public UnitData[] party3;
}

public class TowerReplayPartyStatusList
{
    public TowerUnit[] party_status1;
    public TowerUnit[] party_status2;
    public TowerUnit[] party_status3;
}

public class TowerReplaySummary
{
    public int team_level;
    public int win_party;
    public string enc_key;
    public TowerReplayPartyInfo[] party_list;
}

public class TowerSetting
{
    public int initial_energy;
    public int timeup_hp_penalty;
    public int timeup_energy_penalty;
    public int support_rental_cost_coefficient;
    public int reduce_enemy_energy_value;
    public int reduce_enemy_energy_lower_limit;
    public int get_cleared_ex_quest_interval;
    public int support_lv_band;
    public int usable_unit_count;
}

public class TowerStatus
{
    public int cleared_floor_num;
    public int last_login_schedule_id;
}

public class TowerUnit
{
    public int unit_id;
    public int identify_num;
    public int hp;
    public int energy;
    public SkillLimitCounter[] skill_limit_counter;
    public int max_hp;
    public int saved_hp;
    public int level;
    public int rarity;
    public int promotion_level;
    public int enemy_color;
    public SkinData skin_data;
}

public class TowerWaveResultInfo
{
    public int wave_num;
    public TowerWaveResultUnitInfo[] unit_info_list;
    public int remain_time;
}

public class TowerWaveResultUnitInfo
{
    public int unit_id;
    public long owner_viewer_id;
    public int damage;
    public int is_alive;
}

public class TrainingQuestCount
{
    public int gold_quest;
    public int exp_quest;
}

public class TtkBeatEnemyInfo
{
    public int enemy_id;
    public int beat_num;
}

public class TtkCatalogInfo
{
    public int enemy_id;
    public int total_beat_num;
    public int status;
}

public class TtkHighScoreInfo
{
    public int normal;
    public int hard;
    public int extra;
    public int endless;
}

public class TutorialGachaExec
{
    public InventoryInfo[] reward_info_list;
    public int add_present_count;
}

public class TutorialGachaIndex
{
    public GachaParameter[] gacha_info;
}

public class TutorialHomeIndex
{
    public int mission_count;
    public int unread_message_count;
    public UserClan user_clan;
}

public class TutorialMissionAccept
{
    public int team_level;
    public int team_exp;
    public UserStaminaInfo stamina_info;
    public InventoryInfo[] rewards;
    public bool flag_exchange_team_exp;
    public int add_present_count;
}

public class TutorialMissionIndex
{
    public UserMissionInfo[] missions;
    public long daily_reset_time;
}

public class TutorialQuestFinish
{
    public LevelInfo level_info;
    public UserStaminaInfo user_info;
    public bool flag_exchange_team_exp;
    public int[] unlock_quest_list;
    public UserStory[] open_story_ids;
    public int quest_id;
    public int clear_flag;
    public int result_type;
    public int daily_clear_count;
    public InventoryInfo[] rewards;
    public int add_present_count;
}

public class TutorialQuestStart
{
    public WaveEnemyInfoList[] quest_wave_info;
    public int limit_time;
    public int quest_id;
    public UnitData[] enemy_list;
    public UserStaminaInfo user_info;
    public int battle_log_id;
}

public class TutorialStoryQuestStart
{
    public WaveEnemyInfoList[] quest_wave_info;
    public int limit_time;
    public int quest_id;
    public UnitData[] enemy_list;
    public UserStaminaInfo user_info;
    public UnitData[] guest_data;
}

public class TutorialUnitEquip
{
    public UnitData unit_data;
    public InventoryInfo equip_data;
}

public class UekBossInfo
{
    public int enemy_id;
    public int hp;
    public int attack_num;
}

public class UniqueEquipLimitSetting
{
    public int equip_slot;
    public int promotion;
    public int rarity;
}

public class UniqueEquipSetting
{
    public UniqueEquipLimitSetting[] limit_list;
}

public class UnitDamageInfo
{
    public long viewer_id;
    public int unit_id;
    public int damage;
    public int rarity;
    public SkinData skin_data;
}

public class UnitData
{
    public int id;
    public long get_time;
    public int start_rarety;
    public int unit_rarity;
    public int battle_rarity;
    public int unit_level;
    public int unit_exp;
    public ePromotionLevel promotion_level;
    public SkillLevelInfo[] union_burst;
    public SkillLevelInfo[] main_skill;
    public SkillLevelInfo[] ex_skill;
    public SkillLevelInfo[] free_skill;
    public EquipSlot[] equip_slot;
    public EquipSlot[] unique_equip_slot;
    public UnitParam unit_param;
    public StatusParamShort bonus_param;
    public int resist_status_id;
    public int power;
    public SkinData skin_data;
    public int identify_num;
    public int favorite_flag;
    public UnlockRarity6Slot unlock_rarity6_item;
    public long total_hp;
    public int total_atk;
    public int total_def;
    public int total_magic_atk;
    public int total_magic_def;
    public int total_critical;
    public int total_magic_critical;
    public int total_wave_hp_recovery;
    public int total_wave_energy_recovery;
    public int total_hp_recovery_rate;
    public int total_physical_penetrate;
    public int total_magic_penetrate;
    public int total_life_steal;
    public int total_dodge;
    public int total_accuracy;
    public int total_energy_recovery_rate;
    public int total_energy_reduce_rate;
}

public class UnitDataForClanMember
{
    public int unit_id;
    public int position;
    public int evolution;
    public int battle_rarity;
    public int level;
    public int promotion_level;
    public int dispatch_count;
    public int dispatch_status;
    public int dispatch_start_time;
    public int current_dispatch_bonus;
    public SkinData skin_data;
    public int[] unique_equipped_list;
}

public class UnitDataForView
{
    public int id;
    public int unit_level;
    public int unit_rarity;
    public int battle_rarity;
    public ePromotionLevel promotion_level;
    public int power;
    public SkinData skin_data;
    public EquipSlot[] unique_equip_slot;
}

public class UnitDataLight
{
    public int id;
    public long get_time;
    public int start_rarety;
    public int unit_rarity;
    public int battle_rarity;
    public int unit_level;
    public int unit_exp;
    public ePromotionLevel promotion_level;
    public SkillLevelInfoLight[] union_burst;
    public SkillLevelInfoLight[] main_skill;
    public SkillLevelInfoLight[] ex_skill;
    public EquipSlotLight[] equip_slot;
    public EquipSlotLight[] unique_equip_slot;
    public StatusParamShort bonus_param;
    public int resist_status_id;
    public int power;
    public SkinData skin_data;
    public int identify_num;
    public int favorite_flag;
    public UnlockRarity6Slot unlock_rarity6_item;
}

public class UnitHpInfo
{
    public long viewer_id;
    public int unit_id;
    public int hp;
}

public class UnitHpInfoForFriendBattle
{
    public long viewer_id;
    public int unit_id;
    public int hp;
    public int hp_rate;
}

public class UnitOriginalHpInfo
{
    public long viewer_id;
    public int unit_id;
    public int hp;
    public int original_hp;
}

public class UnitParam
{
    public StatusParam base_param;
    public StatusParam equip_param;
}

public class UnitSetting
{
    public int max_evolution;
    public IniPair[] change_to_material;
}

public class UnlockRarity6Slot
{
    public int quest_clear;
    public int slot1;
    public int slot2;
    public int slot3;
    public int status1;
    public int status2;
    public int status3;
}

public class UnreadMessageList
{
    public EquipRequests[] equip_requests;
}

public class UnreadStoryNoticeSetting
{
    public string time;
    public int type;
}

public class UsedUnit
{
    public int unit_id;
    public long full_recovery_time;
    public int energy;
}

public class UserBirthDayVoice
{
    public int birthday;
    public int birthday_period;
}

public class UserChara
{
    public int chara_id;
    public int chara_love;
    public int love_level;
}

public class UserClan
{
    public int clan_id;
    public string clan_name;
    public long latest_request_time;
    public int donation_num;
    public long leave_time;
    public int clan_member_count;
}

public class UserEmblem
{
    public int emblem_id;
    public int ex_value;
}

public class UserEquipParameter
{
    public int equip_id;
    public int equip_count;
}

public class UserEquipParameterIdCount
{
    public int id;
    public int count;
}

public class UserGold
{
    public int gold_id_pay;
    public int gold_id_free;
}

public class UserInfo
{
    public long viewer_id;
    public string user_name;
    public string user_comment;
    public EmblemData emblem;
    public int team_level;
    public int user_stamina;
    public int team_exp;
    public int favorite_unit_id;
    public int tutorial_flag;
    public int user_birth;
    public long stamina_full_recovery_time;
    public int arena_rank;
    public int invite_accept_flag;
    public long reg_time;
}

public class UserItemParameter
{
    public int item_id;
    public int item_count;
}

public class UserJewel
{
    public int jewel;
    public int free_jewel;
}

public class UserMissionInfo
{
    public int mission_id;
    public int disp_order;
    public int sort_filter_type;
    public eMissionStatusType mission_status;
    public int clear_num;
    public int team_level;
    public int receive_status;
    public bool not_exist;
    public bool is_level_specific_mission;
}

public class UserMyParty
{
    public int tab_number;
    public int party_number;
    public int party_label_type;
    public string party_name;
    public int unit_id1;
    public int unit_id2;
    public int unit_id3;
    public int unit_id4;
    public int unit_id5;
    public int battle_rarity1;
    public int battle_rarity2;
    public int battle_rarity3;
    public int battle_rarity4;
    public int battle_rarity5;
}

public class UserMyPartyTab
{
    public int tab_number;
    public string tab_name;
}

public class UserMyQuest
{
    public int tab_number;
    public string tab_name;
    public int skip_count;
    public int[] skip_list;
    public int[] item_list;
    public int[] difficulty_list;
    public int initial_skip_count;
}

public class UserMyQuestForPost
{
    public int tab_number;
    public string tab_name;
    public int skip_count;
    public int[] skip_list;
}

public class UserQuestInfo
{
    public int quest_id;
    public int clear_flg;
    public int result_type;
    public int daily_clear_count;
    public int daily_recovery_count;
}

public class UserSeasonPackInfo
{
    public int mission_id;
    public int buy_id;
    public int season_end_time;
    public int extended;
    public int received;
    public SeasonPackRewardInfo[] rewards;
}

public class UserStaminaInfo
{
    public int user_stamina;
    public long stamina_full_recovery_time;
}

public class UserStory
{
    public int story_id;
    public eStoryStatus state;
    public int pre_watched_flag;
    public int special_flag;
}

public class VersusResult
{
    public int log_id;
    public long versus_time;
    public int win_or_lose;
    public OpponentUser opponent_user;
}

public class VersusResultDetail
{
    public int log_id;
    public int is_challenge;
    public int vs_user_team_level;
    public string vs_user_name;
    public int win_or_lose;
    public EmblemData emblem;
    public UnitDataForView[] user_arena_deck;
    public UnitDataForView[] vs_user_arena_deck;
    public UnitDamageInfo[] damage_list;
}

public class VotedUnit
{
    public int rarity1;
    public int rarity2;
    public int rarity3;
}

public class VoteRank
{
    public int rank;
    public int unit_id;
    public int ratio;
}

public class VoteRanking
{
    public VoteRank[] rarity1;
    public VoteRank[] rarity2;
    public VoteRank[] rarity3;
}

public class WaveEnemyInfo
{
    public int enemy_id;
    public int drop_gold;
    public InventoryInfo[] drop_reward;
}

public class WaveEnemyInfoList
{
    public WaveEnemyInfo[] enemy_info_list;
}


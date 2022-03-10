using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PCRClient.Models.Db
{
    public partial class MasterContext : DbContext
    {
        private readonly string connectString;
        internal MasterContext(string connectString)
        {
            this.connectString = connectString;
        }
        
        public virtual DbSet<ActualUnitBackground> ActualUnitBackgrounds { get; set; } = null!;
        public virtual DbSet<AilmentDatum> AilmentData { get; set; } = null!;
        public virtual DbSet<AlbumProductionList> AlbumProductionLists { get; set; } = null!;
        public virtual DbSet<AlbumVoiceList> AlbumVoiceLists { get; set; } = null!;
        public virtual DbSet<ArcadeList> ArcadeLists { get; set; } = null!;
        public virtual DbSet<ArcadeStoryList> ArcadeStoryLists { get; set; } = null!;
        public virtual DbSet<ArenaDailyRankReward> ArenaDailyRankRewards { get; set; } = null!;
        public virtual DbSet<ArenaDefenceReward> ArenaDefenceRewards { get; set; } = null!;
        public virtual DbSet<ArenaMaxRankReward> ArenaMaxRankRewards { get; set; } = null!;
        public virtual DbSet<ArenaMaxSeasonRankReward> ArenaMaxSeasonRankRewards { get; set; } = null!;
        public virtual DbSet<Banner> Banners { get; set; } = null!;
        public virtual DbSet<BgDatum> BgData { get; set; } = null!;
        public virtual DbSet<BirthdayLoginBonusDatum> BirthdayLoginBonusData { get; set; } = null!;
        public virtual DbSet<BirthdayLoginBonusDetail> BirthdayLoginBonusDetails { get; set; } = null!;
        public virtual DbSet<BirthdayLoginBonusDramaScript> BirthdayLoginBonusDramaScripts { get; set; } = null!;
        public virtual DbSet<CampaignFreegacha> CampaignFreegachas { get; set; } = null!;
        public virtual DbSet<CampaignFreegachaDatum> CampaignFreegachaData { get; set; } = null!;
        public virtual DbSet<CampaignFreegachaSp> CampaignFreegachaSps { get; set; } = null!;
        public virtual DbSet<CampaignLevelDatum> CampaignLevelData { get; set; } = null!;
        public virtual DbSet<CampaignMissionCategory> CampaignMissionCategories { get; set; } = null!;
        public virtual DbSet<CampaignMissionDatum> CampaignMissionData { get; set; } = null!;
        public virtual DbSet<CampaignMissionRewardDatum> CampaignMissionRewardData { get; set; } = null!;
        public virtual DbSet<CampaignMissionSchedule> CampaignMissionSchedules { get; set; } = null!;
        public virtual DbSet<CampaignSchedule> CampaignSchedules { get; set; } = null!;
        public virtual DbSet<CampaignShioriGroup> CampaignShioriGroups { get; set; } = null!;
        public virtual DbSet<CharaETicketDatum> CharaETicketData { get; set; } = null!;
        public virtual DbSet<CharaFortuneRail> CharaFortuneRails { get; set; } = null!;
        public virtual DbSet<CharaFortuneReward> CharaFortuneRewards { get; set; } = null!;
        public virtual DbSet<CharaFortuneScenario> CharaFortuneScenarios { get; set; } = null!;
        public virtual DbSet<CharaFortuneSchedule> CharaFortuneSchedules { get; set; } = null!;
        public virtual DbSet<CharaIdentity> CharaIdentities { get; set; } = null!;
        public virtual DbSet<CharaStoryStatus> CharaStoryStatuses { get; set; } = null!;
        public virtual DbSet<CharacterLoveRankupText> CharacterLoveRankupTexts { get; set; } = null!;
        public virtual DbSet<ClanBattle2BossDatum> ClanBattle2BossData { get; set; } = null!;
        public virtual DbSet<ClanBattle2MapDatum> ClanBattle2MapData { get; set; } = null!;
        public virtual DbSet<ClanBattleBattleMissionDatum> ClanBattleBattleMissionData { get; set; } = null!;
        public virtual DbSet<ClanBattleBossDamageRank> ClanBattleBossDamageRanks { get; set; } = null!;
        public virtual DbSet<ClanBattleBossFixReward> ClanBattleBossFixRewards { get; set; } = null!;
        public virtual DbSet<ClanBattleLastAttackReward> ClanBattleLastAttackRewards { get; set; } = null!;
        public virtual DbSet<ClanBattleOddsDatum> ClanBattleOddsData { get; set; } = null!;
        public virtual DbSet<ClanBattleParamAdjust> ClanBattleParamAdjusts { get; set; } = null!;
        public virtual DbSet<ClanBattlePeriod> ClanBattlePeriods { get; set; } = null!;
        public virtual DbSet<ClanBattlePeriodLapReward> ClanBattlePeriodLapRewards { get; set; } = null!;
        public virtual DbSet<ClanBattlePeriodRankReward> ClanBattlePeriodRankRewards { get; set; } = null!;
        public virtual DbSet<ClanBattleRecommendDatum> ClanBattleRecommendData { get; set; } = null!;
        public virtual DbSet<ClanBattleSBossDatum> ClanBattleSBossData { get; set; } = null!;
        public virtual DbSet<ClanBattleSBossFixReward> ClanBattleSBossFixRewards { get; set; } = null!;
        public virtual DbSet<ClanBattleSMapDatum> ClanBattleSMapData { get; set; } = null!;
        public virtual DbSet<ClanBattleSParamAdjust> ClanBattleSParamAdjusts { get; set; } = null!;
        public virtual DbSet<ClanBattleSchedule> ClanBattleSchedules { get; set; } = null!;
        public virtual DbSet<ClanBattleTrainingDatum> ClanBattleTrainingData { get; set; } = null!;
        public virtual DbSet<ClanBattleTrainingSchedule> ClanBattleTrainingSchedules { get; set; } = null!;
        public virtual DbSet<ClanCostGroup> ClanCostGroups { get; set; } = null!;
        public virtual DbSet<ClanGrade> ClanGrades { get; set; } = null!;
        public virtual DbSet<ClanInviteLevelGroup> ClanInviteLevelGroups { get; set; } = null!;
        public virtual DbSet<ClanprofileContent> ClanprofileContents { get; set; } = null!;
        public virtual DbSet<CombinedResultMotion> CombinedResultMotions { get; set; } = null!;
        public virtual DbSet<ContentMapDatum> ContentMapData { get; set; } = null!;
        public virtual DbSet<ContentReleaseDatum> ContentReleaseData { get; set; } = null!;
        public virtual DbSet<CooperationQuestDatum> CooperationQuestData { get; set; } = null!;
        public virtual DbSet<CustomMypage> CustomMypages { get; set; } = null!;
        public virtual DbSet<CustomMypageGroup> CustomMypageGroups { get; set; } = null!;
        public virtual DbSet<DailyMissionDatum> DailyMissionData { get; set; } = null!;
        public virtual DbSet<DearChara> DearCharas { get; set; } = null!;
        public virtual DbSet<DearReward> DearRewards { get; set; } = null!;
        public virtual DbSet<DearSetting> DearSettings { get; set; } = null!;
        public virtual DbSet<DearStoryDatum> DearStoryData { get; set; } = null!;
        public virtual DbSet<DearStoryDetail> DearStoryDetails { get; set; } = null!;
        public virtual DbSet<DefineSpskill> DefineSpskills { get; set; } = null!;
        public virtual DbSet<DodgeTpRecovery> DodgeTpRecoveries { get; set; } = null!;
        public virtual DbSet<DungeonAreaDatum> DungeonAreaData { get; set; } = null!;
        public virtual DbSet<DungeonQuestDatum> DungeonQuestData { get; set; } = null!;
        public virtual DbSet<DungeonSkipDatum> DungeonSkipData { get; set; } = null!;
        public virtual DbSet<EmblemDatum> EmblemData { get; set; } = null!;
        public virtual DbSet<EmblemMissionDatum> EmblemMissionData { get; set; } = null!;
        public virtual DbSet<EmblemMissionRewardDatum> EmblemMissionRewardData { get; set; } = null!;
        public virtual DbSet<EnemyEnableVoice> EnemyEnableVoices { get; set; } = null!;
        public virtual DbSet<EnemyMPart> EnemyMParts { get; set; } = null!;
        public virtual DbSet<EnemyParameter> EnemyParameters { get; set; } = null!;
        public virtual DbSet<EnemyRewardDatum> EnemyRewardData { get; set; } = null!;
        public virtual DbSet<EquipmentCraft> EquipmentCrafts { get; set; } = null!;
        public virtual DbSet<EquipmentDatum> EquipmentData { get; set; } = null!;
        public virtual DbSet<EquipmentDonation> EquipmentDonations { get; set; } = null!;
        public virtual DbSet<EquipmentEnhanceDatum> EquipmentEnhanceData { get; set; } = null!;
        public virtual DbSet<EquipmentEnhanceRate> EquipmentEnhanceRates { get; set; } = null!;
        public virtual DbSet<EventBgDatum> EventBgData { get; set; } = null!;
        public virtual DbSet<EventBossTreasureBox> EventBossTreasureBoxes { get; set; } = null!;
        public virtual DbSet<EventBossTreasureContent> EventBossTreasureContents { get; set; } = null!;
        public virtual DbSet<EventEffectSetting> EventEffectSettings { get; set; } = null!;
        public virtual DbSet<EventEnemyParameter> EventEnemyParameters { get; set; } = null!;
        public virtual DbSet<EventEnemyRewardGroup> EventEnemyRewardGroups { get; set; } = null!;
        public virtual DbSet<EventGachaDatum> EventGachaData { get; set; } = null!;
        public virtual DbSet<EventIntroduction> EventIntroductions { get; set; } = null!;
        public virtual DbSet<EventNaviComment> EventNaviComments { get; set; } = null!;
        public virtual DbSet<EventNaviCommentCondition> EventNaviCommentConditions { get; set; } = null!;
        public virtual DbSet<EventReminder> EventReminders { get; set; } = null!;
        public virtual DbSet<EventReminderCondition> EventReminderConditions { get; set; } = null!;
        public virtual DbSet<EventRevivalWaveGroupDatum> EventRevivalWaveGroupData { get; set; } = null!;
        public virtual DbSet<EventSeriesWaveGroupDatum> EventSeriesWaveGroupData { get; set; } = null!;
        public virtual DbSet<EventStoryDatum> EventStoryData { get; set; } = null!;
        public virtual DbSet<EventStoryDetail> EventStoryDetails { get; set; } = null!;
        public virtual DbSet<EventTopAdv> EventTopAdvs { get; set; } = null!;
        public virtual DbSet<EventWaveGroupDatum> EventWaveGroupData { get; set; } = null!;
        public virtual DbSet<ExperienceTeam> ExperienceTeams { get; set; } = null!;
        public virtual DbSet<ExperienceUnit> ExperienceUnits { get; set; } = null!;
        public virtual DbSet<FixLineupGroupSet> FixLineupGroupSets { get; set; } = null!;
        public virtual DbSet<FkeHappeningList> FkeHappeningLists { get; set; } = null!;
        public virtual DbSet<FkeReward> FkeRewards { get; set; } = null!;
        public virtual DbSet<GachaDatum> GachaData { get; set; } = null!;
        public virtual DbSet<GachaExchangeLineup> GachaExchangeLineups { get; set; } = null!;
        public virtual DbSet<GiftMessage> GiftMessages { get; set; } = null!;
        public virtual DbSet<GlobalDatum> GlobalData { get; set; } = null!;
        public virtual DbSet<GlossaryDetail> GlossaryDetails { get; set; } = null!;
        public virtual DbSet<GoldsetData2> GoldsetData2s { get; set; } = null!;
        public virtual DbSet<GoldsetDataTeamlevel> GoldsetDataTeamlevels { get; set; } = null!;
        public virtual DbSet<GoldsetDatum> GoldsetData { get; set; } = null!;
        public virtual DbSet<GrandArenaDailyRankReward> GrandArenaDailyRankRewards { get; set; } = null!;
        public virtual DbSet<GrandArenaDefenceReward> GrandArenaDefenceRewards { get; set; } = null!;
        public virtual DbSet<GrandArenaMaxRankReward> GrandArenaMaxRankRewards { get; set; } = null!;
        public virtual DbSet<GrandArenaMaxSeasonRankReward> GrandArenaMaxSeasonRankRewards { get; set; } = null!;
        public virtual DbSet<GrowthParameter> GrowthParameters { get; set; } = null!;
        public virtual DbSet<GrowthRestrictionUnit> GrowthRestrictionUnits { get; set; } = null!;
        public virtual DbSet<Guild> Guilds { get; set; } = null!;
        public virtual DbSet<GuildAdditionalMember> GuildAdditionalMembers { get; set; } = null!;
        public virtual DbSet<HatsuneBattleMissionDatum> HatsuneBattleMissionData { get; set; } = null!;
        public virtual DbSet<HatsuneBgChange> HatsuneBgChanges { get; set; } = null!;
        public virtual DbSet<HatsuneBgChangeDatum> HatsuneBgChangeData { get; set; } = null!;
        public virtual DbSet<HatsuneBoss> HatsuneBosses { get; set; } = null!;
        public virtual DbSet<HatsuneBossCondition> HatsuneBossConditions { get; set; } = null!;
        public virtual DbSet<HatsuneBossEnemySetting> HatsuneBossEnemySettings { get; set; } = null!;
        public virtual DbSet<HatsuneDailyMissionDatum> HatsuneDailyMissionData { get; set; } = null!;
        public virtual DbSet<HatsuneDescription> HatsuneDescriptions { get; set; } = null!;
        public virtual DbSet<HatsuneDiaryDatum> HatsuneDiaryData { get; set; } = null!;
        public virtual DbSet<HatsuneDiaryLetterScript> HatsuneDiaryLetterScripts { get; set; } = null!;
        public virtual DbSet<HatsuneDiaryScript> HatsuneDiaryScripts { get; set; } = null!;
        public virtual DbSet<HatsuneDiarySetting> HatsuneDiarySettings { get; set; } = null!;
        public virtual DbSet<HatsuneEmblemMission> HatsuneEmblemMissions { get; set; } = null!;
        public virtual DbSet<HatsuneEmblemMissionReward> HatsuneEmblemMissionRewards { get; set; } = null!;
        public virtual DbSet<HatsuneItem> HatsuneItems { get; set; } = null!;
        public virtual DbSet<HatsuneMap> HatsuneMaps { get; set; } = null!;
        public virtual DbSet<HatsuneMapEvent> HatsuneMapEvents { get; set; } = null!;
        public virtual DbSet<HatsuneMissionRewardDatum> HatsuneMissionRewardData { get; set; } = null!;
        public virtual DbSet<HatsuneMultiRouteParameter> HatsuneMultiRouteParameters { get; set; } = null!;
        public virtual DbSet<HatsunePresent> HatsunePresents { get; set; } = null!;
        public virtual DbSet<HatsuneQuest> HatsuneQuests { get; set; } = null!;
        public virtual DbSet<HatsuneQuestArea> HatsuneQuestAreas { get; set; } = null!;
        public virtual DbSet<HatsuneQuestCondition> HatsuneQuestConditions { get; set; } = null!;
        public virtual DbSet<HatsuneQuiz> HatsuneQuizzes { get; set; } = null!;
        public virtual DbSet<HatsuneQuizCondition> HatsuneQuizConditions { get; set; } = null!;
        public virtual DbSet<HatsuneQuizReward> HatsuneQuizRewards { get; set; } = null!;
        public virtual DbSet<HatsuneRelayDatum> HatsuneRelayData { get; set; } = null!;
        public virtual DbSet<HatsuneSchedule> HatsuneSchedules { get; set; } = null!;
        public virtual DbSet<HatsuneSpecialBattle> HatsuneSpecialBattles { get; set; } = null!;
        public virtual DbSet<HatsuneSpecialBossTicketCount> HatsuneSpecialBossTicketCounts { get; set; } = null!;
        public virtual DbSet<HatsuneSpecialEnemy> HatsuneSpecialEnemies { get; set; } = null!;
        public virtual DbSet<HatsuneSpecialMissionDatum> HatsuneSpecialMissionData { get; set; } = null!;
        public virtual DbSet<HatsuneStationaryMissionDatum> HatsuneStationaryMissionData { get; set; } = null!;
        public virtual DbSet<HatsuneUnlockStoryCondition> HatsuneUnlockStoryConditions { get; set; } = null!;
        public virtual DbSet<HatsuneUnlockUnitCondition> HatsuneUnlockUnitConditions { get; set; } = null!;
        public virtual DbSet<ItemDatum> ItemData { get; set; } = null!;
        public virtual DbSet<ItemETicketDatum> ItemETicketData { get; set; } = null!;
        public virtual DbSet<KaiserAddTimesDatum> KaiserAddTimesData { get; set; } = null!;
        public virtual DbSet<KaiserExterminationReward> KaiserExterminationRewards { get; set; } = null!;
        public virtual DbSet<KaiserQuestDatum> KaiserQuestData { get; set; } = null!;
        public virtual DbSet<KaiserRestrictionGroup> KaiserRestrictionGroups { get; set; } = null!;
        public virtual DbSet<KaiserSchedule> KaiserSchedules { get; set; } = null!;
        public virtual DbSet<KaiserSpecialBattle> KaiserSpecialBattles { get; set; } = null!;
        public virtual DbSet<KmkNaviComment> KmkNaviComments { get; set; } = null!;
        public virtual DbSet<KmkReward> KmkRewards { get; set; } = null!;
        public virtual DbSet<LoginBonusAdv> LoginBonusAdvs { get; set; } = null!;
        public virtual DbSet<LoginBonusDatum> LoginBonusData { get; set; } = null!;
        public virtual DbSet<LoginBonusDetail> LoginBonusDetails { get; set; } = null!;
        public virtual DbSet<LoginBonusMessageDatum> LoginBonusMessageData { get; set; } = null!;
        public virtual DbSet<LoveChara> LoveCharas { get; set; } = null!;
        public virtual DbSet<LtoLetterScript> LtoLetterScripts { get; set; } = null!;
        public virtual DbSet<LtoStoryDatum> LtoStoryData { get; set; } = null!;
        public virtual DbSet<Minigame> Minigames { get; set; } = null!;
        public virtual DbSet<MissionRewardDatum> MissionRewardData { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<MusicContent> MusicContents { get; set; } = null!;
        public virtual DbSet<MusicList> MusicLists { get; set; } = null!;
        public virtual DbSet<MyprofileContent> MyprofileContents { get; set; } = null!;
        public virtual DbSet<NaviComment> NaviComments { get; set; } = null!;
        public virtual DbSet<NotifDatum> NotifData { get; set; } = null!;
        public virtual DbSet<NyxDramaDatum> NyxDramaData { get; set; } = null!;
        public virtual DbSet<NyxDramaScript> NyxDramaScripts { get; set; } = null!;
        public virtual DbSet<NyxPhaseDatum> NyxPhaseData { get; set; } = null!;
        public virtual DbSet<NyxStoryDatum> NyxStoryData { get; set; } = null!;
        public virtual DbSet<NyxStoryScript> NyxStoryScripts { get; set; } = null!;
        public virtual DbSet<OddsNameDatum> OddsNameData { get; set; } = null!;
        public virtual DbSet<OmpDrama> OmpDramas { get; set; } = null!;
        public virtual DbSet<OmpStoryDatum> OmpStoryData { get; set; } = null!;
        public virtual DbSet<PctComboCoefficient> PctComboCoefficients { get; set; } = null!;
        public virtual DbSet<PctEvaluation> PctEvaluations { get; set; } = null!;
        public virtual DbSet<PctGamingMotion> PctGamingMotions { get; set; } = null!;
        public virtual DbSet<PctItempoint> PctItempoints { get; set; } = null!;
        public virtual DbSet<PctResult> PctResults { get; set; } = null!;
        public virtual DbSet<PctReward> PctRewards { get; set; } = null!;
        public virtual DbSet<PctSystem> PctSystems { get; set; } = null!;
        public virtual DbSet<PctSystemFruit> PctSystemFruits { get; set; } = null!;
        public virtual DbSet<PctTapSpeed> PctTapSpeeds { get; set; } = null!;
        public virtual DbSet<PkbBatterCondition> PkbBatterConditions { get; set; } = null!;
        public virtual DbSet<PkbDrama> PkbDramas { get; set; } = null!;
        public virtual DbSet<PkbDramaDatum> PkbDramaData { get; set; } = null!;
        public virtual DbSet<PkbNaviComment> PkbNaviComments { get; set; } = null!;
        public virtual DbSet<PkbPitcherBallType> PkbPitcherBallTypes { get; set; } = null!;
        public virtual DbSet<PkbReward> PkbRewards { get; set; } = null!;
        public virtual DbSet<PositionSetting> PositionSettings { get; set; } = null!;
        public virtual DbSet<PrizegachaDatum> PrizegachaData { get; set; } = null!;
        public virtual DbSet<ProfileFrame> ProfileFrames { get; set; } = null!;
        public virtual DbSet<PromotionBonu> PromotionBonus { get; set; } = null!;
        public virtual DbSet<QuestAnnihilation> QuestAnnihilations { get; set; } = null!;
        public virtual DbSet<QuestAreaDatum> QuestAreaData { get; set; } = null!;
        public virtual DbSet<QuestConditionDatum> QuestConditionData { get; set; } = null!;
        public virtual DbSet<QuestDatum> QuestData { get; set; } = null!;
        public virtual DbSet<QuestDefeatNotice> QuestDefeatNotices { get; set; } = null!;
        public virtual DbSet<QuestRewardDatum> QuestRewardData { get; set; } = null!;
        public virtual DbSet<Rarity6QuestDatum> Rarity6QuestData { get; set; } = null!;
        public virtual DbSet<ResistDatum> ResistData { get; set; } = null!;
        public virtual DbSet<ReturnSpecialfesBanner> ReturnSpecialfesBanners { get; set; } = null!;
        public virtual DbSet<RewardCollectGuide> RewardCollectGuides { get; set; } = null!;
        public virtual DbSet<RoomChange> RoomChanges { get; set; } = null!;
        public virtual DbSet<RoomCharacterPersonality> RoomCharacterPersonalities { get; set; } = null!;
        public virtual DbSet<RoomCharacterSkinColor> RoomCharacterSkinColors { get; set; } = null!;
        public virtual DbSet<RoomChatFormation> RoomChatFormations { get; set; } = null!;
        public virtual DbSet<RoomChatInfo> RoomChatInfos { get; set; } = null!;
        public virtual DbSet<RoomChatScenario> RoomChatScenarios { get; set; } = null!;
        public virtual DbSet<RoomEffect> RoomEffects { get; set; } = null!;
        public virtual DbSet<RoomEffectRewardGet> RoomEffectRewardGets { get; set; } = null!;
        public virtual DbSet<RoomEmotionIcon> RoomEmotionIcons { get; set; } = null!;
        public virtual DbSet<RoomItem> RoomItems { get; set; } = null!;
        public virtual DbSet<RoomItemAnnouncement> RoomItemAnnouncements { get; set; } = null!;
        public virtual DbSet<RoomItemDetail> RoomItemDetails { get; set; } = null!;
        public virtual DbSet<RoomItemGetAnnouncement> RoomItemGetAnnouncements { get; set; } = null!;
        public virtual DbSet<RoomReleaseDatum> RoomReleaseData { get; set; } = null!;
        public virtual DbSet<RoomSetup> RoomSetups { get; set; } = null!;
        public virtual DbSet<RoomSkinColor> RoomSkinColors { get; set; } = null!;
        public virtual DbSet<RoomUnitComment> RoomUnitComments { get; set; } = null!;
        public virtual DbSet<SdNaviComment> SdNaviComments { get; set; } = null!;
        public virtual DbSet<SeasonPack> SeasonPacks { get; set; } = null!;
        public virtual DbSet<SeasonpassFoundation> SeasonpassFoundations { get; set; } = null!;
        public virtual DbSet<SeasonpassLevelReward> SeasonpassLevelRewards { get; set; } = null!;
        public virtual DbSet<SeasonpassMissionDatum> SeasonpassMissionData { get; set; } = null!;
        public virtual DbSet<SeasonpassMissionRewardDatum> SeasonpassMissionRewardData { get; set; } = null!;
        public virtual DbSet<SekaiAddTimesDatum> SekaiAddTimesData { get; set; } = null!;
        public virtual DbSet<SekaiBossDamageRankReward> SekaiBossDamageRankRewards { get; set; } = null!;
        public virtual DbSet<SekaiBossFixReward> SekaiBossFixRewards { get; set; } = null!;
        public virtual DbSet<SekaiBossMode> SekaiBossModes { get; set; } = null!;
        public virtual DbSet<SekaiEnemyParameter> SekaiEnemyParameters { get; set; } = null!;
        public virtual DbSet<SekaiSchedule> SekaiSchedules { get; set; } = null!;
        public virtual DbSet<SekaiTopDatum> SekaiTopData { get; set; } = null!;
        public virtual DbSet<SekaiTopStoryDatum> SekaiTopStoryData { get; set; } = null!;
        public virtual DbSet<SekaiUnlockStoryCondition> SekaiUnlockStoryConditions { get; set; } = null!;
        public virtual DbSet<SerialCodeDatum> SerialCodeData { get; set; } = null!;
        public virtual DbSet<SerialGroupDatum> SerialGroupData { get; set; } = null!;
        public virtual DbSet<ShioriBattleMissionDatum> ShioriBattleMissionData { get; set; } = null!;
        public virtual DbSet<ShioriBoss> ShioriBosses { get; set; } = null!;
        public virtual DbSet<ShioriBossCondition> ShioriBossConditions { get; set; } = null!;
        public virtual DbSet<ShioriDescription> ShioriDescriptions { get; set; } = null!;
        public virtual DbSet<ShioriEnemyParameter> ShioriEnemyParameters { get; set; } = null!;
        public virtual DbSet<ShioriEventList> ShioriEventLists { get; set; } = null!;
        public virtual DbSet<ShioriItem> ShioriItems { get; set; } = null!;
        public virtual DbSet<ShioriMissionRewardDatum> ShioriMissionRewardData { get; set; } = null!;
        public virtual DbSet<ShioriQuest> ShioriQuests { get; set; } = null!;
        public virtual DbSet<ShioriQuestArea> ShioriQuestAreas { get; set; } = null!;
        public virtual DbSet<ShioriQuestCondition> ShioriQuestConditions { get; set; } = null!;
        public virtual DbSet<ShioriStationaryMissionDatum> ShioriStationaryMissionData { get; set; } = null!;
        public virtual DbSet<ShioriUnlockUnitCondition> ShioriUnlockUnitConditions { get; set; } = null!;
        public virtual DbSet<ShioriWaveGroupDatum> ShioriWaveGroupData { get; set; } = null!;
        public virtual DbSet<ShopStaticPriceGroup> ShopStaticPriceGroups { get; set; } = null!;
        public virtual DbSet<SkeStoryDatum> SkeStoryData { get; set; } = null!;
        public virtual DbSet<SkeStoryScript> SkeStoryScripts { get; set; } = null!;
        public virtual DbSet<SkillAction> SkillActions { get; set; } = null!;
        public virtual DbSet<SkillCost> SkillCosts { get; set; } = null!;
        public virtual DbSet<SkillDatum> SkillData { get; set; } = null!;
        public virtual DbSet<SkipBossDatum> SkipBossData { get; set; } = null!;
        public virtual DbSet<SkipMonsterDatum> SkipMonsterData { get; set; } = null!;
        public virtual DbSet<SpaceBattleDatum> SpaceBattleData { get; set; } = null!;
        public virtual DbSet<SpaceSchedule> SpaceSchedules { get; set; } = null!;
        public virtual DbSet<SpaceTopDatum> SpaceTopData { get; set; } = null!;
        public virtual DbSet<SpecialStill> SpecialStills { get; set; } = null!;
        public virtual DbSet<SpecialStoryBanner> SpecialStoryBanners { get; set; } = null!;
        public virtual DbSet<SpecialfesBanner> SpecialfesBanners { get; set; } = null!;
        public virtual DbSet<SpskillLabelDatum> SpskillLabelData { get; set; } = null!;
        public virtual DbSet<SpskillLvInitializeDatum> SpskillLvInitializeData { get; set; } = null!;
        public virtual DbSet<SrtAction> SrtActions { get; set; } = null!;
        public virtual DbSet<SrtPanel> SrtPanels { get; set; } = null!;
        public virtual DbSet<SrtReward> SrtRewards { get; set; } = null!;
        public virtual DbSet<SrtScore> SrtScores { get; set; } = null!;
        public virtual DbSet<SrtTopTalk> SrtTopTalks { get; set; } = null!;
        public virtual DbSet<SspStoryDatum> SspStoryData { get; set; } = null!;
        public virtual DbSet<Stamp> Stamps { get; set; } = null!;
        public virtual DbSet<StationaryMissionDatum> StationaryMissionData { get; set; } = null!;
        public virtual DbSet<Still> Stills { get; set; } = null!;
        public virtual DbSet<StoryCharacterMask> StoryCharacterMasks { get; set; } = null!;
        public virtual DbSet<StoryDatum> StoryData { get; set; } = null!;
        public virtual DbSet<StoryDetail> StoryDetails { get; set; } = null!;
        public virtual DbSet<StoryQuestDatum> StoryQuestData { get; set; } = null!;
        public virtual DbSet<TicketGachaDatum> TicketGachaData { get; set; } = null!;
        public virtual DbSet<Tip> Tips { get; set; } = null!;
        public virtual DbSet<TmeMapDatum> TmeMapData { get; set; } = null!;
        public virtual DbSet<TowerAreaDatum> TowerAreaData { get; set; } = null!;
        public virtual DbSet<TowerCloisterQuestDatum> TowerCloisterQuestData { get; set; } = null!;
        public virtual DbSet<TowerEnemyParameter> TowerEnemyParameters { get; set; } = null!;
        public virtual DbSet<TowerExQuestDatum> TowerExQuestData { get; set; } = null!;
        public virtual DbSet<TowerQuestDatum> TowerQuestData { get; set; } = null!;
        public virtual DbSet<TowerQuestFixRewardGroup> TowerQuestFixRewardGroups { get; set; } = null!;
        public virtual DbSet<TowerQuestOddsGroup> TowerQuestOddsGroups { get; set; } = null!;
        public virtual DbSet<TowerSchedule> TowerSchedules { get; set; } = null!;
        public virtual DbSet<TowerStoryDatum> TowerStoryData { get; set; } = null!;
        public virtual DbSet<TowerStoryDetail> TowerStoryDetails { get; set; } = null!;
        public virtual DbSet<TowerWaveGroupDatum> TowerWaveGroupData { get; set; } = null!;
        public virtual DbSet<TrainingQuestDatum> TrainingQuestData { get; set; } = null!;
        public virtual DbSet<TtkDrama> TtkDramas { get; set; } = null!;
        public virtual DbSet<TtkEnemy> TtkEnemies { get; set; } = null!;
        public virtual DbSet<TtkNaviComment> TtkNaviComments { get; set; } = null!;
        public virtual DbSet<TtkReward> TtkRewards { get; set; } = null!;
        public virtual DbSet<TtkScore> TtkScores { get; set; } = null!;
        public virtual DbSet<TtkStory> TtkStories { get; set; } = null!;
        public virtual DbSet<TtkStoryScript> TtkStoryScripts { get; set; } = null!;
        public virtual DbSet<TtkWeapon> TtkWeapons { get; set; } = null!;
        public virtual DbSet<UekBoss> UekBosses { get; set; } = null!;
        public virtual DbSet<UekDrama> UekDramas { get; set; } = null!;
        public virtual DbSet<UekMission> UekMissions { get; set; } = null!;
        public virtual DbSet<UekSpineAnimLink> UekSpineAnimLinks { get; set; } = null!;
        public virtual DbSet<UniqueEquipmentCraft> UniqueEquipmentCrafts { get; set; } = null!;
        public virtual DbSet<UniqueEquipmentDatum> UniqueEquipmentData { get; set; } = null!;
        public virtual DbSet<UniqueEquipmentEnhanceDatum> UniqueEquipmentEnhanceData { get; set; } = null!;
        public virtual DbSet<UniqueEquipmentEnhanceRate> UniqueEquipmentEnhanceRates { get; set; } = null!;
        public virtual DbSet<UniqueEquipmentRankup> UniqueEquipmentRankups { get; set; } = null!;
        public virtual DbSet<UnitAttackPattern> UnitAttackPatterns { get; set; } = null!;
        public virtual DbSet<UnitBackground> UnitBackgrounds { get; set; } = null!;
        public virtual DbSet<UnitComment> UnitComments { get; set; } = null!;
        public virtual DbSet<UnitDatum> UnitData { get; set; } = null!;
        public virtual DbSet<UnitEnemyDatum> UnitEnemyData { get; set; } = null!;
        public virtual DbSet<UnitIntroduction> UnitIntroductions { get; set; } = null!;
        public virtual DbSet<UnitMotionList> UnitMotionLists { get; set; } = null!;
        public virtual DbSet<UnitMypagePo> UnitMypagePos { get; set; } = null!;
        public virtual DbSet<UnitProfile> UnitProfiles { get; set; } = null!;
        public virtual DbSet<UnitPromotion> UnitPromotions { get; set; } = null!;
        public virtual DbSet<UnitPromotionStatus> UnitPromotionStatuses { get; set; } = null!;
        public virtual DbSet<UnitRarity> UnitRarities { get; set; } = null!;
        public virtual DbSet<UnitSkillDatum> UnitSkillData { get; set; } = null!;
        public virtual DbSet<UnitStatusCoefficient> UnitStatusCoefficients { get; set; } = null!;
        public virtual DbSet<UnitUniqueEquip> UnitUniqueEquips { get; set; } = null!;
        public virtual DbSet<UnlockRarity6> UnlockRarity6s { get; set; } = null!;
        public virtual DbSet<UnlockSkillDatum> UnlockSkillData { get; set; } = null!;
        public virtual DbSet<UnlockUnitCondition> UnlockUnitConditions { get; set; } = null!;
        public virtual DbSet<VisualCustomize> VisualCustomizes { get; set; } = null!;
        public virtual DbSet<VoiceGroup> VoiceGroups { get; set; } = null!;
        public virtual DbSet<VoiceGroupChara> VoiceGroupCharas { get; set; } = null!;
        public virtual DbSet<VoteDatum> VoteData { get; set; } = null!;
        public virtual DbSet<VoteInfo> VoteInfos { get; set; } = null!;
        public virtual DbSet<VoteUnit> VoteUnits { get; set; } = null!;
        public virtual DbSet<WaveGroupDatum> WaveGroupData { get; set; } = null!;
        public virtual DbSet<Worldmap> Worldmaps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(connectString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActualUnitBackground>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("actual_unit_background");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");
            });

            modelBuilder.Entity<AilmentDatum>(entity =>
            {
                entity.HasKey(e => e.AilmentId);

                entity.ToTable("ailment_data");

                entity.Property(e => e.AilmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("ailment_id");

                entity.Property(e => e.AilmentAction).HasColumnName("ailment_action");

                entity.Property(e => e.AilmentDetail1).HasColumnName("ailment_detail_1");

                entity.Property(e => e.AilmentName).HasColumnName("ailment_name");
            });

            modelBuilder.Entity<AlbumProductionList>(entity =>
            {
                entity.ToTable("album_production_list");

                entity.HasIndex(e => e.UnitId, "album_production_list_0_unit_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<AlbumVoiceList>(entity =>
            {
                entity.ToTable("album_voice_list");

                entity.HasIndex(e => e.UnitId, "album_voice_list_0_unit_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<ArcadeList>(entity =>
            {
                entity.HasKey(e => e.ArcadeId);

                entity.ToTable("arcade_list");

                entity.Property(e => e.ArcadeId)
                    .ValueGeneratedNever()
                    .HasColumnName("arcade_id");

                entity.Property(e => e.CueId).HasColumnName("cue_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<ArcadeStoryList>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("arcade_story_list");

                entity.HasIndex(e => e.ArcadeId, "arcade_story_list_0_arcade_id");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.ArcadeId).HasColumnName("arcade_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");
            });

            modelBuilder.Entity<ArenaDailyRankReward>(entity =>
            {
                entity.ToTable("arena_daily_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ArenaDefenceReward>(entity =>
            {
                entity.ToTable("arena_defence_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.LimitCount).HasColumnName("limit_count");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ArenaMaxRankReward>(entity =>
            {
                entity.ToTable("arena_max_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ArenaMaxSeasonRankReward>(entity =>
            {
                entity.ToTable("arena_max_season_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("banner");

                entity.Property(e => e.BannerId)
                    .ValueGeneratedNever()
                    .HasColumnName("banner_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.IsShowRoom).HasColumnName("is_show_room");

                entity.Property(e => e.PosterId).HasColumnName("poster_id");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ShowType).HasColumnName("show_type");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.SubBannerId1).HasColumnName("sub_banner_id_1");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<BgDatum>(entity =>
            {
                entity.HasKey(e => e.ViewName);

                entity.ToTable("bg_data");

                entity.Property(e => e.ViewName).HasColumnName("view_name");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");
            });

            modelBuilder.Entity<BirthdayLoginBonusDatum>(entity =>
            {
                entity.HasKey(e => e.LoginBonusId);

                entity.ToTable("birthday_login_bonus_data");

                entity.Property(e => e.LoginBonusId)
                    .ValueGeneratedNever()
                    .HasColumnName("login_bonus_id");

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LoginBonusType).HasColumnName("login_bonus_type");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<BirthdayLoginBonusDetail>(entity =>
            {
                entity.ToTable("birthday_login_bonus_detail");

                entity.HasIndex(e => e.LoginBonusId, "birthday_login_bonus_detail_0_login_bonus_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<BirthdayLoginBonusDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("birthday_login_bonus_drama_script");

                entity.HasIndex(e => e.DramaId, "birthday_login_bonus_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .ValueGeneratedNever()
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01).HasColumnName("param_01");

                entity.Property(e => e.Param02).HasColumnName("param_02");

                entity.Property(e => e.Param03).HasColumnName("param_03");

                entity.Property(e => e.Param04).HasColumnName("param_04");

                entity.Property(e => e.Param05).HasColumnName("param_05");

                entity.Property(e => e.Param06).HasColumnName("param_06");

                entity.Property(e => e.Param07).HasColumnName("param_07");

                entity.Property(e => e.Param08).HasColumnName("param_08");
            });

            modelBuilder.Entity<CampaignFreegacha>(entity =>
            {
                entity.ToTable("campaign_freegacha");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Freegacha1).HasColumnName("freegacha_1");

                entity.Property(e => e.Freegacha10).HasColumnName("freegacha_10");

                entity.Property(e => e.RelationCount).HasColumnName("relation_count");

                entity.Property(e => e.RelationId).HasColumnName("relation_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Stock10Flag).HasColumnName("stock_10_flag");
            });

            modelBuilder.Entity<CampaignFreegachaDatum>(entity =>
            {
                entity.ToTable("campaign_freegacha_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");
            });

            modelBuilder.Entity<CampaignFreegachaSp>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("campaign_freegacha_sp");

                entity.Property(e => e.CampaignId)
                    .ValueGeneratedNever()
                    .HasColumnName("campaign_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MaxExecCount).HasColumnName("max_exec_count");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<CampaignLevelDatum>(entity =>
            {
                entity.ToTable("campaign_level_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FrameColor).HasColumnName("frame_color");

                entity.Property(e => e.LabelColor).HasColumnName("label_color");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.LvFrom).HasColumnName("lv_from");

                entity.Property(e => e.LvTo).HasColumnName("lv_to");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<CampaignMissionCategory>(entity =>
            {
                entity.ToTable("campaign_mission_category");

                entity.HasIndex(e => new { e.CampaignId, e.Type }, "campaign_mission_category_0_campaign_id_1_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.LvFrom).HasColumnName("lv_from");

                entity.Property(e => e.LvTo).HasColumnName("lv_to");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CampaignMissionDatum>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("campaign_mission_data");

                entity.HasIndex(e => e.CampaignId, "campaign_mission_data_0_campaign_id");

                entity.HasIndex(e => new { e.CampaignId, e.Type }, "campaign_mission_data_0_campaign_id_1_type");

                entity.Property(e => e.MissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("mission_id");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.CampaignMissionRewardId).HasColumnName("campaign_mission_reward_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MarkFlag).HasColumnName("mark_flag");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TitleColorId).HasColumnName("title_color_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<CampaignMissionRewardDatum>(entity =>
            {
                entity.ToTable("campaign_mission_reward_data");

                entity.HasIndex(e => e.CampaignMissionRewardId, "campaign_mission_reward_data_0_campaign_mission_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CampaignMissionRewardId).HasColumnName("campaign_mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<CampaignMissionSchedule>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("campaign_mission_schedule");

                entity.Property(e => e.CampaignId)
                    .ValueGeneratedNever()
                    .HasColumnName("campaign_id");

                entity.Property(e => e.CloseTime).HasColumnName("close_time");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<CampaignSchedule>(entity =>
            {
                entity.ToTable("campaign_schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CampaignCategory).HasColumnName("campaign_category");

                entity.Property(e => e.DuplicationOrder).HasColumnName("duplication_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.IconImage).HasColumnName("icon_image");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.ShioriGroupId).HasColumnName("shiori_group_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<CampaignShioriGroup>(entity =>
            {
                entity.ToTable("campaign_shiori_group");

                entity.HasIndex(e => e.ShioriGroupId, "campaign_shiori_group_0_shiori_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ShioriGroupId).HasColumnName("shiori_group_id");
            });

            modelBuilder.Entity<CharaETicketDatum>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.ToTable("chara_e_ticket_data");

                entity.HasIndex(e => e.JewelStoreId, "chara_e_ticket_data_0_jewel_store_id")
                    .IsUnique();

                entity.Property(e => e.TicketId)
                    .ValueGeneratedNever()
                    .HasColumnName("ticket_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.JewelStoreId).HasColumnName("jewel_store_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<CharaFortuneRail>(entity =>
            {
                entity.HasKey(e => e.RailId);

                entity.ToTable("chara_fortune_rail");

                entity.Property(e => e.RailId)
                    .ValueGeneratedNever()
                    .HasColumnName("rail_id");

                entity.Property(e => e.Gimmick10Id).HasColumnName("gimmick_10_id");

                entity.Property(e => e.Gimmick10X).HasColumnName("gimmick_10_x");

                entity.Property(e => e.Gimmick1Id).HasColumnName("gimmick_1_id");

                entity.Property(e => e.Gimmick1X).HasColumnName("gimmick_1_x");

                entity.Property(e => e.Gimmick2Id).HasColumnName("gimmick_2_id");

                entity.Property(e => e.Gimmick2X).HasColumnName("gimmick_2_x");

                entity.Property(e => e.Gimmick3Id).HasColumnName("gimmick_3_id");

                entity.Property(e => e.Gimmick3X).HasColumnName("gimmick_3_x");

                entity.Property(e => e.Gimmick4Id).HasColumnName("gimmick_4_id");

                entity.Property(e => e.Gimmick4X).HasColumnName("gimmick_4_x");

                entity.Property(e => e.Gimmick5Id).HasColumnName("gimmick_5_id");

                entity.Property(e => e.Gimmick5X).HasColumnName("gimmick_5_x");

                entity.Property(e => e.Gimmick6Id).HasColumnName("gimmick_6_id");

                entity.Property(e => e.Gimmick6X).HasColumnName("gimmick_6_x");

                entity.Property(e => e.Gimmick7Id).HasColumnName("gimmick_7_id");

                entity.Property(e => e.Gimmick7X).HasColumnName("gimmick_7_x");

                entity.Property(e => e.Gimmick8Id).HasColumnName("gimmick_8_id");

                entity.Property(e => e.Gimmick8X).HasColumnName("gimmick_8_x");

                entity.Property(e => e.Gimmick9Id).HasColumnName("gimmick_9_id");

                entity.Property(e => e.Gimmick9X).HasColumnName("gimmick_9_x");
            });

            modelBuilder.Entity<CharaFortuneReward>(entity =>
            {
                entity.ToTable("chara_fortune_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Count1).HasColumnName("count_1");

                entity.Property(e => e.Count2).HasColumnName("count_2");

                entity.Property(e => e.Count3).HasColumnName("count_3");

                entity.Property(e => e.Count4).HasColumnName("count_4");

                entity.Property(e => e.Count5).HasColumnName("count_5");

                entity.Property(e => e.FortuneId).HasColumnName("fortune_id");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<CharaFortuneScenario>(entity =>
            {
                entity.HasKey(e => e.ScenarioId);

                entity.ToTable("chara_fortune_scenario");

                entity.Property(e => e.ScenarioId)
                    .ValueGeneratedNever()
                    .HasColumnName("scenario_id");

                entity.Property(e => e.Rail1).HasColumnName("rail_1");

                entity.Property(e => e.Rail2).HasColumnName("rail_2");

                entity.Property(e => e.Rail3).HasColumnName("rail_3");

                entity.Property(e => e.Rail4).HasColumnName("rail_4");
            });

            modelBuilder.Entity<CharaFortuneSchedule>(entity =>
            {
                entity.HasKey(e => e.FortuneId);

                entity.ToTable("chara_fortune_schedule");

                entity.Property(e => e.FortuneId)
                    .ValueGeneratedNever()
                    .HasColumnName("fortune_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<CharaIdentity>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("chara_identity");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.CharaType).HasColumnName("chara_type");
            });

            modelBuilder.Entity<CharaStoryStatus>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("chara_story_status");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.CharaId1).HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId10).HasColumnName("chara_id_10");

                entity.Property(e => e.CharaId2).HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3).HasColumnName("chara_id_3");

                entity.Property(e => e.CharaId4).HasColumnName("chara_id_4");

                entity.Property(e => e.CharaId5).HasColumnName("chara_id_5");

                entity.Property(e => e.CharaId6).HasColumnName("chara_id_6");

                entity.Property(e => e.CharaId7).HasColumnName("chara_id_7");

                entity.Property(e => e.CharaId8).HasColumnName("chara_id_8");

                entity.Property(e => e.CharaId9).HasColumnName("chara_id_9");

                entity.Property(e => e.StatusRate1).HasColumnName("status_rate_1");

                entity.Property(e => e.StatusRate2).HasColumnName("status_rate_2");

                entity.Property(e => e.StatusRate3).HasColumnName("status_rate_3");

                entity.Property(e => e.StatusRate4).HasColumnName("status_rate_4");

                entity.Property(e => e.StatusRate5).HasColumnName("status_rate_5");

                entity.Property(e => e.StatusType1).HasColumnName("status_type_1");

                entity.Property(e => e.StatusType2).HasColumnName("status_type_2");

                entity.Property(e => e.StatusType3).HasColumnName("status_type_3");

                entity.Property(e => e.StatusType4).HasColumnName("status_type_4");

                entity.Property(e => e.StatusType5).HasColumnName("status_type_5");

                entity.Property(e => e.UnlockStoryName).HasColumnName("unlock_story_name");
            });

            modelBuilder.Entity<CharacterLoveRankupText>(entity =>
            {
                entity.HasKey(e => e.CharaId);

                entity.ToTable("character_love_rankup_text");

                entity.Property(e => e.CharaId)
                    .ValueGeneratedNever()
                    .HasColumnName("chara_id");

                entity.Property(e => e.Face1).HasColumnName("face_1");

                entity.Property(e => e.Face2).HasColumnName("face_2");

                entity.Property(e => e.Face3).HasColumnName("face_3");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.Scale).HasColumnName("scale");

                entity.Property(e => e.Serif1).HasColumnName("serif_1");

                entity.Property(e => e.Serif2).HasColumnName("serif_2");

                entity.Property(e => e.Serif3).HasColumnName("serif_3");

                entity.Property(e => e.VoiceId1).HasColumnName("voice_id_1");

                entity.Property(e => e.VoiceId2).HasColumnName("voice_id_2");

                entity.Property(e => e.VoiceId3).HasColumnName("voice_id_3");
            });

            modelBuilder.Entity<ClanBattle2BossDatum>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("clan_battle_2_boss_data");

                entity.Property(e => e.BossId)
                    .ValueGeneratedNever()
                    .HasColumnName("boss_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleReportMonsterHeight).HasColumnName("battle_report_monster_height");

                entity.Property(e => e.BattleReportMonsterSize).HasColumnName("battle_report_monster_size");

                entity.Property(e => e.BossThumbId).HasColumnName("boss_thumb_id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.CursorPosition).HasColumnName("cursor_position");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestDetailMonsterHeight).HasColumnName("quest_detail_monster_height");

                entity.Property(e => e.QuestDetailMonsterSize).HasColumnName("quest_detail_monster_size");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.ScaleRatio).HasColumnName("scale_ratio");

                entity.Property(e => e.TapHeightRatio).HasColumnName("tap_height_ratio");

                entity.Property(e => e.TapWidthRatio).HasColumnName("tap_width_ratio");

                entity.Property(e => e.WaveBgm).HasColumnName("wave_bgm");
            });

            modelBuilder.Entity<ClanBattle2MapDatum>(entity =>
            {
                entity.ToTable("clan_battle_2_map_data");

                entity.HasIndex(e => e.ClanBattleId, "clan_battle_2_map_data_0_clan_battle_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AuraEffect).HasColumnName("aura_effect");

                entity.Property(e => e.BossId1).HasColumnName("boss_id_1");

                entity.Property(e => e.BossId2).HasColumnName("boss_id_2");

                entity.Property(e => e.BossId3).HasColumnName("boss_id_3");

                entity.Property(e => e.BossId4).HasColumnName("boss_id_4");

                entity.Property(e => e.BossId5).HasColumnName("boss_id_5");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.DamageRankId1).HasColumnName("damage_rank_id_1");

                entity.Property(e => e.DamageRankId2).HasColumnName("damage_rank_id_2");

                entity.Property(e => e.DamageRankId3).HasColumnName("damage_rank_id_3");

                entity.Property(e => e.DamageRankId4).HasColumnName("damage_rank_id_4");

                entity.Property(e => e.DamageRankId5).HasColumnName("damage_rank_id_5");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.FixRewardId1).HasColumnName("fix_reward_id_1");

                entity.Property(e => e.FixRewardId2).HasColumnName("fix_reward_id_2");

                entity.Property(e => e.FixRewardId3).HasColumnName("fix_reward_id_3");

                entity.Property(e => e.FixRewardId4).HasColumnName("fix_reward_id_4");

                entity.Property(e => e.FixRewardId5).HasColumnName("fix_reward_id_5");

                entity.Property(e => e.LapNumFrom).HasColumnName("lap_num_from");

                entity.Property(e => e.LapNumTo).HasColumnName("lap_num_to");

                entity.Property(e => e.LastAttackRewardId).HasColumnName("last_attack_reward_id");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.MapBg).HasColumnName("map_bg");

                entity.Property(e => e.ParamAdjustId).HasColumnName("param_adjust_id");

                entity.Property(e => e.ParamAdjustInterval).HasColumnName("param_adjust_interval");

                entity.Property(e => e.Phase).HasColumnName("phase");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RslUnlockLap).HasColumnName("rsl_unlock_lap");

                entity.Property(e => e.ScoreCoefficient1).HasColumnName("score_coefficient_1");

                entity.Property(e => e.ScoreCoefficient2).HasColumnName("score_coefficient_2");

                entity.Property(e => e.ScoreCoefficient3).HasColumnName("score_coefficient_3");

                entity.Property(e => e.ScoreCoefficient4).HasColumnName("score_coefficient_4");

                entity.Property(e => e.ScoreCoefficient5).HasColumnName("score_coefficient_5");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");

                entity.Property(e => e.WaveGroupId4).HasColumnName("wave_group_id_4");

                entity.Property(e => e.WaveGroupId5).HasColumnName("wave_group_id_5");
            });

            modelBuilder.Entity<ClanBattleBattleMissionDatum>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("clan_battle_battle_mission_data");

                entity.Property(e => e.MissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ClanBattleBossDamageRank>(entity =>
            {
                entity.HasKey(e => new { e.DamageRankId, e.RankingFrom, e.RankingTo });

                entity.ToTable("clan_battle_boss_damage_rank");

                entity.HasIndex(e => e.DamageRankId, "clan_battle_boss_damage_rank_0_damage_rank_id");

                entity.Property(e => e.DamageRankId).HasColumnName("damage_rank_id");

                entity.Property(e => e.RankingFrom).HasColumnName("ranking_from");

                entity.Property(e => e.RankingTo).HasColumnName("ranking_to");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleBossFixReward>(entity =>
            {
                entity.HasKey(e => e.FixRewardId);

                entity.ToTable("clan_battle_boss_fix_reward");

                entity.Property(e => e.FixRewardId)
                    .ValueGeneratedNever()
                    .HasColumnName("fix_reward_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleLastAttackReward>(entity =>
            {
                entity.HasKey(e => e.LastAttackRewardId);

                entity.ToTable("clan_battle_last_attack_reward");

                entity.Property(e => e.LastAttackRewardId)
                    .ValueGeneratedNever()
                    .HasColumnName("last_attack_reward_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleOddsDatum>(entity =>
            {
                entity.HasKey(e => new { e.OddsGroupId, e.TeamLevelFrom, e.TeamLevelTo });

                entity.ToTable("clan_battle_odds_data");

                entity.HasIndex(e => e.OddsGroupId, "clan_battle_odds_data_0_odds_group_id");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");

                entity.Property(e => e.OddsCsv1).HasColumnName("odds_csv_1");

                entity.Property(e => e.OddsCsv10).HasColumnName("odds_csv_10");

                entity.Property(e => e.OddsCsv2).HasColumnName("odds_csv_2");

                entity.Property(e => e.OddsCsv3).HasColumnName("odds_csv_3");

                entity.Property(e => e.OddsCsv4).HasColumnName("odds_csv_4");

                entity.Property(e => e.OddsCsv5).HasColumnName("odds_csv_5");

                entity.Property(e => e.OddsCsv6).HasColumnName("odds_csv_6");

                entity.Property(e => e.OddsCsv7).HasColumnName("odds_csv_7");

                entity.Property(e => e.OddsCsv8).HasColumnName("odds_csv_8");

                entity.Property(e => e.OddsCsv9).HasColumnName("odds_csv_9");
            });

            modelBuilder.Entity<ClanBattleParamAdjust>(entity =>
            {
                entity.HasKey(e => e.ParamAdjustId);

                entity.ToTable("clan_battle_param_adjust");

                entity.Property(e => e.ParamAdjustId)
                    .ValueGeneratedNever()
                    .HasColumnName("param_adjust_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.ScoreCoefficient).HasColumnName("score_coefficient");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");
            });

            modelBuilder.Entity<ClanBattlePeriod>(entity =>
            {
                entity.HasKey(e => new { e.ClanBattleId, e.Period });

                entity.ToTable("clan_battle_period");

                entity.HasIndex(e => e.ClanBattleId, "clan_battle_period_0_clan_battle_id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.CalcStart).HasColumnName("calc_start");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.IntervalEnd).HasColumnName("interval_end");

                entity.Property(e => e.IntervalStart).HasColumnName("interval_start");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MinCarryOverTime).HasColumnName("min_carry_over_time");

                entity.Property(e => e.PeriodDetail).HasColumnName("period_detail");

                entity.Property(e => e.PeriodDetailBg).HasColumnName("period_detail_bg");

                entity.Property(e => e.PeriodDetailBgPosition).HasColumnName("period_detail_bg_position");

                entity.Property(e => e.PeriodDetailBgS).HasColumnName("period_detail_bg_s");

                entity.Property(e => e.PeriodDetailBossPositionX).HasColumnName("period_detail_boss_position_x");

                entity.Property(e => e.PeriodDetailBossPositionY).HasColumnName("period_detail_boss_position_y");

                entity.Property(e => e.PeriodDetailS).HasColumnName("period_detail_s");

                entity.Property(e => e.QuestDetailRehearsalLabelHeight).HasColumnName("quest_detail_rehearsal_label_height");

                entity.Property(e => e.ResultEnd).HasColumnName("result_end");

                entity.Property(e => e.ResultStart).HasColumnName("result_start");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<ClanBattlePeriodLapReward>(entity =>
            {
                entity.ToTable("clan_battle_period_lap_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.LapNumFrom).HasColumnName("lap_num_from");

                entity.Property(e => e.LapNumTo).HasColumnName("lap_num_to");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.RankingBonusGroup).HasColumnName("ranking_bonus_group");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattlePeriodRankReward>(entity =>
            {
                entity.ToTable("clan_battle_period_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RankingBonusGroup).HasColumnName("ranking_bonus_group");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleRecommendDatum>(entity =>
            {
                entity.HasKey(e => e.LevelId);

                entity.ToTable("clan_battle_recommend_data");

                entity.HasIndex(e => e.RecommendGroup, "clan_battle_recommend_data_0_recommend_group");

                entity.Property(e => e.LevelId)
                    .ValueGeneratedNever()
                    .HasColumnName("level_id");

                entity.Property(e => e.AtackPartyCount).HasColumnName("atack_party_count");

                entity.Property(e => e.LevelFrom).HasColumnName("level_from");

                entity.Property(e => e.LevelTo).HasColumnName("level_to");

                entity.Property(e => e.MagicPartyCount).HasColumnName("magic_party_count");

                entity.Property(e => e.RecommendGroup).HasColumnName("recommend_group");
            });

            modelBuilder.Entity<ClanBattleSBossDatum>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("clan_battle_s_boss_data");

                entity.Property(e => e.BossId)
                    .ValueGeneratedNever()
                    .HasColumnName("boss_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleReportMonsterHeight).HasColumnName("battle_report_monster_height");

                entity.Property(e => e.BattleReportMonsterSize).HasColumnName("battle_report_monster_size");

                entity.Property(e => e.BossThumbId).HasColumnName("boss_thumb_id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.CursorPosition).HasColumnName("cursor_position");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestDetailMonsterHeight).HasColumnName("quest_detail_monster_height");

                entity.Property(e => e.QuestDetailMonsterSize).HasColumnName("quest_detail_monster_size");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.ScaleRatio).HasColumnName("scale_ratio");

                entity.Property(e => e.TapHeightRatio).HasColumnName("tap_height_ratio");

                entity.Property(e => e.TapWidthRatio).HasColumnName("tap_width_ratio");

                entity.Property(e => e.WaveBgm).HasColumnName("wave_bgm");
            });

            modelBuilder.Entity<ClanBattleSBossFixReward>(entity =>
            {
                entity.HasKey(e => e.FixRewardId);

                entity.ToTable("clan_battle_s_boss_fix_reward");

                entity.Property(e => e.FixRewardId)
                    .ValueGeneratedNever()
                    .HasColumnName("fix_reward_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleSMapDatum>(entity =>
            {
                entity.ToTable("clan_battle_s_map_data");

                entity.HasIndex(e => e.ClanBattleId, "clan_battle_s_map_data_0_clan_battle_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AuraEffect).HasColumnName("aura_effect");

                entity.Property(e => e.BossId1).HasColumnName("boss_id_1");

                entity.Property(e => e.BossId2).HasColumnName("boss_id_2");

                entity.Property(e => e.BossId3).HasColumnName("boss_id_3");

                entity.Property(e => e.BossId4).HasColumnName("boss_id_4");

                entity.Property(e => e.BossId5).HasColumnName("boss_id_5");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.DamageRankId1).HasColumnName("damage_rank_id_1");

                entity.Property(e => e.DamageRankId2).HasColumnName("damage_rank_id_2");

                entity.Property(e => e.DamageRankId3).HasColumnName("damage_rank_id_3");

                entity.Property(e => e.DamageRankId4).HasColumnName("damage_rank_id_4");

                entity.Property(e => e.DamageRankId5).HasColumnName("damage_rank_id_5");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.ExtraBattleFlag1).HasColumnName("extra_battle_flag1");

                entity.Property(e => e.ExtraBattleFlag2).HasColumnName("extra_battle_flag2");

                entity.Property(e => e.ExtraBattleFlag3).HasColumnName("extra_battle_flag3");

                entity.Property(e => e.ExtraBattleFlag4).HasColumnName("extra_battle_flag4");

                entity.Property(e => e.ExtraBattleFlag5).HasColumnName("extra_battle_flag5");

                entity.Property(e => e.FixRewardId1).HasColumnName("fix_reward_id_1");

                entity.Property(e => e.FixRewardId2).HasColumnName("fix_reward_id_2");

                entity.Property(e => e.FixRewardId3).HasColumnName("fix_reward_id_3");

                entity.Property(e => e.FixRewardId4).HasColumnName("fix_reward_id_4");

                entity.Property(e => e.FixRewardId5).HasColumnName("fix_reward_id_5");

                entity.Property(e => e.LapNumFrom).HasColumnName("lap_num_from");

                entity.Property(e => e.LapNumTo).HasColumnName("lap_num_to");

                entity.Property(e => e.LastAttackRewardId).HasColumnName("last_attack_reward_id");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.MapBg).HasColumnName("map_bg");

                entity.Property(e => e.ParamAdjustId).HasColumnName("param_adjust_id");

                entity.Property(e => e.ParamAdjustInterval).HasColumnName("param_adjust_interval");

                entity.Property(e => e.Phase).HasColumnName("phase");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RslUnlockLap).HasColumnName("rsl_unlock_lap");

                entity.Property(e => e.ScoreCoefficient1).HasColumnName("score_coefficient_1");

                entity.Property(e => e.ScoreCoefficient2).HasColumnName("score_coefficient_2");

                entity.Property(e => e.ScoreCoefficient3).HasColumnName("score_coefficient_3");

                entity.Property(e => e.ScoreCoefficient4).HasColumnName("score_coefficient_4");

                entity.Property(e => e.ScoreCoefficient5).HasColumnName("score_coefficient_5");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");

                entity.Property(e => e.WaveGroupId4).HasColumnName("wave_group_id_4");

                entity.Property(e => e.WaveGroupId5).HasColumnName("wave_group_id_5");
            });

            modelBuilder.Entity<ClanBattleSParamAdjust>(entity =>
            {
                entity.HasKey(e => e.ParamAdjustId);

                entity.ToTable("clan_battle_s_param_adjust");

                entity.Property(e => e.ParamAdjustId)
                    .ValueGeneratedNever()
                    .HasColumnName("param_adjust_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.ScoreCoefficient).HasColumnName("score_coefficient");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");
            });

            modelBuilder.Entity<ClanBattleSchedule>(entity =>
            {
                entity.HasKey(e => e.ClanBattleId);

                entity.ToTable("clan_battle_schedule");

                entity.Property(e => e.ClanBattleId)
                    .ValueGeneratedNever()
                    .HasColumnName("clan_battle_id");

                entity.Property(e => e.CostGroupId).HasColumnName("cost_group_id");

                entity.Property(e => e.CostGroupIdS).HasColumnName("cost_group_id_s");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LastClanBattleId).HasColumnName("last_clan_battle_id");

                entity.Property(e => e.MapBgm).HasColumnName("map_bgm");

                entity.Property(e => e.PointPerStamina).HasColumnName("point_per_stamina");

                entity.Property(e => e.ReleaseMonth).HasColumnName("release_month");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<ClanBattleTrainingDatum>(entity =>
            {
                entity.ToTable("clan_battle_training_data");

                entity.HasIndex(e => e.TrainingId, "clan_battle_training_data_0_training_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MapDataId).HasColumnName("map_data_id");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Phase).HasColumnName("phase");

                entity.Property(e => e.TrainingId).HasColumnName("training_id");
            });

            modelBuilder.Entity<ClanBattleTrainingSchedule>(entity =>
            {
                entity.HasKey(e => e.TrainingId);

                entity.ToTable("clan_battle_training_schedule");

                entity.HasIndex(e => e.ClanBattleId, "clan_battle_training_schedule_0_clan_battle_id");

                entity.Property(e => e.TrainingId)
                    .ValueGeneratedNever()
                    .HasColumnName("training_id");

                entity.Property(e => e.BattleEndTime).HasColumnName("battle_end_time");

                entity.Property(e => e.BattleStartTime).HasColumnName("battle_start_time");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.IntervalEndTime).HasColumnName("interval_end_time");

                entity.Property(e => e.IntervalStartTime).HasColumnName("interval_start_time");
            });

            modelBuilder.Entity<ClanCostGroup>(entity =>
            {
                entity.ToTable("clan_cost_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CostGroupId).HasColumnName("cost_group_id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            });

            modelBuilder.Entity<ClanGrade>(entity =>
            {
                entity.ToTable("clan_grade");

                entity.Property(e => e.ClanGradeId)
                    .ValueGeneratedNever()
                    .HasColumnName("clan_grade_id");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");
            });

            modelBuilder.Entity<ClanInviteLevelGroup>(entity =>
            {
                entity.HasKey(e => e.LevelGroupId);

                entity.ToTable("clan_invite_level_group");

                entity.Property(e => e.LevelGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("level_group_id");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");
            });

            modelBuilder.Entity<ClanprofileContent>(entity =>
            {
                entity.ToTable("clanprofile_content");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<CombinedResultMotion>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.ToTable("combined_result_motion");

                entity.Property(e => e.ResultId)
                    .ValueGeneratedNever()
                    .HasColumnName("result_id");

                entity.Property(e => e.DispOrder1).HasColumnName("disp_order_1");

                entity.Property(e => e.DispOrder2).HasColumnName("disp_order_2");

                entity.Property(e => e.DispOrder3).HasColumnName("disp_order_3");

                entity.Property(e => e.DispOrder4).HasColumnName("disp_order_4");

                entity.Property(e => e.DispOrder5).HasColumnName("disp_order_5");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id_1");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id_2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id_3");

                entity.Property(e => e.UnitId4).HasColumnName("unit_id_4");

                entity.Property(e => e.UnitId5).HasColumnName("unit_id_5");
            });

            modelBuilder.Entity<ContentMapDatum>(entity =>
            {
                entity.HasKey(e => e.ContentMapId);

                entity.ToTable("content_map_data");

                entity.Property(e => e.ContentMapId)
                    .ValueGeneratedNever()
                    .HasColumnName("content_map_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.QuestPositionX).HasColumnName("quest_position_x");

                entity.Property(e => e.QuestPositionY).HasColumnName("quest_position_y");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ContentReleaseDatum>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.ToTable("content_release_data");

                entity.Property(e => e.SystemId)
                    .ValueGeneratedNever()
                    .HasColumnName("system_id");

                entity.Property(e => e.Dialog).HasColumnName("dialog");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TeamLevel).HasColumnName("team_level");
            });

            modelBuilder.Entity<CooperationQuestDatum>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("cooperation_quest_data");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroupId).HasColumnName("clear_reward_group_id");

                entity.Property(e => e.CooperationQuestDetailBgId).HasColumnName("cooperation_quest_detail_bg_id");

                entity.Property(e => e.CooperationQuestDetailBgPosition).HasColumnName("cooperation_quest_detail_bg_position");

                entity.Property(e => e.DifficultyLevel).HasColumnName("difficulty_level");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.Exp).HasColumnName("exp");

                entity.Property(e => e.FirstRewardImage1).HasColumnName("first_reward_image_1");

                entity.Property(e => e.FirstRewardImage2).HasColumnName("first_reward_image_2");

                entity.Property(e => e.FirstRewardImage3).HasColumnName("first_reward_image_3");

                entity.Property(e => e.FirstRewardImage4).HasColumnName("first_reward_image_4");

                entity.Property(e => e.FirstRewardImage5).HasColumnName("first_reward_image_5");

                entity.Property(e => e.LimitTeamLevel).HasColumnName("limit_team_level");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.LobbyBackground).HasColumnName("lobby_background");

                entity.Property(e => e.MainEnemyImageWave1).HasColumnName("main_enemy_image_wave_1");

                entity.Property(e => e.MainEnemyImageWave2).HasColumnName("main_enemy_image_wave_2");

                entity.Property(e => e.MainEnemyImageWave3).HasColumnName("main_enemy_image_wave_3");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.QuestComment).HasColumnName("quest_comment");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.RepeatRewardImage1).HasColumnName("repeat_reward_image_1");

                entity.Property(e => e.RepeatRewardImage2).HasColumnName("repeat_reward_image_2");

                entity.Property(e => e.RepeatRewardImage3).HasColumnName("repeat_reward_image_3");

                entity.Property(e => e.SubEnemyImageWave11).HasColumnName("sub_enemy_image_wave_1_1");

                entity.Property(e => e.SubEnemyImageWave12).HasColumnName("sub_enemy_image_wave_1_2");

                entity.Property(e => e.SubEnemyImageWave13).HasColumnName("sub_enemy_image_wave_1_3");

                entity.Property(e => e.SubEnemyImageWave14).HasColumnName("sub_enemy_image_wave_1_4");

                entity.Property(e => e.SubEnemyImageWave21).HasColumnName("sub_enemy_image_wave_2_1");

                entity.Property(e => e.SubEnemyImageWave22).HasColumnName("sub_enemy_image_wave_2_2");

                entity.Property(e => e.SubEnemyImageWave23).HasColumnName("sub_enemy_image_wave_2_3");

                entity.Property(e => e.SubEnemyImageWave24).HasColumnName("sub_enemy_image_wave_2_4");

                entity.Property(e => e.SubEnemyImageWave31).HasColumnName("sub_enemy_image_wave_3_1");

                entity.Property(e => e.SubEnemyImageWave32).HasColumnName("sub_enemy_image_wave_3_2");

                entity.Property(e => e.SubEnemyImageWave33).HasColumnName("sub_enemy_image_wave_3_3");

                entity.Property(e => e.SubEnemyImageWave34).HasColumnName("sub_enemy_image_wave_3_4");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnlockQuestId1).HasColumnName("unlock_quest_id_1");

                entity.Property(e => e.UnlockQuestId2).HasColumnName("unlock_quest_id_2");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2).HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3).HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2).HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3).HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<CustomMypage>(entity =>
            {
                entity.HasKey(e => e.StillId);

                entity.ToTable("custom_mypage");

                entity.HasIndex(e => e.StillGroupId, "custom_mypage_0_still_group_id");

                entity.Property(e => e.StillId)
                    .ValueGeneratedNever()
                    .HasColumnName("still_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ScrollDirection).HasColumnName("scroll_direction");

                entity.Property(e => e.StillGroupId).HasColumnName("still_group_id");

                entity.Property(e => e.StillName).HasColumnName("still_name");

                entity.Property(e => e.VerticalStillFlg).HasColumnName("vertical_still_flg");
            });

            modelBuilder.Entity<CustomMypageGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("custom_mypage_group");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("group_id");

                entity.Property(e => e.GroupName).HasColumnName("group_name");
            });

            modelBuilder.Entity<DailyMissionDatum>(entity =>
            {
                entity.HasKey(e => e.DailyMissionId);

                entity.ToTable("daily_mission_data");

                entity.Property(e => e.DailyMissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("daily_mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TitleColorId).HasColumnName("title_color_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<DearChara>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.CharaIndex });

                entity.ToTable("dear_chara");

                entity.HasIndex(e => e.EventId, "dear_chara_0_event_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.CharaName).HasColumnName("chara_name");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.DearPointUpOffsetX).HasColumnName("dear_point_up_offset_x");

                entity.Property(e => e.DearPointUpOffsetY).HasColumnName("dear_point_up_offset_y");

                entity.Property(e => e.EpisodeUnlockOffsetX).HasColumnName("episode_unlock_offset_x");

                entity.Property(e => e.EpisodeUnlockOffsetY).HasColumnName("episode_unlock_offset_y");

                entity.Property(e => e.MaxDearPoint).HasColumnName("max_dear_point");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.ReferenceType).HasColumnName("reference_type");
            });

            modelBuilder.Entity<DearReward>(entity =>
            {
                entity.ToTable("dear_reward");

                entity.HasIndex(e => new { e.EventId, e.CharaIndex }, "dear_reward_0_event_id_1_chara_index");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.DearPoint).HasColumnName("dear_point");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionDetail).HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<DearSetting>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("dear_setting");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_id");

                entity.Property(e => e.SystemName).HasColumnName("system_name");

                entity.Property(e => e.TutorialCharaIndex).HasColumnName("tutorial_chara_index");

                entity.Property(e => e.TutorialQuestId).HasColumnName("tutorial_quest_id");

                entity.Property(e => e.TutorialStoryId).HasColumnName("tutorial_story_id");
            });

            modelBuilder.Entity<DearStoryDatum>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("dear_story_data");

                entity.HasIndex(e => e.Value, "dear_story_data_0_value");

                entity.Property(e => e.StoryGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_group_id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<DearStoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("dear_story_detail");

                entity.HasIndex(e => e.StoryGroupId, "dear_story_detail_0_story_group_id");

                entity.HasIndex(e => new { e.StoryGroupId, e.CharaIndex }, "dear_story_detail_0_story_group_id_1_chara_index");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.ConditionEventBossId).HasColumnName("condition_event_boss_id");

                entity.Property(e => e.ConditionEventQuestId).HasColumnName("condition_event_quest_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<DefineSpskill>(entity =>
            {
                entity.HasKey(e => e.LinkSkillSlot);

                entity.ToTable("define_spskill");

                entity.HasIndex(e => e.SpSkillId, "define_spskill_0_sp_skill_id")
                    .IsUnique();

                entity.Property(e => e.LinkSkillSlot)
                    .ValueGeneratedNever()
                    .HasColumnName("link_skill_slot");

                entity.Property(e => e.BaseSkillId).HasColumnName("base_skill_id");

                entity.Property(e => e.SkillCategory).HasColumnName("skill_category");

                entity.Property(e => e.SpSkillId).HasColumnName("sp_skill_id");
            });

            modelBuilder.Entity<DodgeTpRecovery>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.ToTable("dodge_tp_recovery");

                entity.Property(e => e.SystemId)
                    .ValueGeneratedNever()
                    .HasColumnName("system_id");

                entity.Property(e => e.RecoveryRatio).HasColumnName("recovery_ratio");
            });

            modelBuilder.Entity<DungeonAreaDatum>(entity =>
            {
                entity.HasKey(e => e.DungeonAreaId);

                entity.ToTable("dungeon_area_data");

                entity.Property(e => e.DungeonAreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("dungeon_area_id");

                entity.Property(e => e.CoinItemId).HasColumnName("coin_item_id");

                entity.Property(e => e.ContentReleaseStory).HasColumnName("content_release_story");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DungeonName).HasColumnName("dungeon_name");

                entity.Property(e => e.DungeonType).HasColumnName("dungeon_type");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.InitialClearStory).HasColumnName("initial_clear_story");

                entity.Property(e => e.OpenQuestId).HasColumnName("open_quest_id");

                entity.Property(e => e.QuestPositionX).HasColumnName("quest_position_x");

                entity.Property(e => e.QuestPositionY).HasColumnName("quest_position_y");

                entity.Property(e => e.RecommendLevel).HasColumnName("recommend_level");

                entity.Property(e => e.RecoveryHpRate).HasColumnName("recovery_hp_rate");

                entity.Property(e => e.RecoveryTpRate).HasColumnName("recovery_tp_rate");

                entity.Property(e => e.RewardGroupId).HasColumnName("reward_group_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.ViewRewardId1).HasColumnName("view_reward_id_1");

                entity.Property(e => e.ViewRewardId2).HasColumnName("view_reward_id_2");

                entity.Property(e => e.ViewRewardId3).HasColumnName("view_reward_id_3");

                entity.Property(e => e.ViewRewardId4).HasColumnName("view_reward_id_4");

                entity.Property(e => e.ViewRewardId5).HasColumnName("view_reward_id_5");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<DungeonQuestDatum>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("dungeon_quest_data");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.DungeonAreaId).HasColumnName("dungeon_area_id");

                entity.Property(e => e.DungeonQuestDetailBgId).HasColumnName("dungeon_quest_detail_bg_id");

                entity.Property(e => e.DungeonQuestDetailBgPosition).HasColumnName("dungeon_quest_detail_bg_position");

                entity.Property(e => e.DungeonQuestDetailMonsterHeight).HasColumnName("dungeon_quest_detail_monster_height");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX1).HasColumnName("dungeon_quest_detail_monster_position_x_1");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX2).HasColumnName("dungeon_quest_detail_monster_position_x_2");

                entity.Property(e => e.DungeonQuestDetailMonsterSize).HasColumnName("dungeon_quest_detail_monster_size");

                entity.Property(e => e.EnergyResetFlag).HasColumnName("energy_reset_flag");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MatchingCoefficient).HasColumnName("matching_coefficient");

                entity.Property(e => e.MultiTargetEffectTime).HasColumnName("multi_target_effect_time");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.PartsHpSaveFlag).HasColumnName("parts_hp_save_flag");

                entity.Property(e => e.RewardCoin).HasColumnName("reward_coin");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");
            });

            modelBuilder.Entity<DungeonSkipDatum>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("dungeon_skip_data");

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("area_id");

                entity.Property(e => e.SkipBgId).HasColumnName("skip_bg_id");

                entity.Property(e => e.SkipMotionId).HasColumnName("skip_motion_id");

                entity.Property(e => e.SkipPositionX).HasColumnName("skip_position_x");

                entity.Property(e => e.SkipPositionY).HasColumnName("skip_position_y");

                entity.Property(e => e.SkipScaleX).HasColumnName("skip_scale_x");

                entity.Property(e => e.SkipScaleY).HasColumnName("skip_scale_y");
            });

            modelBuilder.Entity<EmblemDatum>(entity =>
            {
                entity.HasKey(e => e.EmblemId);

                entity.ToTable("emblem_data");

                entity.Property(e => e.EmblemId)
                    .ValueGeneratedNever()
                    .HasColumnName("emblem_id");

                entity.Property(e => e.DescriptionMissionId).HasColumnName("description_mission_id");

                entity.Property(e => e.DispOder).HasColumnName("disp_oder");

                entity.Property(e => e.EmblemName).HasColumnName("emblem_name");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventEmblem).HasColumnName("event_emblem");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<EmblemMissionDatum>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("emblem_mission_data");

                entity.Property(e => e.MissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<EmblemMissionRewardDatum>(entity =>
            {
                entity.ToTable("emblem_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId, "emblem_mission_reward_data_0_mission_reward_id");

                entity.HasIndex(e => e.RewardId, "emblem_mission_reward_data_0_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<EnemyEnableVoice>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("enemy_enable_voice");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<EnemyMPart>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("enemy_m_parts");

                entity.Property(e => e.EnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("enemy_id");

                entity.Property(e => e.ChildEnemyParameter1).HasColumnName("child_enemy_parameter_1");

                entity.Property(e => e.ChildEnemyParameter2).HasColumnName("child_enemy_parameter_2");

                entity.Property(e => e.ChildEnemyParameter3).HasColumnName("child_enemy_parameter_3");

                entity.Property(e => e.ChildEnemyParameter4).HasColumnName("child_enemy_parameter_4");

                entity.Property(e => e.ChildEnemyParameter5).HasColumnName("child_enemy_parameter_5");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<EnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("enemy_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.BreakDurability).HasColumnName("break_durability");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UniqueEquipmentFlag1).HasColumnName("unique_equipment_flag_1");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.VirtualHp).HasColumnName("virtual_hp");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EnemyRewardDatum>(entity =>
            {
                entity.HasKey(e => e.DropRewardId);

                entity.ToTable("enemy_reward_data");

                entity.Property(e => e.DropRewardId)
                    .ValueGeneratedNever()
                    .HasColumnName("drop_reward_id");

                entity.Property(e => e.DropCount).HasColumnName("drop_count");

                entity.Property(e => e.Odds1).HasColumnName("odds_1");

                entity.Property(e => e.Odds2).HasColumnName("odds_2");

                entity.Property(e => e.Odds3).HasColumnName("odds_3");

                entity.Property(e => e.Odds4).HasColumnName("odds_4");

                entity.Property(e => e.Odds5).HasColumnName("odds_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<EquipmentCraft>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("equipment_craft");

                entity.Property(e => e.EquipmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("equipment_id");

                entity.Property(e => e.ConditionEquipmentId1).HasColumnName("condition_equipment_id_1");

                entity.Property(e => e.ConditionEquipmentId10).HasColumnName("condition_equipment_id_10");

                entity.Property(e => e.ConditionEquipmentId2).HasColumnName("condition_equipment_id_2");

                entity.Property(e => e.ConditionEquipmentId3).HasColumnName("condition_equipment_id_3");

                entity.Property(e => e.ConditionEquipmentId4).HasColumnName("condition_equipment_id_4");

                entity.Property(e => e.ConditionEquipmentId5).HasColumnName("condition_equipment_id_5");

                entity.Property(e => e.ConditionEquipmentId6).HasColumnName("condition_equipment_id_6");

                entity.Property(e => e.ConditionEquipmentId7).HasColumnName("condition_equipment_id_7");

                entity.Property(e => e.ConditionEquipmentId8).HasColumnName("condition_equipment_id_8");

                entity.Property(e => e.ConditionEquipmentId9).HasColumnName("condition_equipment_id_9");

                entity.Property(e => e.ConsumeNum1).HasColumnName("consume_num_1");

                entity.Property(e => e.ConsumeNum10).HasColumnName("consume_num_10");

                entity.Property(e => e.ConsumeNum2).HasColumnName("consume_num_2");

                entity.Property(e => e.ConsumeNum3).HasColumnName("consume_num_3");

                entity.Property(e => e.ConsumeNum4).HasColumnName("consume_num_4");

                entity.Property(e => e.ConsumeNum5).HasColumnName("consume_num_5");

                entity.Property(e => e.ConsumeNum6).HasColumnName("consume_num_6");

                entity.Property(e => e.ConsumeNum7).HasColumnName("consume_num_7");

                entity.Property(e => e.ConsumeNum8).HasColumnName("consume_num_8");

                entity.Property(e => e.ConsumeNum9).HasColumnName("consume_num_9");

                entity.Property(e => e.CraftedCost).HasColumnName("crafted_cost");
            });

            modelBuilder.Entity<EquipmentDatum>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("equipment_data");

                entity.Property(e => e.EquipmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("equipment_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.CraftFlg).HasColumnName("craft_flg");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DisplayItem).HasColumnName("display_item");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnableDonation).HasColumnName("enable_donation");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentEnhancePoint).HasColumnName("equipment_enhance_point");

                entity.Property(e => e.EquipmentName).HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.RequireLevel).HasColumnName("require_level");

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EquipmentDonation>(entity =>
            {
                entity.HasKey(e => e.TeamLevel);

                entity.ToTable("equipment_donation");

                entity.Property(e => e.TeamLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("team_level");

                entity.Property(e => e.DonationNumDaily).HasColumnName("donation_num_daily");

                entity.Property(e => e.DonationNumOnce).HasColumnName("donation_num_once");

                entity.Property(e => e.RequestNumOnce).HasColumnName("request_num_once");
            });

            modelBuilder.Entity<EquipmentEnhanceDatum>(entity =>
            {
                entity.HasKey(e => new { e.PromotionLevel, e.EquipmentEnhanceLevel });

                entity.ToTable("equipment_enhance_data");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.EquipmentEnhanceLevel).HasColumnName("equipment_enhance_level");

                entity.Property(e => e.NeededPoint).HasColumnName("needed_point");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");
            });

            modelBuilder.Entity<EquipmentEnhanceRate>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("equipment_enhance_rate");

                entity.Property(e => e.EquipmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("equipment_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentName).HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EventBgDatum>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("event_bg_data");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");
            });

            modelBuilder.Entity<EventBossTreasureBox>(entity =>
            {
                entity.ToTable("event_boss_treasure_box");

                entity.Property(e => e.EventBossTreasureBoxId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_boss_treasure_box_id");

                entity.Property(e => e.EachOdds1).HasColumnName("each_odds_1");

                entity.Property(e => e.EachOdds10).HasColumnName("each_odds_10");

                entity.Property(e => e.EachOdds2).HasColumnName("each_odds_2");

                entity.Property(e => e.EachOdds3).HasColumnName("each_odds_3");

                entity.Property(e => e.EachOdds4).HasColumnName("each_odds_4");

                entity.Property(e => e.EachOdds5).HasColumnName("each_odds_5");

                entity.Property(e => e.EachOdds6).HasColumnName("each_odds_6");

                entity.Property(e => e.EachOdds7).HasColumnName("each_odds_7");

                entity.Property(e => e.EachOdds8).HasColumnName("each_odds_8");

                entity.Property(e => e.EachOdds9).HasColumnName("each_odds_9");

                entity.Property(e => e.EventBossTreasureContentId1).HasColumnName("event_boss_treasure_content_id_1");

                entity.Property(e => e.EventBossTreasureContentId10).HasColumnName("event_boss_treasure_content_id_10");

                entity.Property(e => e.EventBossTreasureContentId2).HasColumnName("event_boss_treasure_content_id_2");

                entity.Property(e => e.EventBossTreasureContentId3).HasColumnName("event_boss_treasure_content_id_3");

                entity.Property(e => e.EventBossTreasureContentId4).HasColumnName("event_boss_treasure_content_id_4");

                entity.Property(e => e.EventBossTreasureContentId5).HasColumnName("event_boss_treasure_content_id_5");

                entity.Property(e => e.EventBossTreasureContentId6).HasColumnName("event_boss_treasure_content_id_6");

                entity.Property(e => e.EventBossTreasureContentId7).HasColumnName("event_boss_treasure_content_id_7");

                entity.Property(e => e.EventBossTreasureContentId8).HasColumnName("event_boss_treasure_content_id_8");

                entity.Property(e => e.EventBossTreasureContentId9).HasColumnName("event_boss_treasure_content_id_9");

                entity.Property(e => e.TreasureType1).HasColumnName("treasure_type_1");

                entity.Property(e => e.TreasureType10).HasColumnName("treasure_type_10");

                entity.Property(e => e.TreasureType2).HasColumnName("treasure_type_2");

                entity.Property(e => e.TreasureType3).HasColumnName("treasure_type_3");

                entity.Property(e => e.TreasureType4).HasColumnName("treasure_type_4");

                entity.Property(e => e.TreasureType5).HasColumnName("treasure_type_5");

                entity.Property(e => e.TreasureType6).HasColumnName("treasure_type_6");

                entity.Property(e => e.TreasureType7).HasColumnName("treasure_type_7");

                entity.Property(e => e.TreasureType8).HasColumnName("treasure_type_8");

                entity.Property(e => e.TreasureType9).HasColumnName("treasure_type_9");
            });

            modelBuilder.Entity<EventBossTreasureContent>(entity =>
            {
                entity.ToTable("event_boss_treasure_content");

                entity.Property(e => e.EventBossTreasureContentId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_boss_treasure_content_id");

                entity.Property(e => e.Odds1).HasColumnName("odds_1");

                entity.Property(e => e.Odds2).HasColumnName("odds_2");

                entity.Property(e => e.Odds3).HasColumnName("odds_3");

                entity.Property(e => e.Odds4).HasColumnName("odds_4");

                entity.Property(e => e.Odds5).HasColumnName("odds_5");

                entity.Property(e => e.OddsFile1).HasColumnName("odds_file_1");

                entity.Property(e => e.OddsFile2).HasColumnName("odds_file_2");

                entity.Property(e => e.OddsFile3).HasColumnName("odds_file_3");

                entity.Property(e => e.OddsFile4).HasColumnName("odds_file_4");

                entity.Property(e => e.OddsFile5).HasColumnName("odds_file_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<EventEffectSetting>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.Type });

                entity.ToTable("event_effect_setting");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<EventEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("event_enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("enemy_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EventEnemyRewardGroup>(entity =>
            {
                entity.ToTable("event_enemy_reward_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.RewardGroupId).HasColumnName("reward_group_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<EventGachaDatum>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("event_gacha_data");

                entity.HasIndex(e => e.EventId, "event_gacha_data_0_event_id");

                entity.Property(e => e.GachaId)
                    .ValueGeneratedNever()
                    .HasColumnName("gacha_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.GachaName).HasColumnName("gacha_name");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.RepeatStep).HasColumnName("repeat_step");
            });

            modelBuilder.Entity<EventIntroduction>(entity =>
            {
                entity.ToTable("event_introduction");

                entity.HasIndex(e => e.EventId, "event_introduction_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IntroductionNumber).HasColumnName("introduction_number");

                entity.Property(e => e.MaximumChunkSize1).HasColumnName("maximum_chunk_size_1");

                entity.Property(e => e.MaximumChunkSize2).HasColumnName("maximum_chunk_size_2");

                entity.Property(e => e.MaximumChunkSize3).HasColumnName("maximum_chunk_size_3");

                entity.Property(e => e.MaximumChunkSizeLoop1).HasColumnName("maximum_chunk_size_loop_1");

                entity.Property(e => e.MaximumChunkSizeLoop2).HasColumnName("maximum_chunk_size_loop_2");

                entity.Property(e => e.MaximumChunkSizeLoop3).HasColumnName("maximum_chunk_size_loop_3");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<EventNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("event_navi_comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName).HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<EventNaviCommentCondition>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("event_navi_comment_condition");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.ConditionType1).HasColumnName("condition_type_1");

                entity.Property(e => e.ConditionType2).HasColumnName("condition_type_2");

                entity.Property(e => e.ConditionType3).HasColumnName("condition_type_3");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");
            });

            modelBuilder.Entity<EventReminder>(entity =>
            {
                entity.HasKey(e => e.ReminderId);

                entity.ToTable("event_reminder");

                entity.HasIndex(e => e.EventId, "event_reminder_0_event_id");

                entity.Property(e => e.ReminderId)
                    .ValueGeneratedNever()
                    .HasColumnName("reminder_id");

                entity.Property(e => e.BtnText).HasColumnName("btn_text");

                entity.Property(e => e.DescriptionText).HasColumnName("description_text");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.NoticeText).HasColumnName("notice_text");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TargetType).HasColumnName("target_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.TitleText).HasColumnName("title_text");
            });

            modelBuilder.Entity<EventReminderCondition>(entity =>
            {
                entity.ToTable("event_reminder_condition");

                entity.HasIndex(e => e.ReminderId, "event_reminder_condition_0_reminder_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ReminderId).HasColumnName("reminder_id");
            });

            modelBuilder.Entity<EventRevivalWaveGroupDatum>(entity =>
            {
                entity.ToTable("event_revival_wave_group_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.MatchLvMax).HasColumnName("match_lv_max");

                entity.Property(e => e.MatchLvMin).HasColumnName("match_lv_min");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<EventSeriesWaveGroupDatum>(entity =>
            {
                entity.ToTable("event_series_wave_group_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.MatchLvMax).HasColumnName("match_lv_max");

                entity.Property(e => e.MatchLvMin).HasColumnName("match_lv_min");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<EventStoryDatum>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("event_story_data");

                entity.HasIndex(e => e.Value, "event_story_data_0_value");

                entity.Property(e => e.StoryGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_group_id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<EventStoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("event_story_detail");

                entity.HasIndex(e => e.StoryGroupId, "event_story_detail_0_story_group_id");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<EventTopAdv>(entity =>
            {
                entity.ToTable("event_top_adv");

                entity.HasIndex(e => new { e.EventId, e.Type }, "event_top_adv_0_event_id_1_type");

                entity.Property(e => e.EventTopAdvId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_top_adv_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value1).HasColumnName("value_1");

                entity.Property(e => e.Value2).HasColumnName("value_2");

                entity.Property(e => e.Value3).HasColumnName("value_3");
            });

            modelBuilder.Entity<EventWaveGroupDatum>(entity =>
            {
                entity.ToTable("event_wave_group_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.MatchLvMax).HasColumnName("match_lv_max");

                entity.Property(e => e.MatchLvMin).HasColumnName("match_lv_min");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<ExperienceTeam>(entity =>
            {
                entity.HasKey(e => e.TeamLevel);

                entity.ToTable("experience_team");

                entity.Property(e => e.TeamLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("team_level");

                entity.Property(e => e.MaxStamina).HasColumnName("max_stamina");

                entity.Property(e => e.OverLimitStamina).HasColumnName("over_limit_stamina");

                entity.Property(e => e.RecoverStaminaCount).HasColumnName("recover_stamina_count");

                entity.Property(e => e.TotalExp).HasColumnName("total_exp");
            });

            modelBuilder.Entity<ExperienceUnit>(entity =>
            {
                entity.HasKey(e => e.UnitLevel);

                entity.ToTable("experience_unit");

                entity.Property(e => e.UnitLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_level");

                entity.Property(e => e.TotalExp).HasColumnName("total_exp");
            });

            modelBuilder.Entity<FixLineupGroupSet>(entity =>
            {
                entity.HasKey(e => new { e.LineupGroupSetId, e.TeamLevelFrom, e.TeamLevelTo });

                entity.ToTable("fix_lineup_group_set");

                entity.HasIndex(e => new { e.TeamLevelFrom, e.TeamLevelTo }, "fix_lineup_group_set_0_team_level_from_1_team_level_to");

                entity.Property(e => e.LineupGroupSetId).HasColumnName("lineup_group_set_id");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");

                entity.Property(e => e.CurrencyId1).HasColumnName("currency_id_1");

                entity.Property(e => e.CurrencyId10).HasColumnName("currency_id_10");

                entity.Property(e => e.CurrencyId11).HasColumnName("currency_id_11");

                entity.Property(e => e.CurrencyId12).HasColumnName("currency_id_12");

                entity.Property(e => e.CurrencyId13).HasColumnName("currency_id_13");

                entity.Property(e => e.CurrencyId14).HasColumnName("currency_id_14");

                entity.Property(e => e.CurrencyId15).HasColumnName("currency_id_15");

                entity.Property(e => e.CurrencyId16).HasColumnName("currency_id_16");

                entity.Property(e => e.CurrencyId17).HasColumnName("currency_id_17");

                entity.Property(e => e.CurrencyId18).HasColumnName("currency_id_18");

                entity.Property(e => e.CurrencyId19).HasColumnName("currency_id_19");

                entity.Property(e => e.CurrencyId2).HasColumnName("currency_id_2");

                entity.Property(e => e.CurrencyId20).HasColumnName("currency_id_20");

                entity.Property(e => e.CurrencyId3).HasColumnName("currency_id_3");

                entity.Property(e => e.CurrencyId4).HasColumnName("currency_id_4");

                entity.Property(e => e.CurrencyId5).HasColumnName("currency_id_5");

                entity.Property(e => e.CurrencyId6).HasColumnName("currency_id_6");

                entity.Property(e => e.CurrencyId7).HasColumnName("currency_id_7");

                entity.Property(e => e.CurrencyId8).HasColumnName("currency_id_8");

                entity.Property(e => e.CurrencyId9).HasColumnName("currency_id_9");

                entity.Property(e => e.Price1).HasColumnName("price_1");

                entity.Property(e => e.Price10).HasColumnName("price_10");

                entity.Property(e => e.Price11).HasColumnName("price_11");

                entity.Property(e => e.Price12).HasColumnName("price_12");

                entity.Property(e => e.Price13).HasColumnName("price_13");

                entity.Property(e => e.Price14).HasColumnName("price_14");

                entity.Property(e => e.Price15).HasColumnName("price_15");

                entity.Property(e => e.Price16).HasColumnName("price_16");

                entity.Property(e => e.Price17).HasColumnName("price_17");

                entity.Property(e => e.Price18).HasColumnName("price_18");

                entity.Property(e => e.Price19).HasColumnName("price_19");

                entity.Property(e => e.Price2).HasColumnName("price_2");

                entity.Property(e => e.Price20).HasColumnName("price_20");

                entity.Property(e => e.Price3).HasColumnName("price_3");

                entity.Property(e => e.Price4).HasColumnName("price_4");

                entity.Property(e => e.Price5).HasColumnName("price_5");

                entity.Property(e => e.Price6).HasColumnName("price_6");

                entity.Property(e => e.Price7).HasColumnName("price_7");

                entity.Property(e => e.Price8).HasColumnName("price_8");

                entity.Property(e => e.Price9).HasColumnName("price_9");

                entity.Property(e => e.PriceType1).HasColumnName("price_type_1");

                entity.Property(e => e.PriceType10).HasColumnName("price_type_10");

                entity.Property(e => e.PriceType11).HasColumnName("price_type_11");

                entity.Property(e => e.PriceType12).HasColumnName("price_type_12");

                entity.Property(e => e.PriceType13).HasColumnName("price_type_13");

                entity.Property(e => e.PriceType14).HasColumnName("price_type_14");

                entity.Property(e => e.PriceType15).HasColumnName("price_type_15");

                entity.Property(e => e.PriceType16).HasColumnName("price_type_16");

                entity.Property(e => e.PriceType17).HasColumnName("price_type_17");

                entity.Property(e => e.PriceType18).HasColumnName("price_type_18");

                entity.Property(e => e.PriceType19).HasColumnName("price_type_19");

                entity.Property(e => e.PriceType2).HasColumnName("price_type_2");

                entity.Property(e => e.PriceType20).HasColumnName("price_type_20");

                entity.Property(e => e.PriceType3).HasColumnName("price_type_3");

                entity.Property(e => e.PriceType4).HasColumnName("price_type_4");

                entity.Property(e => e.PriceType5).HasColumnName("price_type_5");

                entity.Property(e => e.PriceType6).HasColumnName("price_type_6");

                entity.Property(e => e.PriceType7).HasColumnName("price_type_7");

                entity.Property(e => e.PriceType8).HasColumnName("price_type_8");

                entity.Property(e => e.PriceType9).HasColumnName("price_type_9");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount10).HasColumnName("reward_count_10");

                entity.Property(e => e.RewardCount11).HasColumnName("reward_count_11");

                entity.Property(e => e.RewardCount12).HasColumnName("reward_count_12");

                entity.Property(e => e.RewardCount13).HasColumnName("reward_count_13");

                entity.Property(e => e.RewardCount14).HasColumnName("reward_count_14");

                entity.Property(e => e.RewardCount15).HasColumnName("reward_count_15");

                entity.Property(e => e.RewardCount16).HasColumnName("reward_count_16");

                entity.Property(e => e.RewardCount17).HasColumnName("reward_count_17");

                entity.Property(e => e.RewardCount18).HasColumnName("reward_count_18");

                entity.Property(e => e.RewardCount19).HasColumnName("reward_count_19");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount20).HasColumnName("reward_count_20");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardCount6).HasColumnName("reward_count_6");

                entity.Property(e => e.RewardCount7).HasColumnName("reward_count_7");

                entity.Property(e => e.RewardCount8).HasColumnName("reward_count_8");

                entity.Property(e => e.RewardCount9).HasColumnName("reward_count_9");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId10).HasColumnName("reward_id_10");

                entity.Property(e => e.RewardId11).HasColumnName("reward_id_11");

                entity.Property(e => e.RewardId12).HasColumnName("reward_id_12");

                entity.Property(e => e.RewardId13).HasColumnName("reward_id_13");

                entity.Property(e => e.RewardId14).HasColumnName("reward_id_14");

                entity.Property(e => e.RewardId15).HasColumnName("reward_id_15");

                entity.Property(e => e.RewardId16).HasColumnName("reward_id_16");

                entity.Property(e => e.RewardId17).HasColumnName("reward_id_17");

                entity.Property(e => e.RewardId18).HasColumnName("reward_id_18");

                entity.Property(e => e.RewardId19).HasColumnName("reward_id_19");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId20).HasColumnName("reward_id_20");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardId6).HasColumnName("reward_id_6");

                entity.Property(e => e.RewardId7).HasColumnName("reward_id_7");

                entity.Property(e => e.RewardId8).HasColumnName("reward_id_8");

                entity.Property(e => e.RewardId9).HasColumnName("reward_id_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType11).HasColumnName("reward_type_11");

                entity.Property(e => e.RewardType12).HasColumnName("reward_type_12");

                entity.Property(e => e.RewardType13).HasColumnName("reward_type_13");

                entity.Property(e => e.RewardType14).HasColumnName("reward_type_14");

                entity.Property(e => e.RewardType15).HasColumnName("reward_type_15");

                entity.Property(e => e.RewardType16).HasColumnName("reward_type_16");

                entity.Property(e => e.RewardType17).HasColumnName("reward_type_17");

                entity.Property(e => e.RewardType18).HasColumnName("reward_type_18");

                entity.Property(e => e.RewardType19).HasColumnName("reward_type_19");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType20).HasColumnName("reward_type_20");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");
            });

            modelBuilder.Entity<FkeHappeningList>(entity =>
            {
                entity.HasKey(e => e.HappeningId);

                entity.ToTable("fke_happening_list");

                entity.Property(e => e.HappeningId)
                    .ValueGeneratedNever()
                    .HasColumnName("happening_id");

                entity.Property(e => e.HappeningName).HasColumnName("happening_name");
            });

            modelBuilder.Entity<FkeReward>(entity =>
            {
                entity.ToTable("fke_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FkePoint).HasColumnName("fke_point");

                entity.Property(e => e.MissionDetail).HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GachaDatum>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("gacha_data");

                entity.Property(e => e.GachaId)
                    .ValueGeneratedNever()
                    .HasColumnName("gacha_id");

                entity.Property(e => e.CharaOddsStar1).HasColumnName("chara_odds_star1");

                entity.Property(e => e.CharaOddsStar2).HasColumnName("chara_odds_star2");

                entity.Property(e => e.CharaOddsStar3).HasColumnName("chara_odds_star3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Description2).HasColumnName("description_2");

                entity.Property(e => e.DescriptionSp).HasColumnName("description_sp");

                entity.Property(e => e.DiscountPrice).HasColumnName("discount_price");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ExchangeId).HasColumnName("exchange_id");

                entity.Property(e => e.FreeGachaCount).HasColumnName("free_gacha_count");

                entity.Property(e => e.FreeGachaIntervalTime).HasColumnName("free_gacha_interval_time");

                entity.Property(e => e.FreeGachaType).HasColumnName("free_gacha_type");

                entity.Property(e => e.Gacha10SpecialOddsStar1).HasColumnName("gacha10_special_odds_star1");

                entity.Property(e => e.Gacha10SpecialOddsStar2).HasColumnName("gacha10_special_odds_star2");

                entity.Property(e => e.Gacha10SpecialOddsStar3).HasColumnName("gacha10_special_odds_star3");

                entity.Property(e => e.GachaBonusId).HasColumnName("gacha_bonus_id");

                entity.Property(e => e.GachaCostType).HasColumnName("gacha_cost_type");

                entity.Property(e => e.GachaDetail).HasColumnName("gacha_detail");

                entity.Property(e => e.GachaName).HasColumnName("gacha_name");

                entity.Property(e => e.GachaOdds).HasColumnName("gacha_odds");

                entity.Property(e => e.GachaOddsStar2).HasColumnName("gacha_odds_star2");

                entity.Property(e => e.GachaTimesLimit10).HasColumnName("gacha_times_limit10");

                entity.Property(e => e.GachaType).HasColumnName("gacha_type");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.ParallelId).HasColumnName("parallel_id");

                entity.Property(e => e.PickUpCharaText).HasColumnName("pick_up_chara_text");

                entity.Property(e => e.PickupBadge).HasColumnName("pickup_badge");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PrizegachaId).HasColumnName("prizegacha_id");

                entity.Property(e => e.RarityOdds).HasColumnName("rarity_odds");

                entity.Property(e => e.SpecialId).HasColumnName("special_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.Property(e => e.TicketId10).HasColumnName("ticket_id_10");
            });

            modelBuilder.Entity<GachaExchangeLineup>(entity =>
            {
                entity.ToTable("gacha_exchange_lineup");

                entity.HasIndex(e => e.ExchangeId, "gacha_exchange_lineup_0_exchange_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ExchangeId).HasColumnName("exchange_id");

                entity.Property(e => e.GachaBonusId).HasColumnName("gacha_bonus_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<GiftMessage>(entity =>
            {
                entity.ToTable("gift_message");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Discription).HasColumnName("discription");

                entity.Property(e => e.Type1).HasColumnName("type_1");

                entity.Property(e => e.Type2).HasColumnName("type_2");

                entity.Property(e => e.Type3).HasColumnName("type_3");

                entity.Property(e => e.Type4).HasColumnName("type_4");
            });

            modelBuilder.Entity<GlobalDatum>(entity =>
            {
                entity.HasKey(e => e.KeyName);

                entity.ToTable("global_data");

                entity.Property(e => e.KeyName).HasColumnName("key_name");

                entity.Property(e => e.Desc).HasColumnName("desc");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<GlossaryDetail>(entity =>
            {
                entity.HasKey(e => e.GlossaryId);

                entity.ToTable("glossary_detail");

                entity.Property(e => e.GlossaryId)
                    .ValueGeneratedNever()
                    .HasColumnName("glossary_id");

                entity.Property(e => e.CategoryType).HasColumnName("category_type");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.GlossaryCategoryId).HasColumnName("glossary_category_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnlockStoryId).HasColumnName("unlock_story_id");
            });

            modelBuilder.Entity<GoldsetData2>(entity =>
            {
                entity.HasKey(e => e.BuyCount);

                entity.ToTable("goldset_data_2");

                entity.Property(e => e.BuyCount)
                    .ValueGeneratedNever()
                    .HasColumnName("buy_count");

                entity.Property(e => e.AdditionalGoldMaxRate).HasColumnName("additional_gold_max_rate");

                entity.Property(e => e.AdditionalGoldMinRate).HasColumnName("additional_gold_min_rate");

                entity.Property(e => e.GetGoldCount).HasColumnName("get_gold_count");

                entity.Property(e => e.GoldsetOdds1).HasColumnName("goldset_odds_1");

                entity.Property(e => e.GoldsetOdds2).HasColumnName("goldset_odds_2");

                entity.Property(e => e.GoldsetOdds3).HasColumnName("goldset_odds_3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TrainingQuestCount).HasColumnName("training_quest_count");

                entity.Property(e => e.UseJewelCount).HasColumnName("use_jewel_count");
            });

            modelBuilder.Entity<GoldsetDataTeamlevel>(entity =>
            {
                entity.HasKey(e => e.TeamLevel);

                entity.ToTable("goldset_data_teamlevel");

                entity.Property(e => e.TeamLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("team_level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InitialGetGoldCount).HasColumnName("initial_get_gold_count");
            });

            modelBuilder.Entity<GoldsetDatum>(entity =>
            {
                entity.HasKey(e => e.BuyCount);

                entity.ToTable("goldset_data");

                entity.Property(e => e.BuyCount)
                    .ValueGeneratedNever()
                    .HasColumnName("buy_count");

                entity.Property(e => e.AdditionalGoldMaxRate).HasColumnName("additional_gold_max_rate");

                entity.Property(e => e.AdditionalGoldMinRate).HasColumnName("additional_gold_min_rate");

                entity.Property(e => e.GetGoldCount).HasColumnName("get_gold_count");

                entity.Property(e => e.GoldsetOdds1).HasColumnName("goldset_odds_1");

                entity.Property(e => e.GoldsetOdds2).HasColumnName("goldset_odds_2");

                entity.Property(e => e.GoldsetOdds3).HasColumnName("goldset_odds_3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UseJewelCount).HasColumnName("use_jewel_count");
            });

            modelBuilder.Entity<GrandArenaDailyRankReward>(entity =>
            {
                entity.ToTable("grand_arena_daily_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrandArenaDefenceReward>(entity =>
            {
                entity.ToTable("grand_arena_defence_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.LimitCount).HasColumnName("limit_count");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrandArenaMaxRankReward>(entity =>
            {
                entity.ToTable("grand_arena_max_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrandArenaMaxSeasonRankReward>(entity =>
            {
                entity.ToTable("grand_arena_max_season_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrowthParameter>(entity =>
            {
                entity.HasKey(e => e.GrowthId);

                entity.ToTable("growth_parameter");

                entity.Property(e => e.GrowthId)
                    .ValueGeneratedNever()
                    .HasColumnName("growth_id");

                entity.Property(e => e.Equipment1).HasColumnName("equipment_1");

                entity.Property(e => e.Equipment2).HasColumnName("equipment_2");

                entity.Property(e => e.Equipment3).HasColumnName("equipment_3");

                entity.Property(e => e.Equipment4).HasColumnName("equipment_4");

                entity.Property(e => e.Equipment5).HasColumnName("equipment_5");

                entity.Property(e => e.Equipment6).HasColumnName("equipment_6");

                entity.Property(e => e.GrowthType).HasColumnName("growth_type");

                entity.Property(e => e.IsRestriction).HasColumnName("is_restriction");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.SkillLevel).HasColumnName("skill_level");

                entity.Property(e => e.UnitLevel).HasColumnName("unit_level");

                entity.Property(e => e.UnitRarity).HasColumnName("unit_rarity");
            });

            modelBuilder.Entity<GrowthRestrictionUnit>(entity =>
            {
                entity.ToTable("growth_restriction_unit");

                entity.HasIndex(e => e.GrowthId, "growth_restriction_unit_0_growth_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GrowthId).HasColumnName("growth_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<Guild>(entity =>
            {
                entity.ToTable("guild");

                entity.Property(e => e.GuildId)
                    .ValueGeneratedNever()
                    .HasColumnName("guild_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GuildMaster).HasColumnName("guild_master");

                entity.Property(e => e.GuildName).HasColumnName("guild_name");

                entity.Property(e => e.Member1).HasColumnName("member1");

                entity.Property(e => e.Member10).HasColumnName("member10");

                entity.Property(e => e.Member11).HasColumnName("member11");

                entity.Property(e => e.Member12).HasColumnName("member12");

                entity.Property(e => e.Member13).HasColumnName("member13");

                entity.Property(e => e.Member14).HasColumnName("member14");

                entity.Property(e => e.Member15).HasColumnName("member15");

                entity.Property(e => e.Member16).HasColumnName("member16");

                entity.Property(e => e.Member17).HasColumnName("member17");

                entity.Property(e => e.Member18).HasColumnName("member18");

                entity.Property(e => e.Member19).HasColumnName("member19");

                entity.Property(e => e.Member2).HasColumnName("member2");

                entity.Property(e => e.Member20).HasColumnName("member20");

                entity.Property(e => e.Member21).HasColumnName("member21");

                entity.Property(e => e.Member22).HasColumnName("member22");

                entity.Property(e => e.Member23).HasColumnName("member23");

                entity.Property(e => e.Member24).HasColumnName("member24");

                entity.Property(e => e.Member25).HasColumnName("member25");

                entity.Property(e => e.Member26).HasColumnName("member26");

                entity.Property(e => e.Member27).HasColumnName("member27");

                entity.Property(e => e.Member28).HasColumnName("member28");

                entity.Property(e => e.Member29).HasColumnName("member29");

                entity.Property(e => e.Member3).HasColumnName("member3");

                entity.Property(e => e.Member30).HasColumnName("member30");

                entity.Property(e => e.Member4).HasColumnName("member4");

                entity.Property(e => e.Member5).HasColumnName("member5");

                entity.Property(e => e.Member6).HasColumnName("member6");

                entity.Property(e => e.Member7).HasColumnName("member7");

                entity.Property(e => e.Member8).HasColumnName("member8");

                entity.Property(e => e.Member9).HasColumnName("member9");
            });

            modelBuilder.Entity<GuildAdditionalMember>(entity =>
            {
                entity.HasKey(e => e.GuildId);

                entity.ToTable("guild_additional_member");

                entity.Property(e => e.GuildId)
                    .ValueGeneratedNever()
                    .HasColumnName("guild_id");

                entity.Property(e => e.Member1).HasColumnName("member1");

                entity.Property(e => e.Member10).HasColumnName("member10");

                entity.Property(e => e.Member2).HasColumnName("member2");

                entity.Property(e => e.Member3).HasColumnName("member3");

                entity.Property(e => e.Member4).HasColumnName("member4");

                entity.Property(e => e.Member5).HasColumnName("member5");

                entity.Property(e => e.Member6).HasColumnName("member6");

                entity.Property(e => e.Member7).HasColumnName("member7");

                entity.Property(e => e.Member8).HasColumnName("member8");

                entity.Property(e => e.Member9).HasColumnName("member9");

                entity.Property(e => e.ThumbId).HasColumnName("thumb_id");

                entity.Property(e => e.UnlockStoryId).HasColumnName("unlock_story_id");
            });

            modelBuilder.Entity<HatsuneBattleMissionDatum>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("hatsune_battle_mission_data");

                entity.Property(e => e.MissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneBgChange>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("hatsune_bg_change");

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("area_id");

                entity.Property(e => e.QuestId1).HasColumnName("quest_id_1");

                entity.Property(e => e.QuestId2).HasColumnName("quest_id_2");

                entity.Property(e => e.QuestId3).HasColumnName("quest_id_3");

                entity.Property(e => e.QuestId4).HasColumnName("quest_id_4");

                entity.Property(e => e.QuestId5).HasColumnName("quest_id_5");
            });

            modelBuilder.Entity<HatsuneBgChangeDatum>(entity =>
            {
                entity.ToTable("hatsune_bg_change_data");

                entity.HasIndex(e => new { e.TargetType, e.AreaId }, "hatsune_bg_change_data_0_target_type_1_area_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BgAfterChangeId).HasColumnName("bg_after_change_id");

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.TargetType).HasColumnName("target_type");
            });

            modelBuilder.Entity<HatsuneBoss>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("hatsune_boss");

                entity.HasIndex(e => e.EventId, "hatsune_boss_0_event_id");

                entity.HasIndex(e => new { e.EventId, e.Difficulty }, "hatsune_boss_0_event_id_1_difficulty");

                entity.HasIndex(e => e.WaveGroupId1, "hatsune_boss_0_wave_group_id_1");

                entity.Property(e => e.BossId)
                    .ValueGeneratedNever()
                    .HasColumnName("boss_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.BossPositionX).HasColumnName("boss_position_x");

                entity.Property(e => e.BossPositionY).HasColumnName("boss_position_y");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DeatailAuraSize).HasColumnName("deatail_aura_size");

                entity.Property(e => e.DetailBgId).HasColumnName("detail_bg_id");

                entity.Property(e => e.DetailBgPosition).HasColumnName("detail_bg_position");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispOnBg).HasColumnName("disp_on_bg");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventBossTreasureBoxId1).HasColumnName("event_boss_treasure_box_id_1");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconColliderScale).HasColumnName("icon_collider_scale");

                entity.Property(e => e.IconDisplayScale).HasColumnName("icon_display_scale");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.MapAuraSize).HasColumnName("map_aura_size");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.MapSize).HasColumnName("map_size");

                entity.Property(e => e.OneblowCountOfSkipCondition).HasColumnName("oneblow_count_of_skip_condition");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.RequiredSkipTicketCount).HasColumnName("required_skip_ticket_count");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.RetireFlag).HasColumnName("retire_flag");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RewardGoldLimit).HasColumnName("reward_gold_limit");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.UseTicketNum).HasColumnName("use_ticket_num");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");
            });

            modelBuilder.Entity<HatsuneBossCondition>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("hatsune_boss_condition");

                entity.Property(e => e.BossId)
                    .ValueGeneratedNever()
                    .HasColumnName("boss_id");

                entity.Property(e => e.ConditionBossId1).HasColumnName("condition_boss_id_1");

                entity.Property(e => e.ConditionBossId2).HasColumnName("condition_boss_id_2");

                entity.Property(e => e.ConditionGachaStep).HasColumnName("condition_gacha_step");

                entity.Property(e => e.ConditionQuestId1).HasColumnName("condition_quest_id_1");

                entity.Property(e => e.ConditionQuestId2).HasColumnName("condition_quest_id_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ForceUnlockTime).HasColumnName("force_unlock_time");

                entity.Property(e => e.ReleaseBossId1).HasColumnName("release_boss_id_1");

                entity.Property(e => e.ReleaseBossId2).HasColumnName("release_boss_id_2");

                entity.Property(e => e.ReleaseQuestId1).HasColumnName("release_quest_id_1");

                entity.Property(e => e.ReleaseQuestId2).HasColumnName("release_quest_id_2");
            });

            modelBuilder.Entity<HatsuneBossEnemySetting>(entity =>
            {
                entity.HasKey(e => new { e.BossId, e.EnemyIdentify });

                entity.ToTable("hatsune_boss_enemy_setting");

                entity.HasIndex(e => new { e.BossId, e.EventId }, "hatsune_boss_enemy_setting_0_boss_id_1_event_id");

                entity.Property(e => e.BossId).HasColumnName("boss_id");

                entity.Property(e => e.EnemyIdentify).HasColumnName("enemy_identify");

                entity.Property(e => e.DetailOffsetX).HasColumnName("detail_offset_x");

                entity.Property(e => e.DetailOffsetY).HasColumnName("detail_offset_y");

                entity.Property(e => e.DetailScale).HasColumnName("detail_scale");

                entity.Property(e => e.EventBossTreasureBoxId).HasColumnName("event_boss_treasure_box_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapDepth).HasColumnName("map_depth");

                entity.Property(e => e.MapOffsetX).HasColumnName("map_offset_x");

                entity.Property(e => e.MapOffsetY).HasColumnName("map_offset_y");

                entity.Property(e => e.MapScale).HasColumnName("map_scale");

                entity.Property(e => e.MustKillFlag).HasColumnName("must_kill_flag");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RewardGoldLimit).HasColumnName("reward_gold_limit");
            });

            modelBuilder.Entity<HatsuneDailyMissionDatum>(entity =>
            {
                entity.HasKey(e => e.DailyMissionId);

                entity.ToTable("hatsune_daily_mission_data");

                entity.Property(e => e.DailyMissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("daily_mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneDescription>(entity =>
            {
                entity.ToTable("hatsune_description");

                entity.HasIndex(e => new { e.EventId, e.Type }, "hatsune_description_0_event_id_1_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsuneDiaryDatum>(entity =>
            {
                entity.HasKey(e => e.DiaryId);

                entity.ToTable("hatsune_diary_data");

                entity.HasIndex(e => e.ContentsType, "hatsune_diary_data_0_contents_type");

                entity.Property(e => e.DiaryId)
                    .ValueGeneratedNever()
                    .HasColumnName("diary_id");

                entity.Property(e => e.ConditionBossCount).HasColumnName("condition_boss_count");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.ConditionTime).HasColumnName("condition_time");

                entity.Property(e => e.ContentsType).HasColumnName("contents_type");

                entity.Property(e => e.DiaryDate).HasColumnName("diary_date");

                entity.Property(e => e.ForcedReleaseTime).HasColumnName("forced_release_time");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");
            });

            modelBuilder.Entity<HatsuneDiaryLetterScript>(entity =>
            {
                entity.ToTable("hatsune_diary_letter_script");

                entity.HasIndex(e => e.DiaryId, "hatsune_diary_letter_script_0_diary_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName).HasColumnName("cue_name");

                entity.Property(e => e.DiaryId).HasColumnName("diary_id");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName).HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsuneDiaryScript>(entity =>
            {
                entity.ToTable("hatsune_diary_script");

                entity.HasIndex(e => e.DiaryId, "hatsune_diary_script_0_diary_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName).HasColumnName("cue_name");

                entity.Property(e => e.DiaryId).HasColumnName("diary_id");

                entity.Property(e => e.DiaryText).HasColumnName("diary_text");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName).HasColumnName("sheet_name");

                entity.Property(e => e.TextAnimationSpeed).HasColumnName("text_animation_speed");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsuneDiarySetting>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("hatsune_diary_setting");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_id");

                entity.Property(e => e.BgmCueName).HasColumnName("bgm_cue_name");

                entity.Property(e => e.BgmSheetName).HasColumnName("bgm_sheet_name");
            });

            modelBuilder.Entity<HatsuneEmblemMission>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("hatsune_emblem_mission");

                entity.HasIndex(e => e.EventId, "hatsune_emblem_mission_0_event_id");

                entity.Property(e => e.MissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<HatsuneEmblemMissionReward>(entity =>
            {
                entity.ToTable("hatsune_emblem_mission_reward");

                entity.HasIndex(e => e.MissionRewardId, "hatsune_emblem_mission_reward_0_mission_reward_id");

                entity.HasIndex(e => e.RewardId, "hatsune_emblem_mission_reward_0_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<HatsuneItem>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("hatsune_item");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_id");

                entity.Property(e => e.BossTicketId).HasColumnName("boss_ticket_id");

                entity.Property(e => e.GachaTicketId).HasColumnName("gacha_ticket_id");

                entity.Property(e => e.UnitMaterialId1).HasColumnName("unit_material_id_1");

                entity.Property(e => e.UnitMaterialId10).HasColumnName("unit_material_id_10");

                entity.Property(e => e.UnitMaterialId2).HasColumnName("unit_material_id_2");

                entity.Property(e => e.UnitMaterialId3).HasColumnName("unit_material_id_3");

                entity.Property(e => e.UnitMaterialId4).HasColumnName("unit_material_id_4");

                entity.Property(e => e.UnitMaterialId5).HasColumnName("unit_material_id_5");

                entity.Property(e => e.UnitMaterialId6).HasColumnName("unit_material_id_6");

                entity.Property(e => e.UnitMaterialId7).HasColumnName("unit_material_id_7");

                entity.Property(e => e.UnitMaterialId8).HasColumnName("unit_material_id_8");

                entity.Property(e => e.UnitMaterialId9).HasColumnName("unit_material_id_9");
            });

            modelBuilder.Entity<HatsuneMap>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("hatsune_map");

                entity.Property(e => e.CourseId)
                    .ValueGeneratedNever()
                    .HasColumnName("course_id");

                entity.Property(e => e.EndAreaId).HasColumnName("end_area_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StartAreaId).HasColumnName("start_area_id");
            });

            modelBuilder.Entity<HatsuneMapEvent>(entity =>
            {
                entity.ToTable("hatsune_map_event");

                entity.HasIndex(e => e.TargetEventId, "hatsune_map_event_0_target_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.EventType).HasColumnName("event_type");

                entity.Property(e => e.Param1).HasColumnName("param1");

                entity.Property(e => e.Param2).HasColumnName("param2");

                entity.Property(e => e.TargetEventId).HasColumnName("target_event_id");
            });

            modelBuilder.Entity<HatsuneMissionRewardDatum>(entity =>
            {
                entity.ToTable("hatsune_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId, "hatsune_mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<HatsuneMultiRouteParameter>(entity =>
            {
                entity.ToTable("hatsune_multi_route_parameter");

                entity.HasIndex(e => e.QuestId, "hatsune_multi_route_parameter_0_quest_id");

                entity.HasIndex(e => e.Type, "hatsune_multi_route_parameter_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Param1).HasColumnName("param_1");

                entity.Property(e => e.Param2).HasColumnName("param_2");

                entity.Property(e => e.Param3).HasColumnName("param_3");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.Text1).HasColumnName("text_1");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsunePresent>(entity =>
            {
                entity.ToTable("hatsune_present");

                entity.HasIndex(e => e.EventId, "hatsune_present_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.DialogText).HasColumnName("dialog_text");

                entity.Property(e => e.DialogTitle).HasColumnName("dialog_title");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemNum1).HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2).HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3).HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4).HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5).HasColumnName("item_num_5");

                entity.Property(e => e.ItemType1).HasColumnName("item_type_1");

                entity.Property(e => e.ItemType2).HasColumnName("item_type_2");

                entity.Property(e => e.ItemType3).HasColumnName("item_type_3");

                entity.Property(e => e.ItemType4).HasColumnName("item_type_4");

                entity.Property(e => e.ItemType5).HasColumnName("item_type_5");
            });

            modelBuilder.Entity<HatsuneQuest>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("hatsune_quest");

                entity.HasIndex(e => e.EventId, "hatsune_quest_0_event_id");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DropRewardId).HasColumnName("drop_reward_id");

                entity.Property(e => e.DropRewardNum).HasColumnName("drop_reward_num");

                entity.Property(e => e.DropRewardOdds).HasColumnName("drop_reward_odds");

                entity.Property(e => e.DropRewardType).HasColumnName("drop_reward_type");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.IconOffsetX).HasColumnName("icon_offset_x");

                entity.Property(e => e.IconOffsetY).HasColumnName("icon_offset_y");

                entity.Property(e => e.IconScale).HasColumnName("icon_scale");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.QuestSeq).HasColumnName("quest_seq");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWaveend2).HasColumnName("story_id_waveend_2");

                entity.Property(e => e.StoryIdWaveend3).HasColumnName("story_id_waveend_3");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.StoryIdWavestart2).HasColumnName("story_id_wavestart_2");

                entity.Property(e => e.StoryIdWavestart3).HasColumnName("story_id_wavestart_3");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2).HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3).HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2).HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3).HasColumnName("wave_bgm_sheet_id_3");
            });

            modelBuilder.Entity<HatsuneQuestArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("hatsune_quest_area");

                entity.HasIndex(e => e.EventId, "hatsune_quest_area_0_event_id");

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("area_id");

                entity.Property(e => e.AdditionalEffect).HasColumnName("additional_effect");

                entity.Property(e => e.AreaDisp).HasColumnName("area_disp");

                entity.Property(e => e.AreaName).HasColumnName("area_name");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.OpenTutorialId).HasColumnName("open_tutorial_id");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.ScrollHeight).HasColumnName("scroll_height");

                entity.Property(e => e.ScrollWidth).HasColumnName("scroll_width");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TutorialParam1).HasColumnName("tutorial_param_1");

                entity.Property(e => e.TutorialParam2).HasColumnName("tutorial_param_2");
            });

            modelBuilder.Entity<HatsuneQuestCondition>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("hatsune_quest_condition");

                entity.HasIndex(e => e.EventId, "hatsune_quest_condition_0_event_id");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.ConditionBossId1).HasColumnName("condition_boss_id_1");

                entity.Property(e => e.ConditionBossId2).HasColumnName("condition_boss_id_2");

                entity.Property(e => e.ConditionMainQuestId).HasColumnName("condition_main_quest_id");

                entity.Property(e => e.ConditionQuestId1).HasColumnName("condition_quest_id_1");

                entity.Property(e => e.ConditionQuestId2).HasColumnName("condition_quest_id_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseBossId1).HasColumnName("release_boss_id_1");

                entity.Property(e => e.ReleaseBossId2).HasColumnName("release_boss_id_2");

                entity.Property(e => e.ReleaseQuestId1).HasColumnName("release_quest_id_1");

                entity.Property(e => e.ReleaseQuestId2).HasColumnName("release_quest_id_2");
            });

            modelBuilder.Entity<HatsuneQuiz>(entity =>
            {
                entity.HasKey(e => e.QuizId);

                entity.ToTable("hatsune_quiz");

                entity.HasIndex(e => e.EventId, "hatsune_quiz_0_event_id");

                entity.HasIndex(e => new { e.EventId, e.ReleaseQuestId }, "hatsune_quiz_0_event_id_1_release_quest_id");

                entity.Property(e => e.QuizId)
                    .ValueGeneratedNever()
                    .HasColumnName("quiz_id");

                entity.Property(e => e.AdvIdQuizEnd).HasColumnName("adv_id_quiz_end");

                entity.Property(e => e.AdvIdQuizStart).HasColumnName("adv_id_quiz_start");

                entity.Property(e => e.Answer).HasColumnName("answer");

                entity.Property(e => e.Choice1).HasColumnName("choice_1");

                entity.Property(e => e.Choice2).HasColumnName("choice_2");

                entity.Property(e => e.Choice3).HasColumnName("choice_3");

                entity.Property(e => e.Choice4).HasColumnName("choice_4");

                entity.Property(e => e.Choice5).HasColumnName("choice_5");

                entity.Property(e => e.Choice6).HasColumnName("choice_6");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Hint).HasColumnName("hint");

                entity.Property(e => e.Question).HasColumnName("question");

                entity.Property(e => e.QuestionTitle).HasColumnName("question_title");

                entity.Property(e => e.QuizIconId).HasColumnName("quiz_icon_id");

                entity.Property(e => e.QuizPointName).HasColumnName("quiz_point_name");

                entity.Property(e => e.QuizPositionX).HasColumnName("quiz_position_x");

                entity.Property(e => e.QuizPositionY).HasColumnName("quiz_position_y");

                entity.Property(e => e.ReleaseQuestId).HasColumnName("release_quest_id");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            });

            modelBuilder.Entity<HatsuneQuizCondition>(entity =>
            {
                entity.ToTable("hatsune_quiz_condition");

                entity.HasIndex(e => new { e.EventId, e.QuizId }, "hatsune_quiz_condition_0_event_id_1_quiz_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ConditionQuizId).HasColumnName("condition_quiz_id");

                entity.Property(e => e.ConditionTimeFrom).HasColumnName("condition_time_from");

                entity.Property(e => e.ConditionUnitId).HasColumnName("condition_unit_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.QuizId).HasColumnName("quiz_id");
            });

            modelBuilder.Entity<HatsuneQuizReward>(entity =>
            {
                entity.HasKey(e => e.QuizId);

                entity.ToTable("hatsune_quiz_reward");

                entity.Property(e => e.QuizId)
                    .ValueGeneratedNever()
                    .HasColumnName("quiz_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<HatsuneRelayDatum>(entity =>
            {
                entity.HasKey(e => e.RelayStoryId);

                entity.ToTable("hatsune_relay_data");

                entity.Property(e => e.RelayStoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("relay_story_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.IsEnableRead).HasColumnName("is_enable_read");

                entity.Property(e => e.StorySeq).HasColumnName("story_seq");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");
            });

            modelBuilder.Entity<HatsuneSchedule>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("hatsune_schedule");

                entity.HasIndex(e => e.OriginalEventId, "hatsune_schedule_0_original_event_id");

                entity.HasIndex(e => e.SeriesEventId, "hatsune_schedule_0_series_event_id");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_id");

                entity.Property(e => e.BackgroudPosX).HasColumnName("backgroud_pos_x");

                entity.Property(e => e.BackgroudPosY).HasColumnName("backgroud_pos_y");

                entity.Property(e => e.BackgroudSizeX).HasColumnName("backgroud_size_x");

                entity.Property(e => e.BackgroudSizeY).HasColumnName("backgroud_size_y");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BannerUnitId).HasColumnName("banner_unit_id");

                entity.Property(e => e.CloseTime).HasColumnName("close_time");

                entity.Property(e => e.CountStartTime).HasColumnName("count_start_time");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.SeriesEventId).HasColumnName("series_event_id");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TeaserDialogType).HasColumnName("teaser_dialog_type");

                entity.Property(e => e.TeaserTime).HasColumnName("teaser_time");
            });

            modelBuilder.Entity<HatsuneSpecialBattle>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.Mode });

                entity.ToTable("hatsune_special_battle");

                entity.HasIndex(e => e.EventId, "hatsune_special_battle_0_event_id");

                entity.HasIndex(e => e.WaveGroupId, "hatsune_special_battle_0_wave_group_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.ActionStartSecond).HasColumnName("action_start_second");

                entity.Property(e => e.AppearTime).HasColumnName("appear_time");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.DetailBossMotion).HasColumnName("detail_boss_motion");

                entity.Property(e => e.HpGaugeColorFlag).HasColumnName("hp_gauge_color_flag");

                entity.Property(e => e.PurposeCount).HasColumnName("purpose_count");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.RecommendedLevel).HasColumnName("recommended_level");

                entity.Property(e => e.StartIdleTrigger).HasColumnName("start_idle_trigger");

                entity.Property(e => e.StoryIdModeEnd).HasColumnName("story_id_mode_end");

                entity.Property(e => e.StoryIdModeStart).HasColumnName("story_id_mode_start");

                entity.Property(e => e.StoryStartSecond).HasColumnName("story_start_second");

                entity.Property(e => e.TriggerHp).HasColumnName("trigger_hp");

                entity.Property(e => e.UnnecessaryDefeatChara).HasColumnName("unnecessary_defeat_chara");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<HatsuneSpecialBossTicketCount>(entity =>
            {
                entity.ToTable("hatsune_special_boss_ticket_count");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ChallengeCountFrom).HasColumnName("challenge_count_from");

                entity.Property(e => e.ChallengeCountTo).HasColumnName("challenge_count_to");

                entity.Property(e => e.UseTicketNum).HasColumnName("use_ticket_num");
            });

            modelBuilder.Entity<HatsuneSpecialEnemy>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("hatsune_special_enemy");

                entity.Property(e => e.EnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("enemy_id");

                entity.Property(e => e.EnemyPoint).HasColumnName("enemy_point");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.InitialPosition).HasColumnName("initial_position");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<HatsuneSpecialMissionDatum>(entity =>
            {
                entity.HasKey(e => e.SpecialMissionId);

                entity.ToTable("hatsune_special_mission_data");

                entity.Property(e => e.SpecialMissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("special_mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneStationaryMissionDatum>(entity =>
            {
                entity.HasKey(e => e.StationaryMissionId);

                entity.ToTable("hatsune_stationary_mission_data");

                entity.HasIndex(e => e.EventId, "hatsune_stationary_mission_data_0_event_id");

                entity.Property(e => e.StationaryMissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("stationary_mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneUnlockStoryCondition>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("hatsune_unlock_story_condition");

                entity.HasIndex(e => e.EventId, "hatsune_unlock_story_condition_0_event_id");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionEntry).HasColumnName("condition_entry");

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.ConditionTime).HasColumnName("condition_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");
            });

            modelBuilder.Entity<HatsuneUnlockUnitCondition>(entity =>
            {
                entity.ToTable("hatsune_unlock_unit_condition");

                entity.HasIndex(e => e.ConditionMissionId, "hatsune_unlock_unit_condition_0_condition_mission_id");

                entity.HasIndex(e => new { e.UnitId, e.EventId }, "hatsune_unlock_unit_condition_0_unit_id_1_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.Description1).HasColumnName("description_1");

                entity.Property(e => e.Description2).HasColumnName("description_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.TopDescription).HasColumnName("top_description");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<ItemDatum>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("item_data");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("item_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.GojuonOrder).HasColumnName("gojuon_order");

                entity.Property(e => e.ItemName).HasColumnName("item_name");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LimitNum).HasColumnName("limit_num");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.SellCheckDisp).HasColumnName("sell_check_disp");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ItemETicketDatum>(entity =>
            {
                entity.HasKey(e => new { e.TicketId, e.ExchangeNumber });

                entity.ToTable("item_e_ticket_data");

                entity.HasIndex(e => e.ExchangeNumber, "item_e_ticket_data_0_exchange_number");

                entity.HasIndex(e => e.TicketId, "item_e_ticket_data_0_ticket_id");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.Property(e => e.ExchangeNumber).HasColumnName("exchange_number");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<KaiserAddTimesDatum>(entity =>
            {
                entity.ToTable("kaiser_add_times_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddTimes).HasColumnName("add_times");

                entity.Property(e => e.AddTimesTime).HasColumnName("add_times_time");

                entity.Property(e => e.Duration).HasColumnName("duration");
            });

            modelBuilder.Entity<KaiserExterminationReward>(entity =>
            {
                entity.HasKey(e => e.ExterminationRewardGroup);

                entity.ToTable("kaiser_extermination_reward");

                entity.Property(e => e.ExterminationRewardGroup)
                    .ValueGeneratedNever()
                    .HasColumnName("extermination_reward_group");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<KaiserQuestDatum>(entity =>
            {
                entity.HasKey(e => e.KaiserBossId);

                entity.ToTable("kaiser_quest_data");

                entity.Property(e => e.KaiserBossId)
                    .ValueGeneratedNever()
                    .HasColumnName("kaiser_boss_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleFinishStoryId).HasColumnName("battle_finish_story_id");

                entity.Property(e => e.BattleStartStoryId).HasColumnName("battle_start_story_id");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.ClearStoryId1).HasColumnName("clear_story_id_1");

                entity.Property(e => e.ClearStoryId2).HasColumnName("clear_story_id_2");

                entity.Property(e => e.DisappearanceStoryId).HasColumnName("disappearance_story_id");

                entity.Property(e => e.EnemyLocalPositionY).HasColumnName("enemy_local_position_y");

                entity.Property(e => e.EnemyPositionX).HasColumnName("enemy_position_x");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.ExterminationRewardGroup).HasColumnName("extermination_reward_group");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.RestrictionGroupId).HasColumnName("restriction_group_id");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.WaveBgm).HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<KaiserRestrictionGroup>(entity =>
            {
                entity.HasKey(e => new { e.RestrictionGroupId, e.UnitId });

                entity.ToTable("kaiser_restriction_group");

                entity.HasIndex(e => e.RestrictionGroupId, "kaiser_restriction_group_0_restriction_group_id");

                entity.Property(e => e.RestrictionGroupId).HasColumnName("restriction_group_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<KaiserSchedule>(entity =>
            {
                entity.ToTable("kaiser_schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AfterBg).HasColumnName("after_bg");

                entity.Property(e => e.AfterBgm).HasColumnName("after_bgm");

                entity.Property(e => e.CloseStoryConditionId).HasColumnName("close_story_condition_id");

                entity.Property(e => e.CloseStoryId).HasColumnName("close_story_id");

                entity.Property(e => e.CloseTime).HasColumnName("close_time");

                entity.Property(e => e.CountStartTime).HasColumnName("count_start_time");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TeaserTime).HasColumnName("teaser_time");

                entity.Property(e => e.TopBg).HasColumnName("top_bg");

                entity.Property(e => e.TopBgm).HasColumnName("top_bgm");
            });

            modelBuilder.Entity<KaiserSpecialBattle>(entity =>
            {
                entity.HasKey(e => e.Mode);

                entity.ToTable("kaiser_special_battle");

                entity.Property(e => e.Mode)
                    .ValueGeneratedNever()
                    .HasColumnName("mode");

                entity.Property(e => e.ActionStartSecond).HasColumnName("action_start_second");

                entity.Property(e => e.AppearTime).HasColumnName("appear_time");

                entity.Property(e => e.HpGaugeColorFlag).HasColumnName("hp_gauge_color_flag");

                entity.Property(e => e.PurposeCount).HasColumnName("purpose_count");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.RecommendedLevel).HasColumnName("recommended_level");

                entity.Property(e => e.StartIdleTrigger).HasColumnName("start_idle_trigger");

                entity.Property(e => e.StoryIdModeEnd).HasColumnName("story_id_mode_end");

                entity.Property(e => e.StoryIdModeStart).HasColumnName("story_id_mode_start");

                entity.Property(e => e.StoryStartSecond).HasColumnName("story_start_second");

                entity.Property(e => e.TriggerHp).HasColumnName("trigger_hp");

                entity.Property(e => e.UnnecessaryDefeatChara).HasColumnName("unnecessary_defeat_chara");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<KmkNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("kmk_navi_comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName).HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<KmkReward>(entity =>
            {
                entity.ToTable("kmk_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.KmkScore).HasColumnName("kmk_score");

                entity.Property(e => e.MissionDetail).HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<LoginBonusAdv>(entity =>
            {
                entity.ToTable("login_bonus_adv");

                entity.HasIndex(e => e.LoginBonusId, "login_bonus_adv_0_login_bonus_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.CountKey).HasColumnName("count_key");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.ReadProcessFlag).HasColumnName("read_process_flag");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<LoginBonusDatum>(entity =>
            {
                entity.HasKey(e => e.LoginBonusId);

                entity.ToTable("login_bonus_data");

                entity.Property(e => e.LoginBonusId)
                    .ValueGeneratedNever()
                    .HasColumnName("login_bonus_id");

                entity.Property(e => e.AdvPlayType).HasColumnName("adv_play_type");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.CountNum).HasColumnName("count_num");

                entity.Property(e => e.CountType).HasColumnName("count_type");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LoginBonusType).HasColumnName("login_bonus_type");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.StampId).HasColumnName("stamp_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<LoginBonusDetail>(entity =>
            {
                entity.ToTable("login_bonus_detail");

                entity.HasIndex(e => new { e.LoginBonusId, e.Count }, "login_bonus_detail_0_login_bonus_id_1_count");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName).HasColumnName("character_name");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<LoginBonusMessageDatum>(entity =>
            {
                entity.ToTable("login_bonus_message_data");

                entity.HasIndex(e => e.LoginBonusId, "login_bonus_message_data_0_login_bonus_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalParam).HasColumnName("additional_param");

                entity.Property(e => e.AdditionalType).HasColumnName("additional_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName).HasColumnName("character_name");

                entity.Property(e => e.DayCount).HasColumnName("day_count");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.LuckPattern).HasColumnName("luck_pattern");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<LoveChara>(entity =>
            {
                entity.HasKey(e => e.LoveLevel);

                entity.ToTable("love_chara");

                entity.Property(e => e.LoveLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("love_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.TotalLove).HasColumnName("total_love");

                entity.Property(e => e.UnlockedClass).HasColumnName("unlocked_class");
            });

            modelBuilder.Entity<LtoLetterScript>(entity =>
            {
                entity.ToTable("lto_letter_script");

                entity.HasIndex(e => e.LetterId, "lto_letter_script_0_letter_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName).HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LetterId).HasColumnName("letter_id");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName).HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<LtoStoryDatum>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("lto_story_data");

                entity.HasIndex(e => e.EventId, "lto_story_data_0_event_id");

                entity.Property(e => e.SubStoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("sub_story_id");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.RewardCount).HasColumnName("reward_count");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<Minigame>(entity =>
            {
                entity.HasKey(e => e.MinigameSchemeId);

                entity.ToTable("minigame");

                entity.HasIndex(e => e.EventId, "minigame_0_event_id");

                entity.Property(e => e.MinigameSchemeId)
                    .ValueGeneratedNever()
                    .HasColumnName("minigame_scheme_id");

                entity.Property(e => e.ConditionsId1).HasColumnName("conditions_id_1");

                entity.Property(e => e.DisplayConditionId).HasColumnName("display_condition_id");

                entity.Property(e => e.DisplayConditionType).HasColumnName("display_condition_type");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FirstTimeStoryId).HasColumnName("first_time_story_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEnabledZeroScore).HasColumnName("is_enabled_zero_score");

                entity.Property(e => e.ReleaseConditions1).HasColumnName("release_conditions_1");

                entity.Property(e => e.ResultChatConditionId).HasColumnName("result_chat_condition_id");

                entity.Property(e => e.ScoreUnit).HasColumnName("score_unit");
            });

            modelBuilder.Entity<MissionRewardDatum>(entity =>
            {
                entity.ToTable("mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId, "mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LvFrom).HasColumnName("lv_from");

                entity.Property(e => e.LvTo).HasColumnName("lv_to");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movie");

                entity.HasIndex(e => e.StoryId, "movie_0_story_id");

                entity.Property(e => e.MovieId)
                    .ValueGeneratedNever()
                    .HasColumnName("movie_id");

                entity.Property(e => e.BgmId).HasColumnName("bgm_id");

                entity.Property(e => e.BgmVolumeRate).HasColumnName("bgm_volume_rate");

                entity.Property(e => e.FadeLoopFlag).HasColumnName("fade_loop_flag");

                entity.Property(e => e.MyPageFlag).HasColumnName("my_page_flag");

                entity.Property(e => e.SeId).HasColumnName("se_id");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<MusicContent>(entity =>
            {
                entity.HasKey(e => e.MusicId);

                entity.ToTable("music_content");

                entity.Property(e => e.MusicId)
                    .ValueGeneratedNever()
                    .HasColumnName("music_id");

                entity.Property(e => e.CueId).HasColumnName("cue_id");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.ListenStartTime).HasColumnName("listen_start_time");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.TotalPlayingTime).HasColumnName("total_playing_time");
            });

            modelBuilder.Entity<MusicList>(entity =>
            {
                entity.HasKey(e => e.MusicId);

                entity.ToTable("music_list");

                entity.Property(e => e.MusicId)
                    .ValueGeneratedNever()
                    .HasColumnName("music_id");

                entity.Property(e => e.AndroidUrl).HasColumnName("android_url");

                entity.Property(e => e.CostItemNum).HasColumnName("cost_item_num");

                entity.Property(e => e.DmmUrl).HasColumnName("dmm_url");

                entity.Property(e => e.FontSize).HasColumnName("font_size");

                entity.Property(e => e.IosUrl).HasColumnName("ios_url");

                entity.Property(e => e.Kana).HasColumnName("kana");

                entity.Property(e => e.ListName).HasColumnName("list_name");

                entity.Property(e => e.PreShopStart).HasColumnName("pre_shop_start");

                entity.Property(e => e.ShopEnd).HasColumnName("shop_end");

                entity.Property(e => e.ShopStart).HasColumnName("shop_start");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<MyprofileContent>(entity =>
            {
                entity.ToTable("myprofile_content");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<NaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("navi_comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName).HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<NotifDatum>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.NotifType });

                entity.ToTable("notif_data");

                entity.HasIndex(e => e.UnitId, "notif_data_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.NotifType).HasColumnName("notif_type");

                entity.Property(e => e.Comment).HasColumnName("comment");
            });

            modelBuilder.Entity<NyxDramaDatum>(entity =>
            {
                entity.HasKey(e => e.DramaId);

                entity.ToTable("nyx_drama_data");

                entity.Property(e => e.DramaId)
                    .ValueGeneratedNever()
                    .HasColumnName("drama_id");

                entity.Property(e => e.ConditionLockedStoryId).HasColumnName("condition_locked_story_id");

                entity.Property(e => e.ConditionUnlockedStoryId).HasColumnName("condition_unlocked_story_id");

                entity.Property(e => e.StoryPhase).HasColumnName("story_phase");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<NyxDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("nyx_drama_script");

                entity.HasIndex(e => e.DramaId, "nyx_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .ValueGeneratedNever()
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01).HasColumnName("param_01");

                entity.Property(e => e.Param02).HasColumnName("param_02");

                entity.Property(e => e.Param03).HasColumnName("param_03");

                entity.Property(e => e.Param04).HasColumnName("param_04");

                entity.Property(e => e.Param05).HasColumnName("param_05");

                entity.Property(e => e.Param06).HasColumnName("param_06");

                entity.Property(e => e.Param07).HasColumnName("param_07");

                entity.Property(e => e.Param08).HasColumnName("param_08");
            });

            modelBuilder.Entity<NyxPhaseDatum>(entity =>
            {
                entity.HasKey(e => e.StoryPhase);

                entity.ToTable("nyx_phase_data");

                entity.Property(e => e.StoryPhase)
                    .ValueGeneratedNever()
                    .HasColumnName("story_phase");

                entity.Property(e => e.ConditionQuestBoss).HasColumnName("condition_quest_boss");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.PhaseTitle).HasColumnName("phase_title");
            });

            modelBuilder.Entity<NyxStoryDatum>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("nyx_story_data");

                entity.HasIndex(e => e.StoryPhase, "nyx_story_data_0_story_phase");

                entity.HasIndex(e => e.StorySeq, "nyx_story_data_0_story_seq");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.AdvFlg).HasColumnName("adv_flg");

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.ConditionBossCount).HasColumnName("condition_boss_count");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ReadConditionTime).HasColumnName("read_condition_time");

                entity.Property(e => e.StoryPhase).HasColumnName("story_phase");

                entity.Property(e => e.StorySeq).HasColumnName("story_seq");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<NyxStoryScript>(entity =>
            {
                entity.ToTable("nyx_story_script");

                entity.HasIndex(e => e.StoryId, "nyx_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName).HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName).HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<OddsNameDatum>(entity =>
            {
                entity.ToTable("odds_name_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OddsFile).HasColumnName("odds_file");
            });

            modelBuilder.Entity<OmpDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("omp_drama");

                entity.HasIndex(e => e.DramaId, "omp_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .ValueGeneratedNever()
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01).HasColumnName("param_01");

                entity.Property(e => e.Param02).HasColumnName("param_02");

                entity.Property(e => e.Param03).HasColumnName("param_03");

                entity.Property(e => e.Param04).HasColumnName("param_04");

                entity.Property(e => e.Param05).HasColumnName("param_05");

                entity.Property(e => e.Param06).HasColumnName("param_06");

                entity.Property(e => e.Param07).HasColumnName("param_07");

                entity.Property(e => e.Param08).HasColumnName("param_08");
            });

            modelBuilder.Entity<OmpStoryDatum>(entity =>
            {
                entity.HasKey(e => e.OmpStoryId);

                entity.ToTable("omp_story_data");

                entity.HasIndex(e => e.EventId, "omp_story_data_0_event_id");

                entity.HasIndex(e => e.StorySeq, "omp_story_data_0_story_seq");

                entity.Property(e => e.OmpStoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("omp_story_id");

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IsReadableOnResult).HasColumnName("is_readable_on_result");

                entity.Property(e => e.RewardCount).HasColumnName("reward_count");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.StorySeq).HasColumnName("story_seq");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");
            });

            modelBuilder.Entity<PctComboCoefficient>(entity =>
            {
                entity.ToTable("pct_combo_coefficient");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ComboCoefficient).HasColumnName("combo_coefficient");

                entity.Property(e => e.ComboMax).HasColumnName("combo_max");

                entity.Property(e => e.ComboMin).HasColumnName("combo_min");
            });

            modelBuilder.Entity<PctEvaluation>(entity =>
            {
                entity.HasKey(e => e.EvaluationId);

                entity.ToTable("pct_evaluation");

                entity.Property(e => e.EvaluationId)
                    .ValueGeneratedNever()
                    .HasColumnName("evaluation_id");

                entity.Property(e => e.EvaluationPoint).HasColumnName("evaluation_point");

                entity.Property(e => e.FeverPoint).HasColumnName("fever_point");

                entity.Property(e => e.MeetWidth).HasColumnName("meet_width");
            });

            modelBuilder.Entity<PctGamingMotion>(entity =>
            {
                entity.HasKey(e => e.MotionId);

                entity.ToTable("pct_gaming_motion");

                entity.Property(e => e.MotionId)
                    .ValueGeneratedNever()
                    .HasColumnName("motion_id");

                entity.Property(e => e.GoodCount).HasColumnName("good_count");

                entity.Property(e => e.NiceCount).HasColumnName("nice_count");

                entity.Property(e => e.PerfectCount).HasColumnName("perfect_count");

                entity.Property(e => e.Point).HasColumnName("point");
            });

            modelBuilder.Entity<PctItempoint>(entity =>
            {
                entity.ToTable("pct_itempoint");

                entity.HasIndex(e => e.ItemId, "pct_itempoint_0_item_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PctPointCoefficient).HasColumnName("pct_point_coefficient");
            });

            modelBuilder.Entity<PctResult>(entity =>
            {
                entity.ToTable("pct_result");

                entity.HasIndex(e => e.CharacterId, "pct_result_0_character_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CommentId1).HasColumnName("comment_id_1");

                entity.Property(e => e.CommentId2).HasColumnName("comment_id_2");

                entity.Property(e => e.CommentId3).HasColumnName("comment_id_3");

                entity.Property(e => e.CommentId4).HasColumnName("comment_id_4");

                entity.Property(e => e.CommentId5).HasColumnName("comment_id_5");

                entity.Property(e => e.ScoreFrom).HasColumnName("score_from");

                entity.Property(e => e.ScoreTo).HasColumnName("score_to");
            });

            modelBuilder.Entity<PctReward>(entity =>
            {
                entity.ToTable("pct_reward");

                entity.HasIndex(e => e.PctPointType, "pct_reward_0_pct_point_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MissionDetail).HasColumnName("mission_detail");

                entity.Property(e => e.PctPoint).HasColumnName("pct_point");

                entity.Property(e => e.PctPointType).HasColumnName("pct_point_type");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<PctSystem>(entity =>
            {
                entity.ToTable("pct_system");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Chara1).HasColumnName("chara1");

                entity.Property(e => e.Chara1GaugeChoice).HasColumnName("chara1_gauge_choice");

                entity.Property(e => e.Chara2).HasColumnName("chara2");

                entity.Property(e => e.Chara2GaugeChoice).HasColumnName("chara2_gauge_choice");

                entity.Property(e => e.FeverPointMax).HasColumnName("fever_point_max");

                entity.Property(e => e.FeverReventionTime).HasColumnName("fever_revention_time");

                entity.Property(e => e.FeverTime).HasColumnName("fever_time");

                entity.Property(e => e.PctBaseSpeed).HasColumnName("pct_base_speed");

                entity.Property(e => e.PctTime).HasColumnName("pct_time");
            });

            modelBuilder.Entity<PctSystemFruit>(entity =>
            {
                entity.ToTable("pct_system_fruits");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Appearance).HasColumnName("appearance");

                entity.Property(e => e.AppearanceCharaOdds).HasColumnName("appearance_chara_odds");

                entity.Property(e => e.AppearancePattern).HasColumnName("appearance_pattern");

                entity.Property(e => e.BarSplit).HasColumnName("bar_split");

                entity.Property(e => e.LastTime).HasColumnName("last_time");

                entity.Property(e => e.WaitTime).HasColumnName("wait_time");
            });

            modelBuilder.Entity<PctTapSpeed>(entity =>
            {
                entity.ToTable("pct_tap_speed");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ComboCount).HasColumnName("combo_count");

                entity.Property(e => e.SpeedMagnification).HasColumnName("speed_magnification");
            });

            modelBuilder.Entity<PkbBatterCondition>(entity =>
            {
                entity.HasKey(e => e.BatterId);

                entity.ToTable("pkb_batter_condition");

                entity.Property(e => e.BatterId)
                    .ValueGeneratedNever()
                    .HasColumnName("batter_id");

                entity.Property(e => e.AbilityDetail).HasColumnName("ability_detail");

                entity.Property(e => e.AbilityName).HasColumnName("ability_name");

                entity.Property(e => e.Critical).HasColumnName("critical");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.IsPlayable).HasColumnName("is_playable");

                entity.Property(e => e.Meet).HasColumnName("meet");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PkbScore).HasColumnName("pkb_score");

                entity.Property(e => e.Power).HasColumnName("power");
            });

            modelBuilder.Entity<PkbDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("pkb_drama");

                entity.HasIndex(e => e.DramaId, "pkb_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .ValueGeneratedNever()
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01).HasColumnName("param_01");

                entity.Property(e => e.Param02).HasColumnName("param_02");

                entity.Property(e => e.Param03).HasColumnName("param_03");

                entity.Property(e => e.Param04).HasColumnName("param_04");

                entity.Property(e => e.Param05).HasColumnName("param_05");

                entity.Property(e => e.Param06).HasColumnName("param_06");

                entity.Property(e => e.Param07).HasColumnName("param_07");

                entity.Property(e => e.Param08).HasColumnName("param_08");
            });

            modelBuilder.Entity<PkbDramaDatum>(entity =>
            {
                entity.HasKey(e => e.DramaId);

                entity.ToTable("pkb_drama_data");

                entity.Property(e => e.DramaId)
                    .ValueGeneratedNever()
                    .HasColumnName("drama_id");

                entity.Property(e => e.ConditionBatterId1).HasColumnName("condition_batter_id_1");

                entity.Property(e => e.ConditionBatterId2).HasColumnName("condition_batter_id_2");

                entity.Property(e => e.ConditionPitcherId1).HasColumnName("condition_pitcher_id_1");

                entity.Property(e => e.ConditionPitcherId2).HasColumnName("condition_pitcher_id_2");
            });

            modelBuilder.Entity<PkbNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("pkb_navi_comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName).HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<PkbPitcherBallType>(entity =>
            {
                entity.HasKey(e => new { e.PitcherId, e.BallType });

                entity.ToTable("pkb_pitcher_ball_type");

                entity.HasIndex(e => e.PitcherId, "pkb_pitcher_ball_type_0_pitcher_id");

                entity.Property(e => e.PitcherId).HasColumnName("pitcher_id");

                entity.Property(e => e.BallType).HasColumnName("ball_type");

                entity.Property(e => e.BallTypeName).HasColumnName("ball_type_name");
            });

            modelBuilder.Entity<PkbReward>(entity =>
            {
                entity.ToTable("pkb_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MissionDetail).HasColumnName("mission_detail");

                entity.Property(e => e.PkbScore).HasColumnName("pkb_score");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<PositionSetting>(entity =>
            {
                entity.ToTable("position_setting");

                entity.Property(e => e.PositionSettingId)
                    .ValueGeneratedNever()
                    .HasColumnName("position_setting_id");

                entity.Property(e => e.Front).HasColumnName("front");

                entity.Property(e => e.Middle).HasColumnName("middle");
            });

            modelBuilder.Entity<PrizegachaDatum>(entity =>
            {
                entity.HasKey(e => e.PrizegachaId);

                entity.ToTable("prizegacha_data");

                entity.Property(e => e.PrizegachaId)
                    .ValueGeneratedNever()
                    .HasColumnName("prizegacha_id");

                entity.Property(e => e.GachaPrize1).HasColumnName("gacha_prize1");

                entity.Property(e => e.GachaPrize10).HasColumnName("gacha_prize10");

                entity.Property(e => e.PrizeFixedCompensation).HasColumnName("prize_fixed_compensation");

                entity.Property(e => e.PrizeFixedCompensationQuantity).HasColumnName("prize_fixed_compensation_quantity");

                entity.Property(e => e.PrizeMemoryId1).HasColumnName("prize_memory_id_1");

                entity.Property(e => e.PrizeMemoryId10).HasColumnName("prize_memory_id_10");

                entity.Property(e => e.PrizeMemoryId11).HasColumnName("prize_memory_id_11");

                entity.Property(e => e.PrizeMemoryId12).HasColumnName("prize_memory_id_12");

                entity.Property(e => e.PrizeMemoryId13).HasColumnName("prize_memory_id_13");

                entity.Property(e => e.PrizeMemoryId14).HasColumnName("prize_memory_id_14");

                entity.Property(e => e.PrizeMemoryId15).HasColumnName("prize_memory_id_15");

                entity.Property(e => e.PrizeMemoryId16).HasColumnName("prize_memory_id_16");

                entity.Property(e => e.PrizeMemoryId17).HasColumnName("prize_memory_id_17");

                entity.Property(e => e.PrizeMemoryId18).HasColumnName("prize_memory_id_18");

                entity.Property(e => e.PrizeMemoryId19).HasColumnName("prize_memory_id_19");

                entity.Property(e => e.PrizeMemoryId2).HasColumnName("prize_memory_id_2");

                entity.Property(e => e.PrizeMemoryId20).HasColumnName("prize_memory_id_20");

                entity.Property(e => e.PrizeMemoryId3).HasColumnName("prize_memory_id_3");

                entity.Property(e => e.PrizeMemoryId4).HasColumnName("prize_memory_id_4");

                entity.Property(e => e.PrizeMemoryId5).HasColumnName("prize_memory_id_5");

                entity.Property(e => e.PrizeMemoryId6).HasColumnName("prize_memory_id_6");

                entity.Property(e => e.PrizeMemoryId7).HasColumnName("prize_memory_id_7");

                entity.Property(e => e.PrizeMemoryId8).HasColumnName("prize_memory_id_8");

                entity.Property(e => e.PrizeMemoryId9).HasColumnName("prize_memory_id_9");

                entity.Property(e => e.RarityOdds).HasColumnName("rarity_odds");
            });

            modelBuilder.Entity<ProfileFrame>(entity =>
            {
                entity.ToTable("profile_frame");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<PromotionBonu>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.PromotionLevel });

                entity.ToTable("promotion_bonus");

                entity.HasIndex(e => e.UnitId, "promotion_bonus_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<QuestAnnihilation>(entity =>
            {
                entity.HasKey(e => new { e.SystemId, e.QuestId });

                entity.ToTable("quest_annihilation");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.EffectType).HasColumnName("effect_type");

                entity.Property(e => e.QuestEffectPosition).HasColumnName("quest_effect_position");
            });

            modelBuilder.Entity<QuestAreaDatum>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("quest_area_data");

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("area_id");

                entity.Property(e => e.AreaDisplayName).HasColumnName("area_display_name");

                entity.Property(e => e.AreaName).HasColumnName("area_name");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<QuestConditionDatum>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("quest_condition_data");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.ConditionQuestId1).HasColumnName("condition_quest_id_1");

                entity.Property(e => e.ConditionQuestId2).HasColumnName("condition_quest_id_2");

                entity.Property(e => e.ConditionQuestId3).HasColumnName("condition_quest_id_3");

                entity.Property(e => e.ConditionQuestId4).HasColumnName("condition_quest_id_4");

                entity.Property(e => e.ConditionQuestId5).HasColumnName("condition_quest_id_5");

                entity.Property(e => e.ReleaseQuestId1).HasColumnName("release_quest_id_1");

                entity.Property(e => e.ReleaseQuestId2).HasColumnName("release_quest_id_2");

                entity.Property(e => e.ReleaseQuestId3).HasColumnName("release_quest_id_3");

                entity.Property(e => e.ReleaseQuestId4).HasColumnName("release_quest_id_4");

                entity.Property(e => e.ReleaseQuestId5).HasColumnName("release_quest_id_5");
            });

            modelBuilder.Entity<QuestDatum>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("quest_data");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.AddTreasureNum).HasColumnName("add_treasure_num");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LimitTeamLevel).HasColumnName("limit_team_level");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.LvRewardFlag).HasColumnName("lv_reward_flag");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWaveend2).HasColumnName("story_id_waveend_2");

                entity.Property(e => e.StoryIdWaveend3).HasColumnName("story_id_waveend_3");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.StoryIdWavestart2).HasColumnName("story_id_wavestart_2");

                entity.Property(e => e.StoryIdWavestart3).HasColumnName("story_id_wavestart_3");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2).HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3).HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2).HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3).HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<QuestDefeatNotice>(entity =>
            {
                entity.ToTable("quest_defeat_notice");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.RequiredQuestId).HasColumnName("required_quest_id");

                entity.Property(e => e.RequiredTeamLevel).HasColumnName("required_team_level");
            });

            modelBuilder.Entity<QuestRewardDatum>(entity =>
            {
                entity.HasKey(e => e.RewardGroupId);

                entity.ToTable("quest_reward_data");

                entity.Property(e => e.RewardGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("reward_group_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<Rarity6QuestDatum>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("rarity_6_quest_data");

                entity.HasIndex(e => e.Rarity6QuestId, "rarity_6_quest_data_0_rarity_6_quest_id");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.EnemyLocalPositionY1).HasColumnName("enemy_local_position_y_1");

                entity.Property(e => e.EnemyLocalPositionY2).HasColumnName("enemy_local_position_y_2");

                entity.Property(e => e.EnemyLocalPositionY3).HasColumnName("enemy_local_position_y_3");

                entity.Property(e => e.EnemyLocalPositionY4).HasColumnName("enemy_local_position_y_4");

                entity.Property(e => e.EnemyLocalPositionY5).HasColumnName("enemy_local_position_y_5");

                entity.Property(e => e.EnemyPositionX1).HasColumnName("enemy_position_x_1");

                entity.Property(e => e.EnemyPositionX2).HasColumnName("enemy_position_x_2");

                entity.Property(e => e.EnemyPositionX3).HasColumnName("enemy_position_x_3");

                entity.Property(e => e.EnemyPositionX4).HasColumnName("enemy_position_x_4");

                entity.Property(e => e.EnemyPositionX5).HasColumnName("enemy_position_x_5");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.EnemySize2).HasColumnName("enemy_size_2");

                entity.Property(e => e.EnemySize3).HasColumnName("enemy_size_3");

                entity.Property(e => e.EnemySize4).HasColumnName("enemy_size_4");

                entity.Property(e => e.EnemySize5).HasColumnName("enemy_size_5");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.Rarity6QuestId).HasColumnName("rarity_6_quest_id");

                entity.Property(e => e.RecommendedLevel).HasColumnName("recommended_level");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardGroupId).HasColumnName("reward_group_id");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.TreasureType).HasColumnName("treasure_type");

                entity.Property(e => e.WaveBgm).HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<ResistDatum>(entity =>
            {
                entity.HasKey(e => e.ResistStatusId);

                entity.ToTable("resist_data");

                entity.Property(e => e.ResistStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("resist_status_id");

                entity.Property(e => e.Ailment1).HasColumnName("ailment_1");

                entity.Property(e => e.Ailment10).HasColumnName("ailment_10");

                entity.Property(e => e.Ailment11).HasColumnName("ailment_11");

                entity.Property(e => e.Ailment12).HasColumnName("ailment_12");

                entity.Property(e => e.Ailment13).HasColumnName("ailment_13");

                entity.Property(e => e.Ailment14).HasColumnName("ailment_14");

                entity.Property(e => e.Ailment15).HasColumnName("ailment_15");

                entity.Property(e => e.Ailment16).HasColumnName("ailment_16");

                entity.Property(e => e.Ailment17).HasColumnName("ailment_17");

                entity.Property(e => e.Ailment18).HasColumnName("ailment_18");

                entity.Property(e => e.Ailment19).HasColumnName("ailment_19");

                entity.Property(e => e.Ailment2).HasColumnName("ailment_2");

                entity.Property(e => e.Ailment20).HasColumnName("ailment_20");

                entity.Property(e => e.Ailment21).HasColumnName("ailment_21");

                entity.Property(e => e.Ailment22).HasColumnName("ailment_22");

                entity.Property(e => e.Ailment23).HasColumnName("ailment_23");

                entity.Property(e => e.Ailment24).HasColumnName("ailment_24");

                entity.Property(e => e.Ailment25).HasColumnName("ailment_25");

                entity.Property(e => e.Ailment26).HasColumnName("ailment_26");

                entity.Property(e => e.Ailment27).HasColumnName("ailment_27");

                entity.Property(e => e.Ailment28).HasColumnName("ailment_28");

                entity.Property(e => e.Ailment29).HasColumnName("ailment_29");

                entity.Property(e => e.Ailment3).HasColumnName("ailment_3");

                entity.Property(e => e.Ailment30).HasColumnName("ailment_30");

                entity.Property(e => e.Ailment31).HasColumnName("ailment_31");

                entity.Property(e => e.Ailment32).HasColumnName("ailment_32");

                entity.Property(e => e.Ailment33).HasColumnName("ailment_33");

                entity.Property(e => e.Ailment34).HasColumnName("ailment_34");

                entity.Property(e => e.Ailment35).HasColumnName("ailment_35");

                entity.Property(e => e.Ailment36).HasColumnName("ailment_36");

                entity.Property(e => e.Ailment37).HasColumnName("ailment_37");

                entity.Property(e => e.Ailment38).HasColumnName("ailment_38");

                entity.Property(e => e.Ailment39).HasColumnName("ailment_39");

                entity.Property(e => e.Ailment4).HasColumnName("ailment_4");

                entity.Property(e => e.Ailment40).HasColumnName("ailment_40");

                entity.Property(e => e.Ailment41).HasColumnName("ailment_41");

                entity.Property(e => e.Ailment42).HasColumnName("ailment_42");

                entity.Property(e => e.Ailment43).HasColumnName("ailment_43");

                entity.Property(e => e.Ailment44).HasColumnName("ailment_44");

                entity.Property(e => e.Ailment45).HasColumnName("ailment_45");

                entity.Property(e => e.Ailment46).HasColumnName("ailment_46");

                entity.Property(e => e.Ailment47).HasColumnName("ailment_47");

                entity.Property(e => e.Ailment48).HasColumnName("ailment_48");

                entity.Property(e => e.Ailment49).HasColumnName("ailment_49");

                entity.Property(e => e.Ailment5).HasColumnName("ailment_5");

                entity.Property(e => e.Ailment50).HasColumnName("ailment_50");

                entity.Property(e => e.Ailment6).HasColumnName("ailment_6");

                entity.Property(e => e.Ailment7).HasColumnName("ailment_7");

                entity.Property(e => e.Ailment8).HasColumnName("ailment_8");

                entity.Property(e => e.Ailment9).HasColumnName("ailment_9");
            });

            modelBuilder.Entity<ReturnSpecialfesBanner>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("return_specialfes_banner");

                entity.Property(e => e.GachaId)
                    .ValueGeneratedNever()
                    .HasColumnName("gacha_id");

                entity.Property(e => e.BannerId1).HasColumnName("banner_id_1");

                entity.Property(e => e.BannerId10).HasColumnName("banner_id_10");

                entity.Property(e => e.BannerId2).HasColumnName("banner_id_2");

                entity.Property(e => e.BannerId3).HasColumnName("banner_id_3");

                entity.Property(e => e.BannerId4).HasColumnName("banner_id_4");

                entity.Property(e => e.BannerId5).HasColumnName("banner_id_5");

                entity.Property(e => e.BannerId6).HasColumnName("banner_id_6");

                entity.Property(e => e.BannerId7).HasColumnName("banner_id_7");

                entity.Property(e => e.BannerId8).HasColumnName("banner_id_8");

                entity.Property(e => e.BannerId9).HasColumnName("banner_id_9");
            });

            modelBuilder.Entity<RewardCollectGuide>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("reward_collect_guide");

                entity.Property(e => e.ObjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("object_id");

                entity.Property(e => e.QuestId1).HasColumnName("quest_id_1");

                entity.Property(e => e.QuestId10).HasColumnName("quest_id_10");

                entity.Property(e => e.QuestId2).HasColumnName("quest_id_2");

                entity.Property(e => e.QuestId3).HasColumnName("quest_id_3");

                entity.Property(e => e.QuestId4).HasColumnName("quest_id_4");

                entity.Property(e => e.QuestId5).HasColumnName("quest_id_5");

                entity.Property(e => e.QuestId6).HasColumnName("quest_id_6");

                entity.Property(e => e.QuestId7).HasColumnName("quest_id_7");

                entity.Property(e => e.QuestId8).HasColumnName("quest_id_8");

                entity.Property(e => e.QuestId9).HasColumnName("quest_id_9");

                entity.Property(e => e.SystemId1).HasColumnName("system_id_1");

                entity.Property(e => e.SystemId2).HasColumnName("system_id_2");

                entity.Property(e => e.SystemId3).HasColumnName("system_id_3");

                entity.Property(e => e.SystemId4).HasColumnName("system_id_4");

                entity.Property(e => e.SystemId5).HasColumnName("system_id_5");
            });

            modelBuilder.Entity<RoomChange>(entity =>
            {
                entity.HasKey(e => e.RoomItemId);

                entity.ToTable("room_change");

                entity.Property(e => e.RoomItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("room_item_id");

                entity.Property(e => e.ChangeEnd).HasColumnName("change_end");

                entity.Property(e => e.ChangeId).HasColumnName("change_id");

                entity.Property(e => e.ChangeStart).HasColumnName("change_start");
            });

            modelBuilder.Entity<RoomCharacterPersonality>(entity =>
            {
                entity.HasKey(e => e.CharacterId);

                entity.ToTable("room_character_personality");

                entity.Property(e => e.CharacterId)
                    .ValueGeneratedNever()
                    .HasColumnName("character_id");

                entity.Property(e => e.PersonalityId).HasColumnName("personality_id");
            });

            modelBuilder.Entity<RoomCharacterSkinColor>(entity =>
            {
                entity.HasKey(e => e.CharacterId);

                entity.ToTable("room_character_skin_color");

                entity.Property(e => e.CharacterId)
                    .ValueGeneratedNever()
                    .HasColumnName("character_id");

                entity.Property(e => e.SkinColorId).HasColumnName("skin_color_id");
            });

            modelBuilder.Entity<RoomChatFormation>(entity =>
            {
                entity.ToTable("room_chat_formation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IgnoreUnitId1).HasColumnName("ignore_unit_id1");

                entity.Property(e => e.IgnoreUnitId2).HasColumnName("ignore_unit_id2");

                entity.Property(e => e.IgnoreUnitId3).HasColumnName("ignore_unit_id3");

                entity.Property(e => e.IgnoreUnitId4).HasColumnName("ignore_unit_id4");

                entity.Property(e => e.IgnoreUnitId5).HasColumnName("ignore_unit_id5");

                entity.Property(e => e.Unit1Dir).HasColumnName("unit_1_dir");

                entity.Property(e => e.Unit1X).HasColumnName("unit_1_x");

                entity.Property(e => e.Unit1Y).HasColumnName("unit_1_y");

                entity.Property(e => e.Unit2Dir).HasColumnName("unit_2_dir");

                entity.Property(e => e.Unit2X).HasColumnName("unit_2_x");

                entity.Property(e => e.Unit2Y).HasColumnName("unit_2_y");

                entity.Property(e => e.Unit3Dir).HasColumnName("unit_3_dir");

                entity.Property(e => e.Unit3X).HasColumnName("unit_3_x");

                entity.Property(e => e.Unit3Y).HasColumnName("unit_3_y");

                entity.Property(e => e.Unit4Dir).HasColumnName("unit_4_dir");

                entity.Property(e => e.Unit4X).HasColumnName("unit_4_x");

                entity.Property(e => e.Unit4Y).HasColumnName("unit_4_y");

                entity.Property(e => e.Unit5Dir).HasColumnName("unit_5_dir");

                entity.Property(e => e.Unit5X).HasColumnName("unit_5_x");

                entity.Property(e => e.Unit5Y).HasColumnName("unit_5_y");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id1");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id3");

                entity.Property(e => e.UnitId4).HasColumnName("unit_id4");

                entity.Property(e => e.UnitId5).HasColumnName("unit_id5");

                entity.Property(e => e.UnitNum).HasColumnName("unit_num");
            });

            modelBuilder.Entity<RoomChatInfo>(entity =>
            {
                entity.ToTable("room_chat_info");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FormationId).HasColumnName("formation_id");

                entity.Property(e => e.ScenarioId).HasColumnName("scenario_id");
            });

            modelBuilder.Entity<RoomChatScenario>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ScenarioIdx });

                entity.ToTable("room_chat_scenario");

                entity.HasIndex(e => e.Id, "room_chat_scenario_0_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ScenarioIdx).HasColumnName("scenario_idx");

                entity.Property(e => e.AffectType).HasColumnName("affect_type");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.Delay).HasColumnName("delay");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.UnitPosNo).HasColumnName("unit_pos_no");
            });

            modelBuilder.Entity<RoomEffect>(entity =>
            {
                entity.ToTable("room_effect");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Arcade).HasColumnName("arcade");

                entity.Property(e => e.Jukebox).HasColumnName("jukebox");

                entity.Property(e => e.Nebbia).HasColumnName("nebbia");

                entity.Property(e => e.Poster).HasColumnName("poster");

                entity.Property(e => e.RewardGet).HasColumnName("reward_get");

                entity.Property(e => e.Vegetable).HasColumnName("vegetable");
            });

            modelBuilder.Entity<RoomEffectRewardGet>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Level });

                entity.ToTable("room_effect_reward_get");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.IncStep).HasColumnName("inc_step");

                entity.Property(e => e.IntervalSecond).HasColumnName("interval_second");

                entity.Property(e => e.MaxCount).HasColumnName("max_count");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<RoomEmotionIcon>(entity =>
            {
                entity.ToTable("room_emotion_icon");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EnableAuto).HasColumnName("enable_auto");

                entity.Property(e => e.EnableTap).HasColumnName("enable_tap");
            });

            modelBuilder.Entity<RoomItem>(entity =>
            {
                entity.ToTable("room_item");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CategoryActionType).HasColumnName("category_action_type");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.CostItemNum).HasColumnName("cost_item_num");

                entity.Property(e => e.EffectId1).HasColumnName("effect_id_1");

                entity.Property(e => e.EnableRemove).HasColumnName("enable_remove");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MaxPossessionNum).HasColumnName("max_possession_num");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ShopEnd).HasColumnName("shop_end");

                entity.Property(e => e.ShopNewDispEnd).HasColumnName("shop_new_disp_end");

                entity.Property(e => e.ShopOpenId).HasColumnName("shop_open_id");

                entity.Property(e => e.ShopOpenType).HasColumnName("shop_open_type");

                entity.Property(e => e.ShopOpenValue).HasColumnName("shop_open_value");

                entity.Property(e => e.ShopStart).HasColumnName("shop_start");

                entity.Property(e => e.SoldPrice).HasColumnName("sold_price");

                entity.Property(e => e.Sort).HasColumnName("sort");
            });

            modelBuilder.Entity<RoomItemAnnouncement>(entity =>
            {
                entity.ToTable("room_item_announcement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AnnouncementEnd).HasColumnName("announcement_end");

                entity.Property(e => e.AnnouncementStart).HasColumnName("announcement_start");

                entity.Property(e => e.AnnouncementText).HasColumnName("announcement_text");
            });

            modelBuilder.Entity<RoomItemDetail>(entity =>
            {
                entity.HasKey(e => new { e.RoomItemId, e.Level });

                entity.ToTable("room_item_detail");

                entity.HasIndex(e => new { e.LvupTriggerType, e.LvupTriggerId }, "room_item_detail_0_lvup_trigger_type_1_lvup_trigger_id");

                entity.HasIndex(e => new { e.LvupTriggerType2, e.LvupTriggerId2 }, "room_item_detail_0_lvup_trigger_type_2_1_lvup_trigger_id_2");

                entity.Property(e => e.RoomItemId).HasColumnName("room_item_id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.ItemDetail).HasColumnName("item_detail");

                entity.Property(e => e.LvupItem1Id).HasColumnName("lvup_item1_id");

                entity.Property(e => e.LvupItem1Num).HasColumnName("lvup_item1_num");

                entity.Property(e => e.LvupItem1Type).HasColumnName("lvup_item1_type");

                entity.Property(e => e.LvupTime).HasColumnName("lvup_time");

                entity.Property(e => e.LvupTriggerId).HasColumnName("lvup_trigger_id");

                entity.Property(e => e.LvupTriggerId2).HasColumnName("lvup_trigger_id_2");

                entity.Property(e => e.LvupTriggerType).HasColumnName("lvup_trigger_type");

                entity.Property(e => e.LvupTriggerType2).HasColumnName("lvup_trigger_type_2");

                entity.Property(e => e.LvupTriggerValue).HasColumnName("lvup_trigger_value");

                entity.Property(e => e.LvupTriggerValue2).HasColumnName("lvup_trigger_value_2");
            });

            modelBuilder.Entity<RoomItemGetAnnouncement>(entity =>
            {
                entity.ToTable("room_item_get_announcement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.GetDate).HasColumnName("get_date");

                entity.Property(e => e.RoomItemId).HasColumnName("room_item_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");
            });

            modelBuilder.Entity<RoomReleaseDatum>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.ToTable("room_release_data");

                entity.Property(e => e.SystemId)
                    .ValueGeneratedNever()
                    .HasColumnName("system_id");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<RoomSetup>(entity =>
            {
                entity.HasKey(e => e.RoomItemId);

                entity.ToTable("room_setup");

                entity.Property(e => e.RoomItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("room_item_id");

                entity.Property(e => e.GridHeight).HasColumnName("grid_height");

                entity.Property(e => e.GridWidth).HasColumnName("grid_width");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<RoomSkinColor>(entity =>
            {
                entity.HasKey(e => e.SkinColorId);

                entity.ToTable("room_skin_color");

                entity.Property(e => e.SkinColorId)
                    .ValueGeneratedNever()
                    .HasColumnName("skin_color_id");

                entity.Property(e => e.ColorBlue).HasColumnName("color_blue");

                entity.Property(e => e.ColorGreen).HasColumnName("color_green");

                entity.Property(e => e.ColorRed).HasColumnName("color_red");
            });

            modelBuilder.Entity<RoomUnitComment>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.Trigger, e.VoiceId, e.Time });

                entity.ToTable("room_unit_comments");

                entity.HasIndex(e => e.UnitId, "room_unit_comments_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.Trigger).HasColumnName("trigger");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.BelovedStep).HasColumnName("beloved_step");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FaceId).HasColumnName("face_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertWordType).HasColumnName("insert_word_type");
            });

            modelBuilder.Entity<SdNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("sd_navi_comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MotionType).HasColumnName("motion_type");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<SeasonPack>(entity =>
            {
                entity.ToTable("season_pack");

                entity.HasIndex(e => e.MissionId, "season_pack_0_mission_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddNum1).HasColumnName("add_num_1");

                entity.Property(e => e.AfterText).HasColumnName("after_text");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionFlg).HasColumnName("condition_flg");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.GiftMessageId).HasColumnName("gift_message_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ItemRecordId).HasColumnName("item_record_id");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.ReceiveText).HasColumnName("receive_text");

                entity.Property(e => e.RepurchaseDay).HasColumnName("repurchase_day");

                entity.Property(e => e.RewardRate1).HasColumnName("reward_rate_1");

                entity.Property(e => e.SystemId1).HasColumnName("system_id_1");

                entity.Property(e => e.Term).HasColumnName("term");
            });

            modelBuilder.Entity<SeasonpassFoundation>(entity =>
            {
                entity.HasKey(e => e.SeasonId);

                entity.ToTable("seasonpass_foundation");

                entity.Property(e => e.SeasonId)
                    .ValueGeneratedNever()
                    .HasColumnName("season_id");

                entity.Property(e => e.AdvanceJewelId).HasColumnName("advance_jewel_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ExtraLevel).HasColumnName("extra_level");

                entity.Property(e => e.FinalJewelId).HasColumnName("final_jewel_id");

                entity.Property(e => e.KeyJewelId).HasColumnName("key_jewel_id");

                entity.Property(e => e.LevelMax).HasColumnName("level_max");

                entity.Property(e => e.LevelPrice).HasColumnName("level_price");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PerLevelPoint).HasColumnName("per_level_point");

                entity.Property(e => e.PointChangeType).HasColumnName("point_change_type");

                entity.Property(e => e.Proportion).HasColumnName("proportion");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.WeeklyPoint).HasColumnName("weekly_point");
            });

            modelBuilder.Entity<SeasonpassLevelReward>(entity =>
            {
                entity.HasKey(e => e.LevelId);

                entity.ToTable("seasonpass_level_reward");

                entity.Property(e => e.LevelId)
                    .ValueGeneratedNever()
                    .HasColumnName("level_id");

                entity.Property(e => e.ChargeRewardId1).HasColumnName("charge_reward_id_1");

                entity.Property(e => e.ChargeRewardId2).HasColumnName("charge_reward_id_2");

                entity.Property(e => e.ChargeRewardNum1).HasColumnName("charge_reward_num_1");

                entity.Property(e => e.ChargeRewardNum2).HasColumnName("charge_reward_num_2");

                entity.Property(e => e.ChargeRewardType1).HasColumnName("charge_reward_type_1");

                entity.Property(e => e.ChargeRewardType2).HasColumnName("charge_reward_type_2");

                entity.Property(e => e.Degree).HasColumnName("degree");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FreeRewardId).HasColumnName("free_reward_id");

                entity.Property(e => e.FreeRewardNum).HasColumnName("free_reward_num");

                entity.Property(e => e.FreeRewardType).HasColumnName("free_reward_type");
            });

            modelBuilder.Entity<SeasonpassMissionDatum>(entity =>
            {
                entity.HasKey(e => e.SeasonpassMissionId);

                entity.ToTable("seasonpass_mission_data");

                entity.Property(e => e.SeasonpassMissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("seasonpass_mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.MissionType).HasColumnName("mission_type");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<SeasonpassMissionRewardDatum>(entity =>
            {
                entity.ToTable("seasonpass_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId, "seasonpass_mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<SekaiAddTimesDatum>(entity =>
            {
                entity.ToTable("sekai_add_times_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddTimes).HasColumnName("add_times");

                entity.Property(e => e.AddTimesLimit).HasColumnName("add_times_limit");

                entity.Property(e => e.AddTimesTime).HasColumnName("add_times_time");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SekaiBossDamageRankReward>(entity =>
            {
                entity.ToTable("sekai_boss_damage_rank_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DamageRankId).HasColumnName("damage_rank_id");

                entity.Property(e => e.RankingFrom).HasColumnName("ranking_from");

                entity.Property(e => e.RankingTo).HasColumnName("ranking_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<SekaiBossFixReward>(entity =>
            {
                entity.HasKey(e => e.FixRewardId);

                entity.ToTable("sekai_boss_fix_reward");

                entity.Property(e => e.FixRewardId)
                    .ValueGeneratedNever()
                    .HasColumnName("fix_reward_id");

                entity.Property(e => e.BossTotalDamage).HasColumnName("boss_total_damage");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId10).HasColumnName("reward_id_10");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardId6).HasColumnName("reward_id_6");

                entity.Property(e => e.RewardId7).HasColumnName("reward_id_7");

                entity.Property(e => e.RewardId8).HasColumnName("reward_id_8");

                entity.Property(e => e.RewardId9).HasColumnName("reward_id_9");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum10).HasColumnName("reward_num_10");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardNum6).HasColumnName("reward_num_6");

                entity.Property(e => e.RewardNum7).HasColumnName("reward_num_7");

                entity.Property(e => e.RewardNum8).HasColumnName("reward_num_8");

                entity.Property(e => e.RewardNum9).HasColumnName("reward_num_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SekaiBossMode>(entity =>
            {
                entity.ToTable("sekai_boss_mode");

                entity.Property(e => e.SekaiBossModeId)
                    .ValueGeneratedNever()
                    .HasColumnName("sekai_boss_mode_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestDetailMonsterHeight).HasColumnName("quest_detail_monster_height");

                entity.Property(e => e.QuestDetailMonsterSize).HasColumnName("quest_detail_monster_size");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.ScoreCoefficient).HasColumnName("score_coefficient");

                entity.Property(e => e.SekaiEnemyId).HasColumnName("sekai_enemy_id");

                entity.Property(e => e.SekaiEnemyLevel).HasColumnName("sekai_enemy_level");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");
            });

            modelBuilder.Entity<SekaiEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.SekaiEnemyId);

                entity.ToTable("sekai_enemy_parameter");

                entity.Property(e => e.SekaiEnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("sekai_enemy_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<SekaiSchedule>(entity =>
            {
                entity.HasKey(e => e.SekaiId);

                entity.ToTable("sekai_schedule");

                entity.Property(e => e.SekaiId)
                    .ValueGeneratedNever()
                    .HasColumnName("sekai_id");

                entity.Property(e => e.CountStartTime).HasColumnName("count_start_time");

                entity.Property(e => e.DamageRankId).HasColumnName("damage_rank_id");

                entity.Property(e => e.EndLosstime).HasColumnName("end_losstime");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.LastSekaiId).HasColumnName("last_sekai_id");

                entity.Property(e => e.ResultEnd).HasColumnName("result_end");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TeaserTime).HasColumnName("teaser_time");
            });

            modelBuilder.Entity<SekaiTopDatum>(entity =>
            {
                entity.ToTable("sekai_top_data");

                entity.HasIndex(e => e.SekaiId, "sekai_top_data_0_sekai_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BossHpFrom).HasColumnName("boss_hp_from");

                entity.Property(e => e.BossHpTo).HasColumnName("boss_hp_to");

                entity.Property(e => e.BossMode).HasColumnName("boss_mode");

                entity.Property(e => e.BossTimeFrom).HasColumnName("boss_time_from");

                entity.Property(e => e.BossTimeTo).HasColumnName("boss_time_to");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.ScaleRatio).HasColumnName("scale_ratio");

                entity.Property(e => e.SekaiBossModeId).HasColumnName("sekai_boss_mode_id");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TopBg).HasColumnName("top_bg");
            });

            modelBuilder.Entity<SekaiTopStoryDatum>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("sekai_top_story_data");

                entity.HasIndex(e => e.SekaiId, "sekai_top_story_data_0_sekai_id");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.BossTimeFrom).HasColumnName("boss_time_from");

                entity.Property(e => e.BossTimeTo).HasColumnName("boss_time_to");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SekaiUnlockStoryCondition>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("sekai_unlock_story_condition");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.ConditionEntry).HasColumnName("condition_entry");

                entity.Property(e => e.ConditionFixRewardId).HasColumnName("condition_fix_reward_id");

                entity.Property(e => e.ConditionTime).HasColumnName("condition_time");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SerialCodeDatum>(entity =>
            {
                entity.HasKey(e => e.SerialCampaignId);

                entity.ToTable("serial_code_data");

                entity.Property(e => e.SerialCampaignId)
                    .ValueGeneratedNever()
                    .HasColumnName("serial_campaign_id");

                entity.Property(e => e.CampaignName).HasColumnName("campaign_name");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LimitNum).HasColumnName("limit_num");

                entity.Property(e => e.SerialGroupId).HasColumnName("serial_group_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<SerialGroupDatum>(entity =>
            {
                entity.HasKey(e => e.SerialGroupId);

                entity.ToTable("serial_group_data");

                entity.Property(e => e.SerialGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("serial_group_id");

                entity.Property(e => e.CampaignName).HasColumnName("campaign_name");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.SerialCampaignId1).HasColumnName("serial_campaign_id_1");

                entity.Property(e => e.SerialCampaignId2).HasColumnName("serial_campaign_id_2");

                entity.Property(e => e.SerialCampaignId3).HasColumnName("serial_campaign_id_3");

                entity.Property(e => e.SerialCampaignId4).HasColumnName("serial_campaign_id_4");

                entity.Property(e => e.SerialCampaignId5).HasColumnName("serial_campaign_id_5");

                entity.Property(e => e.SerialCampaignId6).HasColumnName("serial_campaign_id_6");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<ShioriBattleMissionDatum>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("shiori_battle_mission_data");

                entity.Property(e => e.MissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ShioriBoss>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("shiori_boss");

                entity.HasIndex(e => e.EventId, "shiori_boss_0_event_id");

                entity.HasIndex(e => new { e.EventId, e.Difficulty }, "shiori_boss_0_event_id_1_difficulty");

                entity.HasIndex(e => e.WaveGroupId1, "shiori_boss_0_wave_group_id_1");

                entity.Property(e => e.BossId)
                    .ValueGeneratedNever()
                    .HasColumnName("boss_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.BossPositionX).HasColumnName("boss_position_x");

                entity.Property(e => e.BossPositionY).HasColumnName("boss_position_y");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DeatailAuraSize).HasColumnName("deatail_aura_size");

                entity.Property(e => e.DetailBgId).HasColumnName("detail_bg_id");

                entity.Property(e => e.DetailBgPosition).HasColumnName("detail_bg_position");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispOnBg).HasColumnName("disp_on_bg");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconColliderScale).HasColumnName("icon_collider_scale");

                entity.Property(e => e.IconDisplayScale).HasColumnName("icon_display_scale");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MapAuraSize).HasColumnName("map_aura_size");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.MapSize).HasColumnName("map_size");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");
            });

            modelBuilder.Entity<ShioriBossCondition>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("shiori_boss_condition");

                entity.Property(e => e.BossId)
                    .ValueGeneratedNever()
                    .HasColumnName("boss_id");

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseBossId).HasColumnName("release_boss_id");

                entity.Property(e => e.ReleaseQuestId).HasColumnName("release_quest_id");
            });

            modelBuilder.Entity<ShioriDescription>(entity =>
            {
                entity.ToTable("shiori_description");

                entity.HasIndex(e => e.Type, "shiori_description_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ShioriEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("shiori_enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("enemy_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<ShioriEventList>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("shiori_event_list");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_id");

                entity.Property(e => e.ConditionCharaId).HasColumnName("condition_chara_id");

                entity.Property(e => e.ConditionMainQuestId).HasColumnName("condition_main_quest_id");

                entity.Property(e => e.ConditionShioriQuestId).HasColumnName("condition_shiori_quest_id");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.GojuonOrder).HasColumnName("gojuon_order");

                entity.Property(e => e.HelpIndex).HasColumnName("help_index");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.OriginalStartTime).HasColumnName("original_start_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<ShioriItem>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("shiori_item");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnName("event_id");

                entity.Property(e => e.UnitMaterialId1).HasColumnName("unit_material_id_1");

                entity.Property(e => e.UnitMaterialId2).HasColumnName("unit_material_id_2");
            });

            modelBuilder.Entity<ShioriMissionRewardDatum>(entity =>
            {
                entity.ToTable("shiori_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId, "shiori_mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<ShioriQuest>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("shiori_quest");

                entity.HasIndex(e => e.DropRewardId, "shiori_quest_0_drop_reward_id");

                entity.HasIndex(e => e.EventId, "shiori_quest_0_event_id");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DropRewardId).HasColumnName("drop_reward_id");

                entity.Property(e => e.DropRewardNum).HasColumnName("drop_reward_num");

                entity.Property(e => e.DropRewardOdds).HasColumnName("drop_reward_odds");

                entity.Property(e => e.DropRewardType).HasColumnName("drop_reward_type");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.IconOffsetX).HasColumnName("icon_offset_x");

                entity.Property(e => e.IconOffsetY).HasColumnName("icon_offset_y");

                entity.Property(e => e.IconScale).HasColumnName("icon_scale");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.QuestSeq).HasColumnName("quest_seq");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWaveend2).HasColumnName("story_id_waveend_2");

                entity.Property(e => e.StoryIdWaveend3).HasColumnName("story_id_waveend_3");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.StoryIdWavestart2).HasColumnName("story_id_wavestart_2");

                entity.Property(e => e.StoryIdWavestart3).HasColumnName("story_id_wavestart_3");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2).HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3).HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2).HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3).HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<ShioriQuestArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("shiori_quest_area");

                entity.HasIndex(e => e.EventId, "shiori_quest_area_0_event_id");

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("area_id");

                entity.Property(e => e.AdditionalEffect).HasColumnName("additional_effect");

                entity.Property(e => e.AreaDisp).HasColumnName("area_disp");

                entity.Property(e => e.AreaName).HasColumnName("area_name");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.OpenTutorialId).HasColumnName("open_tutorial_id");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.ScrollHeight).HasColumnName("scroll_height");

                entity.Property(e => e.ScrollWidth).HasColumnName("scroll_width");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.TutorialParam1).HasColumnName("tutorial_param_1");

                entity.Property(e => e.TutorialParam2).HasColumnName("tutorial_param_2");
            });

            modelBuilder.Entity<ShioriQuestCondition>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("shiori_quest_condition");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionMainQuestId).HasColumnName("condition_main_quest_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseBossId).HasColumnName("release_boss_id");

                entity.Property(e => e.ReleaseQuestId).HasColumnName("release_quest_id");
            });

            modelBuilder.Entity<ShioriStationaryMissionDatum>(entity =>
            {
                entity.HasKey(e => e.StationaryMissionId);

                entity.ToTable("shiori_stationary_mission_data");

                entity.Property(e => e.StationaryMissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("stationary_mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ShioriUnlockUnitCondition>(entity =>
            {
                entity.ToTable("shiori_unlock_unit_condition");

                entity.HasIndex(e => e.ConditionMissionId, "shiori_unlock_unit_condition_0_condition_mission_id");

                entity.HasIndex(e => new { e.UnitId, e.EventId }, "shiori_unlock_unit_condition_0_unit_id_1_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.Description1).HasColumnName("description_1");

                entity.Property(e => e.Description2).HasColumnName("description_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.TopDescription).HasColumnName("top_description");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<ShioriWaveGroupDatum>(entity =>
            {
                entity.HasKey(e => e.WaveGroupId);

                entity.ToTable("shiori_wave_group_data");

                entity.Property(e => e.WaveGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("wave_group_id");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");
            });

            modelBuilder.Entity<ShopStaticPriceGroup>(entity =>
            {
                entity.ToTable("shop_static_price_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BuyCountFrom).HasColumnName("buy_count_from");

                entity.Property(e => e.BuyCountTo).HasColumnName("buy_count_to");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.PriceGroupId).HasColumnName("price_group_id");
            });

            modelBuilder.Entity<SkeStoryDatum>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("ske_story_data");

                entity.HasIndex(e => e.OriginalEventId, "ske_story_data_0_original_event_id");

                entity.Property(e => e.SubStoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("sub_story_id");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.ReadConditionEventStoryId).HasColumnName("read_condition_event_story_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnlockConditionBossId).HasColumnName("unlock_condition_boss_id");

                entity.Property(e => e.UnlockConditionQuestId).HasColumnName("unlock_condition_quest_id");
            });

            modelBuilder.Entity<SkeStoryScript>(entity =>
            {
                entity.ToTable("ske_story_script");

                entity.HasIndex(e => e.StoryId, "ske_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName).HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName).HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SkillAction>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("skill_action");

                entity.Property(e => e.ActionId)
                    .ValueGeneratedNever()
                    .HasColumnName("action_id");

                entity.Property(e => e.ActionDetail1).HasColumnName("action_detail_1");

                entity.Property(e => e.ActionDetail2).HasColumnName("action_detail_2");

                entity.Property(e => e.ActionDetail3).HasColumnName("action_detail_3");

                entity.Property(e => e.ActionType).HasColumnName("action_type");

                entity.Property(e => e.ActionValue1).HasColumnName("action_value_1");

                entity.Property(e => e.ActionValue2).HasColumnName("action_value_2");

                entity.Property(e => e.ActionValue3).HasColumnName("action_value_3");

                entity.Property(e => e.ActionValue4).HasColumnName("action_value_4");

                entity.Property(e => e.ActionValue5).HasColumnName("action_value_5");

                entity.Property(e => e.ActionValue6).HasColumnName("action_value_6");

                entity.Property(e => e.ActionValue7).HasColumnName("action_value_7");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.LevelUpDisp).HasColumnName("level_up_disp");

                entity.Property(e => e.TargetArea).HasColumnName("target_area");

                entity.Property(e => e.TargetAssignment).HasColumnName("target_assignment");

                entity.Property(e => e.TargetCount).HasColumnName("target_count");

                entity.Property(e => e.TargetNumber).HasColumnName("target_number");

                entity.Property(e => e.TargetRange).HasColumnName("target_range");

                entity.Property(e => e.TargetType).HasColumnName("target_type");
            });

            modelBuilder.Entity<SkillCost>(entity =>
            {
                entity.HasKey(e => e.TargetLevel);

                entity.ToTable("skill_cost");

                entity.Property(e => e.TargetLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("target_level");

                entity.Property(e => e.Cost).HasColumnName("cost");
            });

            modelBuilder.Entity<SkillDatum>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("skill_data");

                entity.Property(e => e.SkillId)
                    .ValueGeneratedNever()
                    .HasColumnName("skill_id");

                entity.Property(e => e.Action1).HasColumnName("action_1");

                entity.Property(e => e.Action2).HasColumnName("action_2");

                entity.Property(e => e.Action3).HasColumnName("action_3");

                entity.Property(e => e.Action4).HasColumnName("action_4");

                entity.Property(e => e.Action5).HasColumnName("action_5");

                entity.Property(e => e.Action6).HasColumnName("action_6");

                entity.Property(e => e.Action7).HasColumnName("action_7");

                entity.Property(e => e.BossUbCoolTime).HasColumnName("boss_ub_cool_time");

                entity.Property(e => e.DependAction1).HasColumnName("depend_action_1");

                entity.Property(e => e.DependAction2).HasColumnName("depend_action_2");

                entity.Property(e => e.DependAction3).HasColumnName("depend_action_3");

                entity.Property(e => e.DependAction4).HasColumnName("depend_action_4");

                entity.Property(e => e.DependAction5).HasColumnName("depend_action_5");

                entity.Property(e => e.DependAction6).HasColumnName("depend_action_6");

                entity.Property(e => e.DependAction7).HasColumnName("depend_action_7");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SkillAreaWidth).HasColumnName("skill_area_width");

                entity.Property(e => e.SkillCastTime).HasColumnName("skill_cast_time");

                entity.Property(e => e.SkillType).HasColumnName("skill_type");
            });

            modelBuilder.Entity<SkipBossDatum>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("skip_boss_data");

                entity.Property(e => e.BossId)
                    .ValueGeneratedNever()
                    .HasColumnName("boss_id");

                entity.Property(e => e.SkipBgId).HasColumnName("skip_bg_id");

                entity.Property(e => e.SkipMotionId).HasColumnName("skip_motion_id");

                entity.Property(e => e.SkipPositionX).HasColumnName("skip_position_x");

                entity.Property(e => e.SkipPositionY).HasColumnName("skip_position_y");

                entity.Property(e => e.SkipScaleX).HasColumnName("skip_scale_x");

                entity.Property(e => e.SkipScaleY).HasColumnName("skip_scale_y");
            });

            modelBuilder.Entity<SkipMonsterDatum>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("skip_monster_data");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BgSkipId).HasColumnName("bg_skip_id");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");
            });

            modelBuilder.Entity<SpaceBattleDatum>(entity =>
            {
                entity.HasKey(e => e.SpaceBattleId);

                entity.ToTable("space_battle_data");

                entity.Property(e => e.SpaceBattleId)
                    .ValueGeneratedNever()
                    .HasColumnName("space_battle_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.SpaceEnemyId).HasColumnName("space_enemy_id");
            });

            modelBuilder.Entity<SpaceSchedule>(entity =>
            {
                entity.HasKey(e => e.SpaceId);

                entity.ToTable("space_schedule");

                entity.Property(e => e.SpaceId)
                    .ValueGeneratedNever()
                    .HasColumnName("space_id");

                entity.Property(e => e.CountEndTime).HasColumnName("count_end_time");

                entity.Property(e => e.CountStartTime).HasColumnName("count_start_time");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TeaserTime).HasColumnName("teaser_time");
            });

            modelBuilder.Entity<SpaceTopDatum>(entity =>
            {
                entity.ToTable("space_top_data");

                entity.HasIndex(e => e.SpaceId, "space_top_data_0_space_id");

                entity.HasIndex(e => e.StoryId, "space_top_data_0_story_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PartFlag).HasColumnName("part_flag");

                entity.Property(e => e.SkipBattleTime).HasColumnName("skip_battle_time");

                entity.Property(e => e.SpaceBattleId).HasColumnName("space_battle_id");

                entity.Property(e => e.SpaceId).HasColumnName("space_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TimeFrom).HasColumnName("time_from");

                entity.Property(e => e.TimeTo).HasColumnName("time_to");
            });

            modelBuilder.Entity<SpecialStill>(entity =>
            {
                entity.HasKey(e => e.StillId);

                entity.ToTable("special_still");

                entity.Property(e => e.StillId)
                    .ValueGeneratedNever()
                    .HasColumnName("still_id");

                entity.Property(e => e.BackMomoryType).HasColumnName("back_momory_type");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<SpecialStoryBanner>(entity =>
            {
                entity.ToTable("special_story_banner");

                entity.HasIndex(e => e.StoryGroupId, "special_story_banner_0_story_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");
            });

            modelBuilder.Entity<SpecialfesBanner>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("specialfes_banner");

                entity.Property(e => e.GachaId)
                    .ValueGeneratedNever()
                    .HasColumnName("gacha_id");

                entity.Property(e => e.BannerId1).HasColumnName("banner_id_1");

                entity.Property(e => e.BannerId10).HasColumnName("banner_id_10");

                entity.Property(e => e.BannerId2).HasColumnName("banner_id_2");

                entity.Property(e => e.BannerId3).HasColumnName("banner_id_3");

                entity.Property(e => e.BannerId4).HasColumnName("banner_id_4");

                entity.Property(e => e.BannerId5).HasColumnName("banner_id_5");

                entity.Property(e => e.BannerId6).HasColumnName("banner_id_6");

                entity.Property(e => e.BannerId7).HasColumnName("banner_id_7");

                entity.Property(e => e.BannerId8).HasColumnName("banner_id_8");

                entity.Property(e => e.BannerId9).HasColumnName("banner_id_9");
            });

            modelBuilder.Entity<SpskillLabelDatum>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("spskill_label_data");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.NormalLabelText).HasColumnName("normal_label_text");

                entity.Property(e => e.SpLabelText).HasColumnName("sp_label_text");
            });

            modelBuilder.Entity<SpskillLvInitializeDatum>(entity =>
            {
                entity.HasKey(e => e.InitializeSkillId);

                entity.ToTable("spskill_lv_initialize_data");

                entity.Property(e => e.InitializeSkillId)
                    .ValueGeneratedNever()
                    .HasColumnName("initialize_skill_id");

                entity.Property(e => e.BaseSkillId).HasColumnName("base_skill_id");
            });

            modelBuilder.Entity<SrtAction>(entity =>
            {
                entity.HasKey(e => e.ActionName);

                entity.ToTable("srt_action");

                entity.Property(e => e.ActionName).HasColumnName("action_name");

                entity.Property(e => e.DragonAction).HasColumnName("dragon_action");

                entity.Property(e => e.HomareAction).HasColumnName("homare_action");

                entity.Property(e => e.InoriAction).HasColumnName("inori_action");

                entity.Property(e => e.KayaAction).HasColumnName("kaya_action");

                entity.Property(e => e.TalkText).HasColumnName("talk_text");

                entity.Property(e => e.TalkTextType).HasColumnName("talk_text_type");

                entity.Property(e => e.VoiceList).HasColumnName("voice_list");
            });

            modelBuilder.Entity<SrtPanel>(entity =>
            {
                entity.HasKey(e => e.ReadingId);

                entity.ToTable("srt_panel");

                entity.HasIndex(e => e.PanelId, "srt_panel_0_panel_id");

                entity.HasIndex(e => e.Version, "srt_panel_0_version");

                entity.Property(e => e.ReadingId)
                    .ValueGeneratedNever()
                    .HasColumnName("reading_id");

                entity.Property(e => e.DetailText).HasColumnName("detail_text");

                entity.Property(e => e.HeadSymbol).HasColumnName("head_symbol");

                entity.Property(e => e.PanelId).HasColumnName("panel_id");

                entity.Property(e => e.ReadType).HasColumnName("read_type");

                entity.Property(e => e.Reading).HasColumnName("reading");

                entity.Property(e => e.TailSymbol).HasColumnName("tail_symbol");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<SrtReward>(entity =>
            {
                entity.ToTable("srt_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MissionDetail).HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.SrtScore).HasColumnName("srt_score");
            });

            modelBuilder.Entity<SrtScore>(entity =>
            {
                entity.HasKey(e => e.DifficultyLevel);

                entity.ToTable("srt_score");

                entity.Property(e => e.DifficultyLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("difficulty_level");

                entity.Property(e => e.CoefficientAvgAnswerTime).HasColumnName("coefficient_avg_answer_time");

                entity.Property(e => e.CoefficientCountPriconnePanel).HasColumnName("coefficient_count_priconne_panel");

                entity.Property(e => e.CoefficientFever).HasColumnName("coefficient_fever");

                entity.Property(e => e.CoefficientReadType1).HasColumnName("coefficient_read_type_1");

                entity.Property(e => e.CoefficientReadType2).HasColumnName("coefficient_read_type_2");

                entity.Property(e => e.CoefficientReadType3).HasColumnName("coefficient_read_type_3");

                entity.Property(e => e.CoefficientTurnBonus).HasColumnName("coefficient_turn_bonus");

                entity.Property(e => e.CoefficientWrongNum).HasColumnName("coefficient_wrong_num");

                entity.Property(e => e.ConstantTurnBonus).HasColumnName("constant_turn_bonus");

                entity.Property(e => e.ConstantWrongNum).HasColumnName("constant_wrong_num");
            });

            modelBuilder.Entity<SrtTopTalk>(entity =>
            {
                entity.ToTable("srt_top_talk");

                entity.HasIndex(e => e.TalkId, "srt_top_talk_0_talk_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.CueName).HasColumnName("cue_name");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.SheetName).HasColumnName("sheet_name");

                entity.Property(e => e.TalkId).HasColumnName("talk_id");

                entity.Property(e => e.TalkText).HasColumnName("talk_text");
            });

            modelBuilder.Entity<SspStoryDatum>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("ssp_story_data");

                entity.HasIndex(e => e.ContentsType, "ssp_story_data_0_contents_type");

                entity.HasIndex(e => e.OriginalEventId, "ssp_story_data_0_original_event_id");

                entity.Property(e => e.SubStoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("sub_story_id");

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ContentsType).HasColumnName("contents_type");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.ReadCondition).HasColumnName("read_condition");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<Stamp>(entity =>
            {
                entity.ToTable("stamp");

                entity.Property(e => e.StampId)
                    .ValueGeneratedNever()
                    .HasColumnName("stamp_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");
            });

            modelBuilder.Entity<StationaryMissionDatum>(entity =>
            {
                entity.HasKey(e => e.StationaryMissionId);

                entity.ToTable("stationary_mission_data");

                entity.Property(e => e.StationaryMissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("stationary_mission_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TitleColorId).HasColumnName("title_color_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<Still>(entity =>
            {
                entity.ToTable("still");

                entity.HasIndex(e => e.StillGroupId, "still_0_still_group_id");

                entity.HasIndex(e => e.StoryId, "still_0_story_id");

                entity.Property(e => e.StillId)
                    .ValueGeneratedNever()
                    .HasColumnName("still_id");

                entity.Property(e => e.AlbumIgnore).HasColumnName("album_ignore");

                entity.Property(e => e.FacialId).HasColumnName("facial_id");

                entity.Property(e => e.MyPageFlag).HasColumnName("my_page_flag");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.ScrollDirection).HasColumnName("scroll_direction");

                entity.Property(e => e.StillGroupId).HasColumnName("still_group_id");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id_1");

                entity.Property(e => e.UnitId10).HasColumnName("unit_id_10");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id_2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id_3");

                entity.Property(e => e.UnitId4).HasColumnName("unit_id_4");

                entity.Property(e => e.UnitId5).HasColumnName("unit_id_5");

                entity.Property(e => e.UnitId6).HasColumnName("unit_id_6");

                entity.Property(e => e.UnitId7).HasColumnName("unit_id_7");

                entity.Property(e => e.UnitId8).HasColumnName("unit_id_8");

                entity.Property(e => e.UnitId9).HasColumnName("unit_id_9");

                entity.Property(e => e.VerticalStillFlg).HasColumnName("vertical_still_flg");
            });

            modelBuilder.Entity<StoryCharacterMask>(entity =>
            {
                entity.HasKey(e => e.CharaId);

                entity.ToTable("story_character_mask");

                entity.Property(e => e.CharaId)
                    .ValueGeneratedNever()
                    .HasColumnName("chara_id");

                entity.Property(e => e.Offset).HasColumnName("offset");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Softness).HasColumnName("softness");
            });

            modelBuilder.Entity<StoryDatum>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("story_data");

                entity.Property(e => e.StoryGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_group_id");

                entity.Property(e => e.ConditionFreeFlag).HasColumnName("condition_free_flag");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.GojuonOrder).HasColumnName("gojuon_order");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<StoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("story_detail");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ForceUnlockTime).HasColumnName("force_unlock_time");

                entity.Property(e => e.ForceUnlockTime2).HasColumnName("force_unlock_time_2");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.PreStoryId2).HasColumnName("pre_story_id_2");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<StoryQuestDatum>(entity =>
            {
                entity.HasKey(e => e.StoryQuestId);

                entity.ToTable("story_quest_data");

                entity.Property(e => e.StoryQuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_quest_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.GuestUnit1).HasColumnName("guest_unit_1");

                entity.Property(e => e.GuestUnit2).HasColumnName("guest_unit_2");

                entity.Property(e => e.GuestUnit3).HasColumnName("guest_unit_3");

                entity.Property(e => e.GuestUnit4).HasColumnName("guest_unit_4");

                entity.Property(e => e.GuestUnit5).HasColumnName("guest_unit_5");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2).HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3).HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2).HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3).HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<TicketGachaDatum>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("ticket_gacha_data");

                entity.Property(e => e.GachaId)
                    .ValueGeneratedNever()
                    .HasColumnName("gacha_id");

                entity.Property(e => e.CharaOddsStar1).HasColumnName("chara_odds_star1");

                entity.Property(e => e.CharaOddsStar2).HasColumnName("chara_odds_star2");

                entity.Property(e => e.CharaOddsStar3).HasColumnName("chara_odds_star3");

                entity.Property(e => e.GachaDetail).HasColumnName("gacha_detail");

                entity.Property(e => e.GachaName).HasColumnName("gacha_name");

                entity.Property(e => e.GachaTimes).HasColumnName("gacha_times");

                entity.Property(e => e.GachaType).HasColumnName("gacha_type");

                entity.Property(e => e.GuaranteeRarity).HasColumnName("guarantee_rarity");

                entity.Property(e => e.RarityOdds).HasColumnName("rarity_odds");

                entity.Property(e => e.StagingType).HasColumnName("staging_type");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            });

            modelBuilder.Entity<Tip>(entity =>
            {
                entity.ToTable("tips");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.TipsIndex).HasColumnName("tips_index");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TmeMapDatum>(entity =>
            {
                entity.HasKey(e => e.TmeObjectId);

                entity.ToTable("tme_map_data");

                entity.HasIndex(e => e.EventId, "tme_map_data_0_event_id");

                entity.Property(e => e.TmeObjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("tme_object_id");

                entity.Property(e => e.AreaDifficultyType).HasColumnName("area_difficulty_type");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseEffect).HasColumnName("release_effect");

                entity.Property(e => e.TapEffect).HasColumnName("tap_effect");
            });

            modelBuilder.Entity<TowerAreaDatum>(entity =>
            {
                entity.HasKey(e => e.TowerAreaId);

                entity.ToTable("tower_area_data");

                entity.Property(e => e.TowerAreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("tower_area_id");

                entity.Property(e => e.AreaBg).HasColumnName("area_bg");

                entity.Property(e => e.CloisterQuestId).HasColumnName("cloister_quest_id");

                entity.Property(e => e.MaxFloorNum).HasColumnName("max_floor_num");

                entity.Property(e => e.TowerBgm).HasColumnName("tower_bgm");
            });

            modelBuilder.Entity<TowerCloisterQuestDatum>(entity =>
            {
                entity.HasKey(e => e.TowerCloisterQuestId);

                entity.ToTable("tower_cloister_quest_data");

                entity.Property(e => e.TowerCloisterQuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("tower_cloister_quest_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DropRewardGroupId).HasColumnName("drop_reward_group_id");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.RecoveryHpRate).HasColumnName("recovery_hp_rate");

                entity.Property(e => e.RecoveryTpRate).HasColumnName("recovery_tp_rate");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.StartTpRate).HasColumnName("start_tp_rate");

                entity.Property(e => e.W1EnemyLocalPositionY1).HasColumnName("w1_enemy_local_position_y_1");

                entity.Property(e => e.W1EnemyLocalPositionY2).HasColumnName("w1_enemy_local_position_y_2");

                entity.Property(e => e.W1EnemyLocalPositionY3).HasColumnName("w1_enemy_local_position_y_3");

                entity.Property(e => e.W1EnemyLocalPositionY4).HasColumnName("w1_enemy_local_position_y_4");

                entity.Property(e => e.W1EnemyLocalPositionY5).HasColumnName("w1_enemy_local_position_y_5");

                entity.Property(e => e.W1EnemyPositionX1).HasColumnName("w1_enemy_position_x_1");

                entity.Property(e => e.W1EnemyPositionX2).HasColumnName("w1_enemy_position_x_2");

                entity.Property(e => e.W1EnemyPositionX3).HasColumnName("w1_enemy_position_x_3");

                entity.Property(e => e.W1EnemyPositionX4).HasColumnName("w1_enemy_position_x_4");

                entity.Property(e => e.W1EnemyPositionX5).HasColumnName("w1_enemy_position_x_5");

                entity.Property(e => e.W1EnemySize1).HasColumnName("w1_enemy_size_1");

                entity.Property(e => e.W1EnemySize2).HasColumnName("w1_enemy_size_2");

                entity.Property(e => e.W1EnemySize3).HasColumnName("w1_enemy_size_3");

                entity.Property(e => e.W1EnemySize4).HasColumnName("w1_enemy_size_4");

                entity.Property(e => e.W1EnemySize5).HasColumnName("w1_enemy_size_5");

                entity.Property(e => e.W2EnemyLocalPositionY1).HasColumnName("w2_enemy_local_position_y_1");

                entity.Property(e => e.W2EnemyLocalPositionY2).HasColumnName("w2_enemy_local_position_y_2");

                entity.Property(e => e.W2EnemyLocalPositionY3).HasColumnName("w2_enemy_local_position_y_3");

                entity.Property(e => e.W2EnemyLocalPositionY4).HasColumnName("w2_enemy_local_position_y_4");

                entity.Property(e => e.W2EnemyLocalPositionY5).HasColumnName("w2_enemy_local_position_y_5");

                entity.Property(e => e.W2EnemyPositionX1).HasColumnName("w2_enemy_position_x_1");

                entity.Property(e => e.W2EnemyPositionX2).HasColumnName("w2_enemy_position_x_2");

                entity.Property(e => e.W2EnemyPositionX3).HasColumnName("w2_enemy_position_x_3");

                entity.Property(e => e.W2EnemyPositionX4).HasColumnName("w2_enemy_position_x_4");

                entity.Property(e => e.W2EnemyPositionX5).HasColumnName("w2_enemy_position_x_5");

                entity.Property(e => e.W2EnemySize1).HasColumnName("w2_enemy_size_1");

                entity.Property(e => e.W2EnemySize2).HasColumnName("w2_enemy_size_2");

                entity.Property(e => e.W2EnemySize3).HasColumnName("w2_enemy_size_3");

                entity.Property(e => e.W2EnemySize4).HasColumnName("w2_enemy_size_4");

                entity.Property(e => e.W2EnemySize5).HasColumnName("w2_enemy_size_5");

                entity.Property(e => e.W3EnemyLocalPositionY1).HasColumnName("w3_enemy_local_position_y_1");

                entity.Property(e => e.W3EnemyLocalPositionY2).HasColumnName("w3_enemy_local_position_y_2");

                entity.Property(e => e.W3EnemyLocalPositionY3).HasColumnName("w3_enemy_local_position_y_3");

                entity.Property(e => e.W3EnemyLocalPositionY4).HasColumnName("w3_enemy_local_position_y_4");

                entity.Property(e => e.W3EnemyLocalPositionY5).HasColumnName("w3_enemy_local_position_y_5");

                entity.Property(e => e.W3EnemyPositionX1).HasColumnName("w3_enemy_position_x_1");

                entity.Property(e => e.W3EnemyPositionX2).HasColumnName("w3_enemy_position_x_2");

                entity.Property(e => e.W3EnemyPositionX3).HasColumnName("w3_enemy_position_x_3");

                entity.Property(e => e.W3EnemyPositionX4).HasColumnName("w3_enemy_position_x_4");

                entity.Property(e => e.W3EnemyPositionX5).HasColumnName("w3_enemy_position_x_5");

                entity.Property(e => e.W3EnemySize1).HasColumnName("w3_enemy_size_1");

                entity.Property(e => e.W3EnemySize2).HasColumnName("w3_enemy_size_2");

                entity.Property(e => e.W3EnemySize3).HasColumnName("w3_enemy_size_3");

                entity.Property(e => e.W3EnemySize4).HasColumnName("w3_enemy_size_4");

                entity.Property(e => e.W3EnemySize5).HasColumnName("w3_enemy_size_5");

                entity.Property(e => e.WaveBgm).HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<TowerEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("tower_enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("enemy_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnemyColor).HasColumnName("enemy_color");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<TowerExQuestDatum>(entity =>
            {
                entity.HasKey(e => e.TowerExQuestId);

                entity.ToTable("tower_ex_quest_data");

                entity.HasIndex(e => e.FloorNum, "tower_ex_quest_data_0_floor_num");

                entity.Property(e => e.TowerExQuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("tower_ex_quest_id");

                entity.Property(e => e.AdditionalRewardId).HasColumnName("additional_reward_id");

                entity.Property(e => e.AdditionalRewardType).HasColumnName("additional_reward_type");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.ClpFlag).HasColumnName("clp_flag");

                entity.Property(e => e.EnemyLocalPositionY1).HasColumnName("enemy_local_position_y_1");

                entity.Property(e => e.EnemyLocalPositionY2).HasColumnName("enemy_local_position_y_2");

                entity.Property(e => e.EnemyLocalPositionY3).HasColumnName("enemy_local_position_y_3");

                entity.Property(e => e.EnemyLocalPositionY4).HasColumnName("enemy_local_position_y_4");

                entity.Property(e => e.EnemyLocalPositionY5).HasColumnName("enemy_local_position_y_5");

                entity.Property(e => e.EnemyPositionX1).HasColumnName("enemy_position_x_1");

                entity.Property(e => e.EnemyPositionX2).HasColumnName("enemy_position_x_2");

                entity.Property(e => e.EnemyPositionX3).HasColumnName("enemy_position_x_3");

                entity.Property(e => e.EnemyPositionX4).HasColumnName("enemy_position_x_4");

                entity.Property(e => e.EnemyPositionX5).HasColumnName("enemy_position_x_5");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.EnemySize2).HasColumnName("enemy_size_2");

                entity.Property(e => e.EnemySize3).HasColumnName("enemy_size_3");

                entity.Property(e => e.EnemySize4).HasColumnName("enemy_size_4");

                entity.Property(e => e.EnemySize5).HasColumnName("enemy_size_5");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.SkipLevel).HasColumnName("skip_level");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.TowerAreaId).HasColumnName("tower_area_id");

                entity.Property(e => e.WaveBgm).HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<TowerQuestDatum>(entity =>
            {
                entity.HasKey(e => e.TowerQuestId);

                entity.ToTable("tower_quest_data");

                entity.HasIndex(e => e.FloorNum, "tower_quest_data_0_floor_num");

                entity.Property(e => e.TowerQuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("tower_quest_id");

                entity.Property(e => e.AdditionalRewardId).HasColumnName("additional_reward_id");

                entity.Property(e => e.AdditionalRewardType).HasColumnName("additional_reward_type");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.BossFloorFlg).HasColumnName("boss_floor_flg");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.ClpFlag).HasColumnName("clp_flag");

                entity.Property(e => e.EnemyLocalPositionY1).HasColumnName("enemy_local_position_y_1");

                entity.Property(e => e.EnemyLocalPositionY2).HasColumnName("enemy_local_position_y_2");

                entity.Property(e => e.EnemyLocalPositionY3).HasColumnName("enemy_local_position_y_3");

                entity.Property(e => e.EnemyLocalPositionY4).HasColumnName("enemy_local_position_y_4");

                entity.Property(e => e.EnemyLocalPositionY5).HasColumnName("enemy_local_position_y_5");

                entity.Property(e => e.EnemyPositionX1).HasColumnName("enemy_position_x_1");

                entity.Property(e => e.EnemyPositionX2).HasColumnName("enemy_position_x_2");

                entity.Property(e => e.EnemyPositionX3).HasColumnName("enemy_position_x_3");

                entity.Property(e => e.EnemyPositionX4).HasColumnName("enemy_position_x_4");

                entity.Property(e => e.EnemyPositionX5).HasColumnName("enemy_position_x_5");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.EnemySize2).HasColumnName("enemy_size_2");

                entity.Property(e => e.EnemySize3).HasColumnName("enemy_size_3");

                entity.Property(e => e.EnemySize4).HasColumnName("enemy_size_4");

                entity.Property(e => e.EnemySize5).HasColumnName("enemy_size_5");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.FloorImageAddType).HasColumnName("floor_image_add_type");

                entity.Property(e => e.FloorImageType).HasColumnName("floor_image_type");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.OpenTowerExQuestId).HasColumnName("open_tower_ex_quest_id");

                entity.Property(e => e.RecoveryHpRate).HasColumnName("recovery_hp_rate");

                entity.Property(e => e.RecoveryTpRate).HasColumnName("recovery_tp_rate");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.SkipLevel).HasColumnName("skip_level");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTpRate).HasColumnName("start_tp_rate");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.TowerAreaId).HasColumnName("tower_area_id");

                entity.Property(e => e.WaveBgm).HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<TowerQuestFixRewardGroup>(entity =>
            {
                entity.HasKey(e => e.FixRewardGroupId);

                entity.ToTable("tower_quest_fix_reward_group");

                entity.Property(e => e.FixRewardGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("fix_reward_group_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId10).HasColumnName("reward_id_10");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardId6).HasColumnName("reward_id_6");

                entity.Property(e => e.RewardId7).HasColumnName("reward_id_7");

                entity.Property(e => e.RewardId8).HasColumnName("reward_id_8");

                entity.Property(e => e.RewardId9).HasColumnName("reward_id_9");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum10).HasColumnName("reward_num_10");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardNum6).HasColumnName("reward_num_6");

                entity.Property(e => e.RewardNum7).HasColumnName("reward_num_7");

                entity.Property(e => e.RewardNum8).HasColumnName("reward_num_8");

                entity.Property(e => e.RewardNum9).HasColumnName("reward_num_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");

                entity.Property(e => e.TreasureType1).HasColumnName("treasure_type_1");

                entity.Property(e => e.TreasureType10).HasColumnName("treasure_type_10");

                entity.Property(e => e.TreasureType2).HasColumnName("treasure_type_2");

                entity.Property(e => e.TreasureType3).HasColumnName("treasure_type_3");

                entity.Property(e => e.TreasureType4).HasColumnName("treasure_type_4");

                entity.Property(e => e.TreasureType5).HasColumnName("treasure_type_5");

                entity.Property(e => e.TreasureType6).HasColumnName("treasure_type_6");

                entity.Property(e => e.TreasureType7).HasColumnName("treasure_type_7");

                entity.Property(e => e.TreasureType8).HasColumnName("treasure_type_8");

                entity.Property(e => e.TreasureType9).HasColumnName("treasure_type_9");
            });

            modelBuilder.Entity<TowerQuestOddsGroup>(entity =>
            {
                entity.HasKey(e => new { e.OddsGroupId, e.TeamLevelFrom, e.TeamLevelTo });

                entity.ToTable("tower_quest_odds_group");

                entity.HasIndex(e => e.OddsGroupId, "tower_quest_odds_group_0_odds_group_id");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");

                entity.Property(e => e.OddsCsv1).HasColumnName("odds_csv_1");

                entity.Property(e => e.OddsCsv10).HasColumnName("odds_csv_10");

                entity.Property(e => e.OddsCsv2).HasColumnName("odds_csv_2");

                entity.Property(e => e.OddsCsv3).HasColumnName("odds_csv_3");

                entity.Property(e => e.OddsCsv4).HasColumnName("odds_csv_4");

                entity.Property(e => e.OddsCsv5).HasColumnName("odds_csv_5");

                entity.Property(e => e.OddsCsv6).HasColumnName("odds_csv_6");

                entity.Property(e => e.OddsCsv7).HasColumnName("odds_csv_7");

                entity.Property(e => e.OddsCsv8).HasColumnName("odds_csv_8");

                entity.Property(e => e.OddsCsv9).HasColumnName("odds_csv_9");

                entity.Property(e => e.TreasureType1).HasColumnName("treasure_type_1");

                entity.Property(e => e.TreasureType10).HasColumnName("treasure_type_10");

                entity.Property(e => e.TreasureType2).HasColumnName("treasure_type_2");

                entity.Property(e => e.TreasureType3).HasColumnName("treasure_type_3");

                entity.Property(e => e.TreasureType4).HasColumnName("treasure_type_4");

                entity.Property(e => e.TreasureType5).HasColumnName("treasure_type_5");

                entity.Property(e => e.TreasureType6).HasColumnName("treasure_type_6");

                entity.Property(e => e.TreasureType7).HasColumnName("treasure_type_7");

                entity.Property(e => e.TreasureType8).HasColumnName("treasure_type_8");

                entity.Property(e => e.TreasureType9).HasColumnName("treasure_type_9");
            });

            modelBuilder.Entity<TowerSchedule>(entity =>
            {
                entity.ToTable("tower_schedule");

                entity.HasIndex(e => e.OpeningStoryId, "tower_schedule_0_opening_story_id");

                entity.Property(e => e.TowerScheduleId)
                    .ValueGeneratedNever()
                    .HasColumnName("tower_schedule_id");

                entity.Property(e => e.CountStartTime).HasColumnName("count_start_time");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MaxTowerAreaId).HasColumnName("max_tower_area_id");

                entity.Property(e => e.OpeningStoryId).HasColumnName("opening_story_id");

                entity.Property(e => e.RecoveryDisableTime).HasColumnName("recovery_disable_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<TowerStoryDatum>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("tower_story_data");

                entity.Property(e => e.StoryGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_group_id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TowerStoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("tower_story_detail");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<TowerWaveGroupDatum>(entity =>
            {
                entity.HasKey(e => e.WaveGroupId);

                entity.ToTable("tower_wave_group_data");

                entity.Property(e => e.WaveGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("wave_group_id");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Odds).HasColumnName("odds");
            });

            modelBuilder.Entity<TrainingQuestDatum>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("training_quest_data");

                entity.Property(e => e.QuestId)
                    .ValueGeneratedNever()
                    .HasColumnName("quest_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.LimitTeamLevel).HasColumnName("limit_team_level");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.TrainingQuestDetailBgId).HasColumnName("training_quest_detail_bg_id");

                entity.Property(e => e.TrainingQuestDetailBgPosition).HasColumnName("training_quest_detail_bg_position");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.UnlockQuestId1).HasColumnName("unlock_quest_id_1");

                entity.Property(e => e.UnlockQuestId2).HasColumnName("unlock_quest_id_2");

                entity.Property(e => e.WaveBgmQueId1).HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2).HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3).HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1).HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2).HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3).HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<TtkDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("ttk_drama");

                entity.HasIndex(e => e.DramaId, "ttk_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .ValueGeneratedNever()
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01).HasColumnName("param_01");

                entity.Property(e => e.Param02).HasColumnName("param_02");

                entity.Property(e => e.Param03).HasColumnName("param_03");

                entity.Property(e => e.Param04).HasColumnName("param_04");

                entity.Property(e => e.Param05).HasColumnName("param_05");

                entity.Property(e => e.Param06).HasColumnName("param_06");

                entity.Property(e => e.Param07).HasColumnName("param_07");

                entity.Property(e => e.Param08).HasColumnName("param_08");
            });

            modelBuilder.Entity<TtkEnemy>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("ttk_enemy");

                entity.Property(e => e.EnemyId)
                    .ValueGeneratedNever()
                    .HasColumnName("enemy_id");

                entity.Property(e => e.Coin).HasColumnName("coin");

                entity.Property(e => e.Max).HasColumnName("max");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            modelBuilder.Entity<TtkNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("ttk_navi_comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("comment_id");

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName).HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<TtkReward>(entity =>
            {
                entity.ToTable("ttk_reward");

                entity.HasIndex(e => e.TtkScore, "ttk_reward_0_ttk_score");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MissionDetail).HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.TtkScore).HasColumnName("ttk_score");
            });

            modelBuilder.Entity<TtkScore>(entity =>
            {
                entity.HasKey(e => e.DifficultyLevel);

                entity.ToTable("ttk_score");

                entity.Property(e => e.DifficultyLevel)
                    .ValueGeneratedNever()
                    .HasColumnName("difficulty_level");

                entity.Property(e => e.CoefficientCoinScore).HasColumnName("coefficient_coin_score");

                entity.Property(e => e.CoefficientDifficulty).HasColumnName("coefficient_difficulty");

                entity.Property(e => e.CoefficientWrongNum).HasColumnName("coefficient_wrong_num");

                entity.Property(e => e.Life).HasColumnName("life");
            });

            modelBuilder.Entity<TtkStory>(entity =>
            {
                entity.ToTable("ttk_story");

                entity.HasIndex(e => e.TtkScore, "ttk_story_0_ttk_score");

                entity.Property(e => e.TtkStoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("ttk_story_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.TtkScore).HasColumnName("ttk_score");
            });

            modelBuilder.Entity<TtkStoryScript>(entity =>
            {
                entity.ToTable("ttk_story_script");

                entity.HasIndex(e => e.StoryId, "ttk_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName).HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName).HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TtkWeapon>(entity =>
            {
                entity.ToTable("ttk_weapon");

                entity.HasIndex(e => e.TtkScore, "ttk_weapon_0_ttk_score");

                entity.Property(e => e.TtkWeaponId)
                    .ValueGeneratedNever()
                    .HasColumnName("ttk_weapon_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.TtkScore).HasColumnName("ttk_score");
            });

            modelBuilder.Entity<UekBoss>(entity =>
            {
                entity.HasKey(e => e.Area);

                entity.ToTable("uek_boss");

                entity.HasIndex(e => e.EnemyId, "uek_boss_0_enemy_id");

                entity.Property(e => e.Area)
                    .ValueGeneratedNever()
                    .HasColumnName("area");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgmQueId).HasColumnName("bgm_que_id");

                entity.Property(e => e.BgmSheetId).HasColumnName("bgm_sheet_id");

                entity.Property(e => e.DetailBgId).HasColumnName("detail_bg_id");

                entity.Property(e => e.DetailBgPosition).HasColumnName("detail_bg_position");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.EnemyId).HasColumnName("enemy_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName).HasColumnName("quest_name");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.ResultMovie).HasColumnName("result_movie");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<UekDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("uek_drama");

                entity.HasIndex(e => e.DramaId, "uek_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .ValueGeneratedNever()
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01).HasColumnName("param_01");

                entity.Property(e => e.Param02).HasColumnName("param_02");

                entity.Property(e => e.Param03).HasColumnName("param_03");

                entity.Property(e => e.Param04).HasColumnName("param_04");

                entity.Property(e => e.Param05).HasColumnName("param_05");

                entity.Property(e => e.Param06).HasColumnName("param_06");

                entity.Property(e => e.Param07).HasColumnName("param_07");

                entity.Property(e => e.Param08).HasColumnName("param_08");
            });

            modelBuilder.Entity<UekMission>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("uek_mission");

                entity.Property(e => e.MissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("mission_id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<UekSpineAnimLink>(entity =>
            {
                entity.HasKey(e => e.SpineId);

                entity.ToTable("uek_spine_anim_link");

                entity.HasIndex(e => e.AnimNum, "uek_spine_anim_link_0_anim_num");

                entity.Property(e => e.SpineId)
                    .ValueGeneratedNever()
                    .HasColumnName("spine_id");

                entity.Property(e => e.AnimNum).HasColumnName("anim_num");
            });

            modelBuilder.Entity<UniqueEquipmentCraft>(entity =>
            {
                entity.HasKey(e => e.EquipId);

                entity.ToTable("unique_equipment_craft");

                entity.Property(e => e.EquipId)
                    .ValueGeneratedNever()
                    .HasColumnName("equip_id");

                entity.Property(e => e.ConsumeNum1).HasColumnName("consume_num_1");

                entity.Property(e => e.ConsumeNum10).HasColumnName("consume_num_10");

                entity.Property(e => e.ConsumeNum2).HasColumnName("consume_num_2");

                entity.Property(e => e.ConsumeNum3).HasColumnName("consume_num_3");

                entity.Property(e => e.ConsumeNum4).HasColumnName("consume_num_4");

                entity.Property(e => e.ConsumeNum5).HasColumnName("consume_num_5");

                entity.Property(e => e.ConsumeNum6).HasColumnName("consume_num_6");

                entity.Property(e => e.ConsumeNum7).HasColumnName("consume_num_7");

                entity.Property(e => e.ConsumeNum8).HasColumnName("consume_num_8");

                entity.Property(e => e.ConsumeNum9).HasColumnName("consume_num_9");

                entity.Property(e => e.CraftedCost).HasColumnName("crafted_cost");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId10).HasColumnName("item_id_10");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6).HasColumnName("item_id_6");

                entity.Property(e => e.ItemId7).HasColumnName("item_id_7");

                entity.Property(e => e.ItemId8).HasColumnName("item_id_8");

                entity.Property(e => e.ItemId9).HasColumnName("item_id_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");
            });

            modelBuilder.Entity<UniqueEquipmentDatum>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("unique_equipment_data");

                entity.Property(e => e.EquipmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("equipment_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.CraftFlg).HasColumnName("craft_flg");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnableDonation).HasColumnName("enable_donation");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentEnhancePoint).HasColumnName("equipment_enhance_point");

                entity.Property(e => e.EquipmentName).HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.RequireLevel).HasColumnName("require_level");

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UniqueEquipmentEnhanceDatum>(entity =>
            {
                entity.HasKey(e => new { e.EquipSlot, e.EnhanceLevel });

                entity.ToTable("unique_equipment_enhance_data");

                entity.Property(e => e.EquipSlot).HasColumnName("equip_slot");

                entity.Property(e => e.EnhanceLevel).HasColumnName("enhance_level");

                entity.Property(e => e.NeededMana).HasColumnName("needed_mana");

                entity.Property(e => e.NeededPoint).HasColumnName("needed_point");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");
            });

            modelBuilder.Entity<UniqueEquipmentEnhanceRate>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("unique_equipment_enhance_rate");

                entity.Property(e => e.EquipmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("equipment_id");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentName).HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UniqueEquipmentRankup>(entity =>
            {
                entity.HasKey(e => new { e.EquipId, e.UniqueEquipRank });

                entity.ToTable("unique_equipment_rankup");

                entity.HasIndex(e => e.EquipId, "unique_equipment_rankup_0_equip_id");

                entity.Property(e => e.EquipId).HasColumnName("equip_id");

                entity.Property(e => e.UniqueEquipRank).HasColumnName("unique_equip_rank");

                entity.Property(e => e.ConsumeNum1).HasColumnName("consume_num_1");

                entity.Property(e => e.ConsumeNum10).HasColumnName("consume_num_10");

                entity.Property(e => e.ConsumeNum2).HasColumnName("consume_num_2");

                entity.Property(e => e.ConsumeNum3).HasColumnName("consume_num_3");

                entity.Property(e => e.ConsumeNum4).HasColumnName("consume_num_4");

                entity.Property(e => e.ConsumeNum5).HasColumnName("consume_num_5");

                entity.Property(e => e.ConsumeNum6).HasColumnName("consume_num_6");

                entity.Property(e => e.ConsumeNum7).HasColumnName("consume_num_7");

                entity.Property(e => e.ConsumeNum8).HasColumnName("consume_num_8");

                entity.Property(e => e.ConsumeNum9).HasColumnName("consume_num_9");

                entity.Property(e => e.CraftedCost).HasColumnName("crafted_cost");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId10).HasColumnName("item_id_10");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6).HasColumnName("item_id_6");

                entity.Property(e => e.ItemId7).HasColumnName("item_id_7");

                entity.Property(e => e.ItemId8).HasColumnName("item_id_8");

                entity.Property(e => e.ItemId9).HasColumnName("item_id_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");

                entity.Property(e => e.UnitLevel).HasColumnName("unit_level");
            });

            modelBuilder.Entity<UnitAttackPattern>(entity =>
            {
                entity.HasKey(e => e.PatternId);

                entity.ToTable("unit_attack_pattern");

                entity.Property(e => e.PatternId)
                    .ValueGeneratedNever()
                    .HasColumnName("pattern_id");

                entity.Property(e => e.AtkPattern1).HasColumnName("atk_pattern_1");

                entity.Property(e => e.AtkPattern10).HasColumnName("atk_pattern_10");

                entity.Property(e => e.AtkPattern11).HasColumnName("atk_pattern_11");

                entity.Property(e => e.AtkPattern12).HasColumnName("atk_pattern_12");

                entity.Property(e => e.AtkPattern13).HasColumnName("atk_pattern_13");

                entity.Property(e => e.AtkPattern14).HasColumnName("atk_pattern_14");

                entity.Property(e => e.AtkPattern15).HasColumnName("atk_pattern_15");

                entity.Property(e => e.AtkPattern16).HasColumnName("atk_pattern_16");

                entity.Property(e => e.AtkPattern17).HasColumnName("atk_pattern_17");

                entity.Property(e => e.AtkPattern18).HasColumnName("atk_pattern_18");

                entity.Property(e => e.AtkPattern19).HasColumnName("atk_pattern_19");

                entity.Property(e => e.AtkPattern2).HasColumnName("atk_pattern_2");

                entity.Property(e => e.AtkPattern20).HasColumnName("atk_pattern_20");

                entity.Property(e => e.AtkPattern3).HasColumnName("atk_pattern_3");

                entity.Property(e => e.AtkPattern4).HasColumnName("atk_pattern_4");

                entity.Property(e => e.AtkPattern5).HasColumnName("atk_pattern_5");

                entity.Property(e => e.AtkPattern6).HasColumnName("atk_pattern_6");

                entity.Property(e => e.AtkPattern7).HasColumnName("atk_pattern_7");

                entity.Property(e => e.AtkPattern8).HasColumnName("atk_pattern_8");

                entity.Property(e => e.AtkPattern9).HasColumnName("atk_pattern_9");

                entity.Property(e => e.LoopEnd).HasColumnName("loop_end");

                entity.Property(e => e.LoopStart).HasColumnName("loop_start");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<UnitBackground>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_background");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.BgName).HasColumnName("bg_name");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");
            });

            modelBuilder.Entity<UnitComment>(entity =>
            {
                entity.ToTable("unit_comments");

                entity.HasIndex(e => e.UnitId, "unit_comments_0_unit_id");

                entity.HasIndex(e => new { e.UnitId, e.UseType }, "unit_comments_0_unit_id_1_use_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ChangeFace).HasColumnName("change_face");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FaceId).HasColumnName("face_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.UseType).HasColumnName("use_type");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<UnitDatum>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_data");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.AtkType).HasColumnName("atk_type");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Cutin1).HasColumnName("cutin_1");

                entity.Property(e => e.Cutin1Star6).HasColumnName("cutin1_star6");

                entity.Property(e => e.Cutin2).HasColumnName("cutin_2");

                entity.Property(e => e.Cutin2Star6).HasColumnName("cutin2_star6");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ExskillDisplay).HasColumnName("exskill_display");

                entity.Property(e => e.GuildId).HasColumnName("guild_id");

                entity.Property(e => e.IsLimited).HasColumnName("is_limited");

                entity.Property(e => e.Kana).HasColumnName("kana");

                entity.Property(e => e.MotionType).HasColumnName("motion_type");

                entity.Property(e => e.MoveSpeed).HasColumnName("move_speed");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.OnlyDispOwned).HasColumnName("only_disp_owned");

                entity.Property(e => e.PrefabId).HasColumnName("prefab_id");

                entity.Property(e => e.PrefabIdBattle).HasColumnName("prefab_id_battle");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.SeType).HasColumnName("se_type");

                entity.Property(e => e.SearchAreaWidth).HasColumnName("search_area_width");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");
            });

            modelBuilder.Entity<UnitEnemyDatum>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_enemy_data");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.AtkType).HasColumnName("atk_type");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Cutin).HasColumnName("cutin");

                entity.Property(e => e.CutinStar6).HasColumnName("cutin_star6");

                entity.Property(e => e.MotionType).HasColumnName("motion_type");

                entity.Property(e => e.MoveSpeed).HasColumnName("move_speed");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.PrefabId).HasColumnName("prefab_id");

                entity.Property(e => e.SeType).HasColumnName("se_type");

                entity.Property(e => e.SearchAreaWidth).HasColumnName("search_area_width");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");

                entity.Property(e => e.VisualChangeFlag).HasColumnName("visual_change_flag");
            });

            modelBuilder.Entity<UnitIntroduction>(entity =>
            {
                entity.ToTable("unit_introduction");

                entity.HasIndex(e => e.GachaId, "unit_introduction_0_gacha_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.IntroductionNumber).HasColumnName("introduction_number");

                entity.Property(e => e.MaximumChunkSize1).HasColumnName("maximum_chunk_size_1");

                entity.Property(e => e.MaximumChunkSize2).HasColumnName("maximum_chunk_size_2");

                entity.Property(e => e.MaximumChunkSize3).HasColumnName("maximum_chunk_size_3");

                entity.Property(e => e.MaximumChunkSizeLoop1).HasColumnName("maximum_chunk_size_loop_1");

                entity.Property(e => e.MaximumChunkSizeLoop2).HasColumnName("maximum_chunk_size_loop_2");

                entity.Property(e => e.MaximumChunkSizeLoop3).HasColumnName("maximum_chunk_size_loop_3");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<UnitMotionList>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_motion_list");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.SpMotion).HasColumnName("sp_motion");
            });

            modelBuilder.Entity<UnitMypagePo>(entity =>
            {
                entity.ToTable("unit_mypage_pos");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.Scale).HasColumnName("scale");
            });

            modelBuilder.Entity<UnitProfile>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_profile");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.BirthDay).HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth).HasColumnName("birth_month");

                entity.Property(e => e.BloodType).HasColumnName("blood_type");

                entity.Property(e => e.CatchCopy).HasColumnName("catch_copy");

                entity.Property(e => e.Favorite).HasColumnName("favorite");

                entity.Property(e => e.Guild).HasColumnName("guild");

                entity.Property(e => e.GuildId).HasColumnName("guild_id");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Race).HasColumnName("race");

                entity.Property(e => e.SelfText).HasColumnName("self_text");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");

                entity.Property(e => e.Voice).HasColumnName("voice");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<UnitPromotion>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.PromotionLevel });

                entity.ToTable("unit_promotion");

                entity.HasIndex(e => e.UnitId, "unit_promotion_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.EquipSlot1).HasColumnName("equip_slot_1");

                entity.Property(e => e.EquipSlot2).HasColumnName("equip_slot_2");

                entity.Property(e => e.EquipSlot3).HasColumnName("equip_slot_3");

                entity.Property(e => e.EquipSlot4).HasColumnName("equip_slot_4");

                entity.Property(e => e.EquipSlot5).HasColumnName("equip_slot_5");

                entity.Property(e => e.EquipSlot6).HasColumnName("equip_slot_6");
            });

            modelBuilder.Entity<UnitPromotionStatus>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.PromotionLevel });

                entity.ToTable("unit_promotion_status");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UnitRarity>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.Rarity });

                entity.ToTable("unit_rarity");

                entity.HasIndex(e => e.UnitId, "unit_rarity_0_unit_id");

                entity.HasIndex(e => e.UnitMaterialId, "unit_rarity_0_unit_material_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.AccuracyGrowth).HasColumnName("accuracy_growth");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.AtkGrowth).HasColumnName("atk_growth");

                entity.Property(e => e.ConsumeGold).HasColumnName("consume_gold");

                entity.Property(e => e.ConsumeNum).HasColumnName("consume_num");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.DefGrowth).HasColumnName("def_growth");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.DodgeGrowth).HasColumnName("dodge_growth");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyRecoveryRateGrowth).HasColumnName("energy_recovery_rate_growth");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EnergyReduceRateGrowth).HasColumnName("energy_reduce_rate_growth");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpGrowth).HasColumnName("hp_growth");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.HpRecoveryRateGrowth).HasColumnName("hp_recovery_rate_growth");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.LifeStealGrowth).HasColumnName("life_steal_growth");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicCriticalGrowth).HasColumnName("magic_critical_growth");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicDefGrowth).HasColumnName("magic_def_growth");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicPenetrateGrowth).HasColumnName("magic_penetrate_growth");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MagicStrGrowth).HasColumnName("magic_str_growth");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalCriticalGrowth).HasColumnName("physical_critical_growth");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PhysicalPenetrateGrowth).HasColumnName("physical_penetrate_growth");

                entity.Property(e => e.UnitMaterialId).HasColumnName("unit_material_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveEnergyRecoveryGrowth).HasColumnName("wave_energy_recovery_growth");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");

                entity.Property(e => e.WaveHpRecoveryGrowth).HasColumnName("wave_hp_recovery_growth");
            });

            modelBuilder.Entity<UnitSkillDatum>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_skill_data");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.ExSkill1).HasColumnName("ex_skill_1");

                entity.Property(e => e.ExSkill2).HasColumnName("ex_skill_2");

                entity.Property(e => e.ExSkill3).HasColumnName("ex_skill_3");

                entity.Property(e => e.ExSkill4).HasColumnName("ex_skill_4");

                entity.Property(e => e.ExSkill5).HasColumnName("ex_skill_5");

                entity.Property(e => e.ExSkillEvolution1).HasColumnName("ex_skill_evolution_1");

                entity.Property(e => e.ExSkillEvolution2).HasColumnName("ex_skill_evolution_2");

                entity.Property(e => e.ExSkillEvolution3).HasColumnName("ex_skill_evolution_3");

                entity.Property(e => e.ExSkillEvolution4).HasColumnName("ex_skill_evolution_4");

                entity.Property(e => e.ExSkillEvolution5).HasColumnName("ex_skill_evolution_5");

                entity.Property(e => e.MainSkill1).HasColumnName("main_skill_1");

                entity.Property(e => e.MainSkill10).HasColumnName("main_skill_10");

                entity.Property(e => e.MainSkill2).HasColumnName("main_skill_2");

                entity.Property(e => e.MainSkill3).HasColumnName("main_skill_3");

                entity.Property(e => e.MainSkill4).HasColumnName("main_skill_4");

                entity.Property(e => e.MainSkill5).HasColumnName("main_skill_5");

                entity.Property(e => e.MainSkill6).HasColumnName("main_skill_6");

                entity.Property(e => e.MainSkill7).HasColumnName("main_skill_7");

                entity.Property(e => e.MainSkill8).HasColumnName("main_skill_8");

                entity.Property(e => e.MainSkill9).HasColumnName("main_skill_9");

                entity.Property(e => e.MainSkillEvolution1).HasColumnName("main_skill_evolution_1");

                entity.Property(e => e.MainSkillEvolution2).HasColumnName("main_skill_evolution_2");

                entity.Property(e => e.SpSkill1).HasColumnName("sp_skill_1");

                entity.Property(e => e.SpSkill2).HasColumnName("sp_skill_2");

                entity.Property(e => e.SpSkill3).HasColumnName("sp_skill_3");

                entity.Property(e => e.SpSkill4).HasColumnName("sp_skill_4");

                entity.Property(e => e.SpSkill5).HasColumnName("sp_skill_5");

                entity.Property(e => e.SpSkillEvolution1).HasColumnName("sp_skill_evolution_1");

                entity.Property(e => e.SpSkillEvolution2).HasColumnName("sp_skill_evolution_2");

                entity.Property(e => e.SpUnionBurst).HasColumnName("sp_union_burst");

                entity.Property(e => e.UnionBurst).HasColumnName("union_burst");

                entity.Property(e => e.UnionBurstEvolution).HasColumnName("union_burst_evolution");
            });

            modelBuilder.Entity<UnitStatusCoefficient>(entity =>
            {
                entity.HasKey(e => e.CoefficientId);

                entity.ToTable("unit_status_coefficient");

                entity.Property(e => e.CoefficientId)
                    .ValueGeneratedNever()
                    .HasColumnName("coefficient_id");

                entity.Property(e => e.AccuracyCoefficient).HasColumnName("accuracy_coefficient");

                entity.Property(e => e.AtkCoefficient).HasColumnName("atk_coefficient");

                entity.Property(e => e.DefCoefficient).HasColumnName("def_coefficient");

                entity.Property(e => e.DodgeCoefficient).HasColumnName("dodge_coefficient");

                entity.Property(e => e.EnergyRecoveryRateCoefficient).HasColumnName("energy_recovery_rate_coefficient");

                entity.Property(e => e.EnergyReduceRateCoefficient).HasColumnName("energy_reduce_rate_coefficient");

                entity.Property(e => e.ExskillEvolutionCoefficient).HasColumnName("exskill_evolution_coefficient");

                entity.Property(e => e.HpCoefficient).HasColumnName("hp_coefficient");

                entity.Property(e => e.HpRecoveryRateCoefficient).HasColumnName("hp_recovery_rate_coefficient");

                entity.Property(e => e.LifeStealCoefficient).HasColumnName("life_steal_coefficient");

                entity.Property(e => e.MagicCriticalCoefficient).HasColumnName("magic_critical_coefficient");

                entity.Property(e => e.MagicDefCoefficient).HasColumnName("magic_def_coefficient");

                entity.Property(e => e.MagicPenetrateCoefficient).HasColumnName("magic_penetrate_coefficient");

                entity.Property(e => e.MagicStrCoefficient).HasColumnName("magic_str_coefficient");

                entity.Property(e => e.OverallCoefficient).HasColumnName("overall_coefficient");

                entity.Property(e => e.PhysicalCriticalCoefficient).HasColumnName("physical_critical_coefficient");

                entity.Property(e => e.PhysicalPenetrateCoefficient).HasColumnName("physical_penetrate_coefficient");

                entity.Property(e => e.Skill1EvolutionCoefficient).HasColumnName("skill1_evolution_coefficient");

                entity.Property(e => e.Skill1EvolutionSlvCoefficient).HasColumnName("skill1_evolution_slv_coefficient");

                entity.Property(e => e.SkillLvCoefficient).HasColumnName("skill_lv_coefficient");

                entity.Property(e => e.UbEvolutionCoefficient).HasColumnName("ub_evolution_coefficient");

                entity.Property(e => e.UbEvolutionSlvCoefficient).HasColumnName("ub_evolution_slv_coefficient");

                entity.Property(e => e.WaveEnergyRecoveryCoefficient).HasColumnName("wave_energy_recovery_coefficient");

                entity.Property(e => e.WaveHpRecoveryCoefficient).HasColumnName("wave_hp_recovery_coefficient");
            });

            modelBuilder.Entity<UnitUniqueEquip>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_unique_equip");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.EquipId).HasColumnName("equip_id");

                entity.Property(e => e.EquipSlot).HasColumnName("equip_slot");
            });

            modelBuilder.Entity<UnlockRarity6>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.SlotId, e.UnlockLevel });

                entity.ToTable("unlock_rarity_6");

                entity.HasIndex(e => e.MaterialId, "unlock_rarity_6_0_material_id");

                entity.HasIndex(e => e.UnitId, "unlock_rarity_6_0_unit_id");

                entity.HasIndex(e => new { e.UnitId, e.SlotId }, "unlock_rarity_6_0_unit_id_1_slot_id");

                entity.HasIndex(e => new { e.UnitId, e.UnlockLevel }, "unlock_rarity_6_0_unit_id_1_unlock_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.SlotId).HasColumnName("slot_id");

                entity.Property(e => e.UnlockLevel).HasColumnName("unlock_level");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.ConsumeGold).HasColumnName("consume_gold");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MaterialCount).HasColumnName("material_count");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.MaterialType).HasColumnName("material_type");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.UnlockFlag).HasColumnName("unlock_flag");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UnlockSkillDatum>(entity =>
            {
                entity.HasKey(e => e.UnlockSkill);

                entity.ToTable("unlock_skill_data");

                entity.Property(e => e.UnlockSkill)
                    .ValueGeneratedNever()
                    .HasColumnName("unlock_skill");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");
            });

            modelBuilder.Entity<UnlockUnitCondition>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unlock_unit_condition");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unit_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.ConditionId1).HasColumnName("condition_id_1");

                entity.Property(e => e.ConditionId2).HasColumnName("condition_id_2");

                entity.Property(e => e.ConditionId3).HasColumnName("condition_id_3");

                entity.Property(e => e.ConditionId4).HasColumnName("condition_id_4");

                entity.Property(e => e.ConditionId5).HasColumnName("condition_id_5");

                entity.Property(e => e.ConditionType1).HasColumnName("condition_type_1");

                entity.Property(e => e.ConditionType2).HasColumnName("condition_type_2");

                entity.Property(e => e.ConditionType3).HasColumnName("condition_type_3");

                entity.Property(e => e.ConditionType4).HasColumnName("condition_type_4");

                entity.Property(e => e.ConditionType5).HasColumnName("condition_type_5");

                entity.Property(e => e.ConditionTypeDetail1).HasColumnName("condition_type_detail_1");

                entity.Property(e => e.ConditionTypeDetail2).HasColumnName("condition_type_detail_2");

                entity.Property(e => e.ConditionTypeDetail3).HasColumnName("condition_type_detail_3");

                entity.Property(e => e.ConditionTypeDetail4).HasColumnName("condition_type_detail_4");

                entity.Property(e => e.ConditionTypeDetail5).HasColumnName("condition_type_detail_5");

                entity.Property(e => e.Count1).HasColumnName("count_1");

                entity.Property(e => e.Count2).HasColumnName("count_2");

                entity.Property(e => e.Count3).HasColumnName("count_3");

                entity.Property(e => e.Count4).HasColumnName("count_4");

                entity.Property(e => e.Count5).HasColumnName("count_5");

                entity.Property(e => e.PreUnitId).HasColumnName("pre_unit_id");

                entity.Property(e => e.ReleaseEffectType).HasColumnName("release_effect_type");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");
            });

            modelBuilder.Entity<VisualCustomize>(entity =>
            {
                entity.ToTable("visual_customize");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ProfileLogo).HasColumnName("profile_logo");

                entity.Property(e => e.QuestTopMovie).HasColumnName("quest_top_movie");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StoryTopMovie).HasColumnName("story_top_movie");

                entity.Property(e => e.TitleMovie).HasColumnName("title_movie");

                entity.Property(e => e.TitlePrefab).HasColumnName("title_prefab");

                entity.Property(e => e.TitleVoice).HasColumnName("title_voice");

                entity.Property(e => e.WatchedStoryId).HasColumnName("watched_story_id");
            });

            modelBuilder.Entity<VoiceGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("voice_group");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("group_id");

                entity.Property(e => e.GroupIdComment).HasColumnName("group_id_comment");

                entity.Property(e => e.GroupUnitId01).HasColumnName("group_unit_id_01");

                entity.Property(e => e.GroupUnitId02).HasColumnName("group_unit_id_02");

                entity.Property(e => e.GroupUnitId03).HasColumnName("group_unit_id_03");

                entity.Property(e => e.GroupUnitId04).HasColumnName("group_unit_id_04");

                entity.Property(e => e.GroupUnitId05).HasColumnName("group_unit_id_05");
            });

            modelBuilder.Entity<VoiceGroupChara>(entity =>
            {
                entity.HasKey(e => e.GroupUnitId);

                entity.ToTable("voice_group_chara");

                entity.Property(e => e.GroupUnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("group_unit_id");

                entity.Property(e => e.GroupUnitIdComment).HasColumnName("group_unit_id_comment");

                entity.Property(e => e.UnitId01).HasColumnName("unit_id_01");

                entity.Property(e => e.UnitId02).HasColumnName("unit_id_02");

                entity.Property(e => e.UnitId03).HasColumnName("unit_id_03");

                entity.Property(e => e.UnitId04).HasColumnName("unit_id_04");

                entity.Property(e => e.UnitId05).HasColumnName("unit_id_05");

                entity.Property(e => e.UnitId06).HasColumnName("unit_id_06");

                entity.Property(e => e.UnitId07).HasColumnName("unit_id_07");

                entity.Property(e => e.UnitId08).HasColumnName("unit_id_08");

                entity.Property(e => e.UnitId09).HasColumnName("unit_id_09");

                entity.Property(e => e.UnitId10).HasColumnName("unit_id_10");
            });

            modelBuilder.Entity<VoteDatum>(entity =>
            {
                entity.HasKey(e => e.VoteId);

                entity.ToTable("vote_data");

                entity.Property(e => e.VoteId)
                    .ValueGeneratedNever()
                    .HasColumnName("vote_id");

                entity.Property(e => e.ResultEndTime).HasColumnName("result_end_time");

                entity.Property(e => e.ResultStartTime).HasColumnName("result_start_time");

                entity.Property(e => e.ResultStoryId).HasColumnName("result_story_id");

                entity.Property(e => e.StartStoryId).HasColumnName("start_story_id");

                entity.Property(e => e.VoteEndTime).HasColumnName("vote_end_time");

                entity.Property(e => e.VoteStartTime).HasColumnName("vote_start_time");
            });

            modelBuilder.Entity<VoteInfo>(entity =>
            {
                entity.HasKey(e => new { e.VoteId, e.VoteHelpIndex });

                entity.ToTable("vote_info");

                entity.Property(e => e.VoteId).HasColumnName("vote_id");

                entity.Property(e => e.VoteHelpIndex).HasColumnName("vote_help_index");

                entity.Property(e => e.VoteHelp).HasColumnName("vote_help");

                entity.Property(e => e.VoteTitle).HasColumnName("vote_title");
            });

            modelBuilder.Entity<VoteUnit>(entity =>
            {
                entity.HasKey(e => new { e.VoteId, e.UnitId });

                entity.ToTable("vote_unit");

                entity.Property(e => e.VoteId).HasColumnName("vote_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.UnitRarity).HasColumnName("unit_rarity");
            });

            modelBuilder.Entity<WaveGroupDatum>(entity =>
            {
                entity.ToTable("wave_group_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.DropRewardId1).HasColumnName("drop_reward_id_1");

                entity.Property(e => e.DropRewardId2).HasColumnName("drop_reward_id_2");

                entity.Property(e => e.DropRewardId3).HasColumnName("drop_reward_id_3");

                entity.Property(e => e.DropRewardId4).HasColumnName("drop_reward_id_4");

                entity.Property(e => e.DropRewardId5).HasColumnName("drop_reward_id_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.GuestEnemyId).HasColumnName("guest_enemy_id");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<Worldmap>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("worldmap");

                entity.Property(e => e.CourseId)
                    .ValueGeneratedNever()
                    .HasColumnName("course_id");

                entity.Property(e => e.EndAreaId).HasColumnName("end_area_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.QueId).HasColumnName("que_id");

                entity.Property(e => e.SheetId).HasColumnName("sheet_id");

                entity.Property(e => e.StartAreaId).HasColumnName("start_area_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

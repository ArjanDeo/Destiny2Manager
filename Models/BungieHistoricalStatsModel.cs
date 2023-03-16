namespace Destiny2ManagerMVC.Models
{
	public class BungieHistoricalStatsModel
	{
		public BungieHistoricalStatsResponse Response { get; set; }
		public int ErrorCode { get; set; }
		public int ThrottleSeconds { get; set; }
		public string ErrorStatus { get; set; }
		public string Message { get; set; }
		public MessageData MessageData { get; set; }
	}
	public class ActivitiesCleared
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class ActivitiesEntered
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class ActivitiesWon
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AdventuresCompleted
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class AllParticipantsCount
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AllParticipantsScore
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AllParticipantsTimePlayed
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AllPvE
	{
		public AllTime allTime { get; set; }
	}

	public class AllPvP
	{
		public AllTime allTime { get; set; }
	}

	public class AllTime
	{
		public ActivitiesCleared activitiesCleared { get; set; }
		public ActivitiesEntered activitiesEntered { get; set; }
		public Assists assists { get; set; }
		public TotalDeathDistance totalDeathDistance { get; set; }
		public AverageDeathDistance averageDeathDistance { get; set; }
		public TotalKillDistance totalKillDistance { get; set; }
		public Kills kills { get; set; }
		public AverageKillDistance averageKillDistance { get; set; }
		public SecondsPlayed secondsPlayed { get; set; }
		public Deaths deaths { get; set; }
		public AverageLifespan averageLifespan { get; set; }
		public BestSingleGameKills bestSingleGameKills { get; set; }
		public BestSingleGameScore bestSingleGameScore { get; set; }
		public OpponentsDefeated opponentsDefeated { get; set; }
		public Efficiency efficiency { get; set; }
		public KillsDeathsRatio killsDeathsRatio { get; set; }
		public KillsDeathsAssists killsDeathsAssists { get; set; }
		public ObjectivesCompleted objectivesCompleted { get; set; }
		public PrecisionKills precisionKills { get; set; }
		public ResurrectionsPerformed resurrectionsPerformed { get; set; }
		public ResurrectionsReceived resurrectionsReceived { get; set; }
		public Score score { get; set; }
		public HeroicPublicEventsCompleted heroicPublicEventsCompleted { get; set; }
		public AdventuresCompleted adventuresCompleted { get; set; }
		public Suicides suicides { get; set; }
		public WeaponKillsAutoRifle weaponKillsAutoRifle { get; set; }
		public WeaponKillsBeamRifle weaponKillsBeamRifle { get; set; }
		public WeaponKillsBow weaponKillsBow { get; set; }
		public WeaponKillsGlaive weaponKillsGlaive { get; set; }
		public WeaponKillsFusionRifle weaponKillsFusionRifle { get; set; }
		public WeaponKillsHandCannon weaponKillsHandCannon { get; set; }
		public WeaponKillsTraceRifle weaponKillsTraceRifle { get; set; }
		public WeaponKillsMachineGun weaponKillsMachineGun { get; set; }
		public WeaponKillsPulseRifle weaponKillsPulseRifle { get; set; }
		public WeaponKillsRocketLauncher weaponKillsRocketLauncher { get; set; }
		public WeaponKillsScoutRifle weaponKillsScoutRifle { get; set; }
		public WeaponKillsShotgun weaponKillsShotgun { get; set; }
		public WeaponKillsSniper weaponKillsSniper { get; set; }
		public WeaponKillsSubmachinegun weaponKillsSubmachinegun { get; set; }
		public WeaponKillsRelic weaponKillsRelic { get; set; }
		public WeaponKillsSideArm weaponKillsSideArm { get; set; }
		public WeaponKillsSword weaponKillsSword { get; set; }
		public WeaponKillsAbility weaponKillsAbility { get; set; }
		public WeaponKillsGrenade weaponKillsGrenade { get; set; }
		public WeaponKillsGrenadeLauncher weaponKillsGrenadeLauncher { get; set; }
		public WeaponKillsSuper weaponKillsSuper { get; set; }
		public WeaponKillsMelee weaponKillsMelee { get; set; }
		public WeaponBestType weaponBestType { get; set; }
		public AllParticipantsCount allParticipantsCount { get; set; }
		public AllParticipantsScore allParticipantsScore { get; set; }
		public AllParticipantsTimePlayed allParticipantsTimePlayed { get; set; }
		public LongestKillSpree longestKillSpree { get; set; }
		public LongestSingleLife longestSingleLife { get; set; }
		public MostPrecisionKills mostPrecisionKills { get; set; }
		public OrbsDropped orbsDropped { get; set; }
		public OrbsGathered orbsGathered { get; set; }
		public PublicEventsCompleted publicEventsCompleted { get; set; }
		public RemainingTimeAfterQuitSeconds remainingTimeAfterQuitSeconds { get; set; }
		public TeamScore teamScore { get; set; }
		public TotalActivityDurationSeconds totalActivityDurationSeconds { get; set; }
		public FastestCompletionMs fastestCompletionMs { get; set; }
		public LongestKillDistance longestKillDistance { get; set; }
		public HighestCharacterLevel highestCharacterLevel { get; set; }
		public HighestLightLevel highestLightLevel { get; set; }
		public FireTeamActivities fireTeamActivities { get; set; }
		public ActivitiesWon activitiesWon { get; set; }
		public AverageScorePerKill averageScorePerKill { get; set; }
		public AverageScorePerLife averageScorePerLife { get; set; }
		public WinLossRatio winLossRatio { get; set; }
		public CombatRating combatRating { get; set; }
	}

	public class Assists
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class AverageDeathDistance
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AverageKillDistance
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AverageLifespan
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AverageScorePerKill
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class AverageScorePerLife
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class Basic
	{
		public double value { get; set; }
		public string displayValue { get; set; }
	}

	public class BestSingleGameKills
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public string activityId { get; set; }
	}

	public class BestSingleGameScore
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public string activityId { get; set; }
	}

	public class Character
	{
		public string characterId { get; set; }
		public bool deleted { get; set; }
		public Results results { get; set; }
		public Merged merged { get; set; }
	}

	public class CombatRating
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class Deaths
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class Efficiency
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class FastestCompletionMs
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public string activityId { get; set; }
	}

	public class FireTeamActivities
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class HeroicPublicEventsCompleted
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class HighestCharacterLevel
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class HighestLightLevel
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class Kills
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class KillsDeathsAssists
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class KillsDeathsRatio
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class LongestKillDistance
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public string activityId { get; set; }
	}

	public class LongestKillSpree
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public string activityId { get; set; }
	}

	public class LongestSingleLife
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public string activityId { get; set; }
	}

	public class Merged
	{
		public AllTime allTime { get; set; }
	}

	public class MergedAllCharacters
	{
		public Results results { get; set; }
		public Merged merged { get; set; }
	}

	public class MergedDeletedCharacters
	{
		public Results results { get; set; }
		public Merged merged { get; set; }
	}

	public class HistoricalStatsMessageData
	{
	}

	public class MostPrecisionKills
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public string activityId { get; set; }
	}

	public class ObjectivesCompleted
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class OpponentsDefeated
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class OrbsDropped
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class OrbsGathered
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class Pga
	{
		public double value { get; set; }
		public string displayValue { get; set; }
	}

	public class PrecisionKills
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class PublicEventsCompleted
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class RemainingTimeAfterQuitSeconds
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class BungieHistoricalStatsResponse
	{
		public MergedDeletedCharacters mergedDeletedCharacters { get; set; }
		public MergedAllCharacters mergedAllCharacters { get; set; }
		public List<Character> characters { get; set; }
	}

	public class Results
	{
		public AllPvE allPvE { get; set; }
		public AllPvP allPvP { get; set; }
	}

	public class ResurrectionsPerformed
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class ResurrectionsReceived
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}



	public class Score
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class SecondsPlayed
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class Suicides
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class TeamScore
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class TotalActivityDurationSeconds
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class TotalDeathDistance
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class TotalKillDistance
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class WeaponBestType
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}

	public class WeaponKillsAbility
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsAutoRifle
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsBeamRifle
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsBow
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsFusionRifle
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsGlaive
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsGrenade
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsGrenadeLauncher
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsHandCannon
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsMachineGun
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsMelee
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsPulseRifle
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsRelic
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsRocketLauncher
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsScoutRifle
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsShotgun
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsSideArm
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsSniper
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsSubmachinegun
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsSuper
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsSword
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WeaponKillsTraceRifle
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
		public Pga pga { get; set; }
	}

	public class WinLossRatio
	{
		public string statId { get; set; }
		public Basic basic { get; set; }
	}


}

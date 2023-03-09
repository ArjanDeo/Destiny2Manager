﻿using Newtonsoft.Json;

namespace Destiny2ManagerMVC.Models
{
    public class Character
    {
        public Data data { get; set; }
        public int privacy { get; set; }
    }

    public class Data
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public string characterId { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public string minutesPlayedThisSession { get; set; }
        public string minutesPlayedTotal { get; set; }
        public int light { get; set; }
        public Stats stats { get; set; }
        public long raceHash { get; set; }
        public long genderHash { get; set; }
        public long classHash { get; set; }
        public int raceType { get; set; }
        public int classType { get; set; }
        public int genderType { get; set; }
        public string emblemPath { get; set; }
        public string emblemBackgroundPath { get; set; }
        public int emblemHash { get; set; }
        public EmblemColor emblemColor { get; set; }
        public LevelProgression levelProgression { get; set; }
        public int baseCharacterLevel { get; set; }
        public double percentToNextLevel { get; set; }
        public int titleRecordHash { get; set; }
    }

    public class EmblemColor
    {
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int alpha { get; set; }
    }

    public class LevelProgression
    {
        public int progressionHash { get; set; }
        public int dailyProgress { get; set; }
        public int dailyLimit { get; set; }
        public int weeklyProgress { get; set; }
        public int weeklyLimit { get; set; }
        public int currentProgress { get; set; }
        public int level { get; set; }
        public int levelCap { get; set; }
        public int stepIndex { get; set; }
        public int progressToNextLevel { get; set; }
        public int nextLevelAt { get; set; }
    }

    public class MessageData
    {
    }

    public class Response
    {
        public Character character { get; set; }
        public UninstancedItemComponents uninstancedItemComponents { get; set; }
    }

    public class CharacterDataAPIModel
    {
        public Response Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }

    public class Stats
    {
        [JsonProperty("1935470627")]
        public int _1935470627 { get; set; }

        [JsonProperty("2996146975")]
        public int _2996146975 { get; set; }

        [JsonProperty("392767087")]
        public int _392767087 { get; set; }

        [JsonProperty("1943323491")]
        public int _1943323491 { get; set; }

        [JsonProperty("1735777505")]
        public int _1735777505 { get; set; }

        [JsonProperty("144602215")]
        public int _144602215 { get; set; }

        [JsonProperty("4244567218")]
        public int _4244567218 { get; set; }
    }

    public class UninstancedItemComponents
    {
    }
}

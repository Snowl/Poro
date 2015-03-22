﻿﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace PoroLib.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.Summoner")]
    public class Summoner
    {
        [SerializedName("PreviousSeasonHighestTier")]
        public String PreviousSeasonHighestTier { get; set; }
        [SerializedName("PreviousSeasonHighestTeamReward")]
        public Int32 PreviousSeasonHighestTeamReward { get; set; }
        [SerializedName("internalName")]
        public String InternalName { get; set; }
        [SerializedName("acctId")]
        public Double AcctId { get; set; }
        [SerializedName("helpFlag")]
        public Boolean HelpFlag { get; set; }
        [SerializedName("sumId")]
        public Double SumId { get; set; }
        [SerializedName("profileIconId")]
        public Int32 ProfileIconId { get; set; }
        [SerializedName("displayEloQuestionaire")]
        public Boolean DisplayEloQuestionaire { get; set; }
        [SerializedName("lastGameDate")]
        public DateTime LastGameDate { get; set; }
        [SerializedName("advancedTutorialFlag")]
        public Boolean AdvancedTutorialFlag { get; set; }
        [SerializedName("revisionDate")]
        public DateTime RevisionDate { get; set; }
        [SerializedName("revisionId")]
        public Double RevisionId { get; set; }
        [SerializedName("seasonOneTier")]
        public String SeasonOneTier { get; set; }
        [SerializedName("name")]
        public String Name { get; set; }
        [SerializedName("nameChangeFlag")]
        public Boolean NameChangeFlag { get; set; }
        [SerializedName("tutorialFlag")]
        public Boolean TutorialFlag { get; set; }
        [SerializedName("socialNetworkUserIds")]
        public ArrayCollection SocialNetworkUserIds { get; set; }
    }
}

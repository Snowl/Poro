﻿﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace PoroLib.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.runes.SummonerRuneInventory")]
    public class SummonerRuneInventory
    {
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }

        [SerializedName("summonerRunes")]
        public ArrayCollection SummonerRunes { get; set; }

        [SerializedName("dateString")]
        public String DateString { get; set; }

        [SerializedName("summonerRunesJson")]
        public String SummonerRunesJson { get; set; }
    }
}

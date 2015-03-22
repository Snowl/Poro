﻿﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace PoroLib.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.masterybook.MasteryBookDTO")]
    public class MasteryBookDTO
    {
        [SerializedName("bookPagesJson")]
        public object BookPagesJson { get; set; }
        [SerializedName("bookPages")]
        public ArrayCollection BookPages { get; set; }
        [SerializedName("dateString")]
        public String DateString { get; set; }
        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
    }
}

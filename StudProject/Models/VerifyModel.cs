﻿using System.Collections.Generic;

namespace StudProject.Models
{
    public class VerifyModel
    {
        public List<CardModel> Cards { get; set; }
        public Dictionary<string, int> CardCount { get; set; }
        public Dictionary<CardTypeEnum, int> TypeCount { get; set; }
    }
}

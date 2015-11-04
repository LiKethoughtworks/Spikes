﻿using System.Collections.Generic;

namespace IntegrationTestSpike.HardMode.Models
{
    public struct Land
    {
        public int UpperLeftX;
        public int UpperLeftY;

        public int LowerRightX;
        public int LowerRightY;

        public List<Tower> Towers;
    }
}
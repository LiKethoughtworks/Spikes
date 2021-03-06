﻿using IntegrationTestSpike.TowerDemo.Models;

namespace IntegrationTestSpike.TowerDemo.Calculators
{
    public class MiniAttackCalculator : Calculator
    {
        public override TowerType TowerType
        {
            get { return TowerType.MiniAttack; }
        }

        public override int Calculate()
        {
            return 3;
        }
    }
}
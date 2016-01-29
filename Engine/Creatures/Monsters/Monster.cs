﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Creatures.Monsters
{
    public class Monster : Creature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int maximumDamage { get; set; }
        public int rewardExperiencePoints { get; set; }
        public int rewardGold { get; set; }

        public Monster(int ID, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            this.ID = ID;
            this.name = name;
            this.maximumDamage = maximumDamage;
            this.rewardExperiencePoints = rewardExperiencePoints;
            this.rewardGold = rewardGold;
        }
    }
}
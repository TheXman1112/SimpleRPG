using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
    public class MonsterEncounter
    {
        public int MonsterID { get; set; }
        public int ChanceOfEncounter { get; set; }

        public MonsterEncounter(int monsterID, int chanceOfEncounter)
        {
            MonsterID = monsterID;
            ChanceOfEncounter = chanceOfEncounter;
        }
    }
}

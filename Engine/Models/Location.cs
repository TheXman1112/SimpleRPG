using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgName { get; set; }
        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();

        public List<MonsterEncounter> MonstersHere { get; set; } =
            new List<MonsterEncounter>();

        public void AddMonster(int monsterID, int chanceOfEncounter)
        {
            if (MonstersHere.Exists(m => m.MonsterID == monsterID))
            {
                // Monster has already been added to location
                // Overwrite ChanceOfEncounter with new number
                MonstersHere.First(m => m.MonsterID == monsterID)
                    .ChanceOfEncounter = chanceOfEncounter;
            }
            else
            {
                // Monster is not at location, so add it
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncounter));
            }
        }

        public Monster GetMonster()
        {
            if (!MonstersHere.Any())
            {
                return null;
            }

            // Total percentages of all monsters at location
            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncounter);

            // Select random number between 1 and total (in case total is not 100)
            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);

            // Loop through monster list
            // adding monster's percentage chance of appearing to runningTotal
            // When random number is lower than runningTotal
            // that is the monster to return
            int runningTotal = 0;

            foreach(MonsterEncounter monsterEncounter in MonstersHere)
            {
                runningTotal += monsterEncounter.ChanceOfEncounter;

                if (randomNumber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID);
                }
            }

            // If there's a problem, return last monster in the list
            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);
        }
    }
}

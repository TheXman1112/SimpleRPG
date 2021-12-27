using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            //Declare item requirements for quest & declare reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            //Create quest
            _quests.Add(new Quest(1,
                "Clear the weed garden",
                "Kill the snakes, they keep eating my weed! Last time, they ate so much and started tripping out! So be careful!",
                itemsToComplete,
                25, 10,
                rewardItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0, "Home",
                "Your house",
                "/Engine;component/Images/Locations/Home.png");
            
            newWorld.AddLocation(-1, 0, "The Farm",
                "Abandonded house where kids go missing.",
                "/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(-2, 0, "The Cornfield",
                "Cornfield where the Quad T hunts.",
                "/Engine;component/Images/Locations/FarmFields.png");

            newWorld.LocationAt(-2, 0).AddMonster(2, 100);

            newWorld.AddLocation(-1, 1, "General Store",
                "A store for all your general needs.",
                "/Engine;component/Images/Locations/Trader.png");
            
            newWorld.AddLocation(0, 1, "The Fountain",
                "Fountain at the center of town.",
                "/Engine;component/Images/Locations/TownSquare.png");
            
            newWorld.AddLocation(1, 1, "Town Gate",
                "The gate to enter Taormina Estates.",
                "/Engine;component/Images/Locations/TownGate.png");
            
            newWorld.AddLocation(2, 1, "The Sticky Forest",
                "The trees in this forest are covered in a white sticky substance.",
                "/Engine;component/Images/Locations/SpiderForest.png");

            newWorld.LocationAt(2, 1).AddMonster(3, 100);
            
            newWorld.AddLocation(0, 2, "Hippie House",
                "There's a strong skunk smell coming from this house.",
                "/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.LocationAt(0, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 3, "Weed Farm",
                "That makes sense.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            newWorld.LocationAt(0, 3).AddMonster(1, 100);

            return newWorld;
        }
    }
}

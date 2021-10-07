using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrnetWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Xman";
            CurrentPlayer.CharacterClass = "Ranger";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            WorldFactory factory = new WorldFactory();
            CurrnetWorld = factory.CreateWorld();

            CurrentLocation = CurrnetWorld.LocationAt(0, 0);
        }
    }
}

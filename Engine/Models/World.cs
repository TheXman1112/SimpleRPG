using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imgName)
        {
            Location location = new Location();
            location.XCoordinate = xCoordinate;
            location.YCoordinate = yCoordinate;
            location.Name = name;
            location.Description = description;
            location.ImgName = imgName;

            _locations.Add(location);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location location in _locations)
            {
                if (location.XCoordinate == xCoordinate && location.YCoordinate == yCoordinate)
                {
                    return location;
                }
            }

            return null;
        }
    }
}

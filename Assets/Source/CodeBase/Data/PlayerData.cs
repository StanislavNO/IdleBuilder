using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public sealed class PlayerData
    {
        public static readonly int MaxLevel = 6;

        public PlayerData()
        {
        }

        public int Level { get; private set; }
        public int DroneCount { get; private set; }
        public int WagonCount { get; private set; }
        public int Coins { get; private set; }
        public int Recourses { get; private set; }
    }
}

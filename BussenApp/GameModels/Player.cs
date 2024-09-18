using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussenApp.GameModels
{
    public class Player
    {
        public String Name { get; set; }
        public Hand Hand { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

    }
}

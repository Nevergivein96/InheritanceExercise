using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive= true;
            Age= 3;
            LegCount= 4;
            LandSeaAir = "land";
        }
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanRegenerateTail { get; set; }
    }
}

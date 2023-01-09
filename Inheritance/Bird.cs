using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive= true;
            Age= 5;
            LegCount = 2;
            LandSeaAir = "Air";
        }
        public string WingColor { get; set; }
        public bool CanFly { get; set;}
        public bool Migrate { get; set;}
        public double BeakLength { get; set;}
    }
    

}

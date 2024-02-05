using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsWild { get; set; }
        public bool InZoo {  get; set; }
        public bool GoesInWater {  get; set; }
        public string TypeOfSkin {  get; set; }
    }
}

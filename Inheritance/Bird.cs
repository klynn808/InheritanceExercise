using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool DoesFly {  get; set; }
        public string BirdSound {  get; set; }

        public void MakeBirdSound()
        {
            Console.WriteLine(BirdSound);
        }
        public bool DoesMigrateInWinter {  get; set; }

        public bool IsDomestic {  get; set; }
    }
}

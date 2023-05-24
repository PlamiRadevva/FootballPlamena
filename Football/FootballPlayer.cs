using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public FootballPlayer() { }
        public FootballPlayer(int number, double height,string name,int age ):base(name,age)
        {
            Number = number;
            Height = height;
        }
    }
}

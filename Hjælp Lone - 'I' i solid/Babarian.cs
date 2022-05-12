using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Lone____I__i_solid
{
    public class Babarian : ICharacterBasic, IMelee
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }
    }
}

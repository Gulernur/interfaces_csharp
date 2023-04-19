using System;
namespace Interfaces
{
    public class Program
    {
        static GoTCharacter goTCharacter = new GoTCharacter(); 

        public static void Main(String[] args)
        {
            //Because the method is explicitly bound to this interfcae, the only way to call the method is to type cast it. 
            IHumanoid ih = (IHumanoid) goTCharacter;
            ih.Talk();

            IMagical im = (IMagical) goTCharacter;
            im.CastSpell(); 
        }
    }
}
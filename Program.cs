using System;
namespace Interfaces
{
    public class Program
    {
        static GoTCharacter goTCharacter = new GoTCharacter(); 

        public static void Main(String[] args)
        {
            goTCharacter.Talk();

            goTCharacter.CastSpell(); 
        }
    }
}
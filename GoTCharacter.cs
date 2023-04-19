using System;
public class GoTCharacter : IHumanoid, IMagical
{

    string? IHumanoid.Name {get; set;}

    int IHumanoid.Age {get; set;}

     string? IMagical.Element {get; set;}

     void IMagical.CastSpell()
    {
        Console.WriteLine("I can cast a spell"); 
    }

     void IHumanoid.Talk()
    {
        Console.WriteLine("I can talk");
    }
}
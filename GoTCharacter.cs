using System;
public class GoTCharacter : IHumanoid, IMagical
{

    string? IHumanoid.Name {get; set;}

    int IHumanoid.Age {get; set;}

     string? IMagical.Element {get; set;}

    public void CastSpell()
    {
        Console.WriteLine("I can cast a spell"); 
    }

    public void Talk()
    {
        Console.WriteLine("I can talk");
    }
}
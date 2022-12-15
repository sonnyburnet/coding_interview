namespace Study.OOP;

using static System.Console;
using System.IO;

[System.Flags]
public enum WondersOfTheAncientWorld : System.Byte
{
    None = 0b_0000_0000,
    GreatPyramidOfGiza = 0b_0000_0001,
    HangingGardensOfBabylon = 0b_0000_0010,
    ColossusOfRhodes = 0b_0000_0100
};


public class Person : System.Object
{
    public string? Name;
    public DateTime? DateOfBirth;
    public WondersOfTheAncientWorld? FavoriteAncientWonder;
}


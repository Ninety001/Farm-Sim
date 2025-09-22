using System.Xml.Linq;
using UnityEngine;

public class Horse : Animal
{
    public void init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} says: He He ");
    }
}

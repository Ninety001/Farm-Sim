using UnityEngine;

public class Chicken : Animal
{
    #region //Attributes
    //Chicken Attributes
    private int eggs;

    public int Eggs
    {
        get { return eggs; }
        private set
        {
            eggs = 0;
        }

    }
    #endregion

    #region //Behavior
    //Chicken Behavior
    public void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Eggs = 0;
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Katak! Katak!");
    }
    public void Sleep()
    {
        Debug.Log($"{Name} is sleeping");
        Debug.Log($"{Name} -> {Hunger} | {Happiness} ");
        AdjustHunger(+5);
        AdjustHappiness(+10);
    }

    #endregion
}


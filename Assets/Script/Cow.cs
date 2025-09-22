using UnityEngine;

public class Cow : Animal
{
    #region //Attributes
    private float milk;
    public float Milk
    {
        get { return milk ; }
        set
        {
            milk = 0;
        }

    }

    #endregion

    #region //Behavior
    //Chicken Behavior
    public void init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Milk = 0;
    }


    public override void MakeSound()
    {
        Debug.Log($"{Name} says: Mooooo!");
    }

    public void Moo()
    {
        AdjustHappiness(+10);
        Debug.Log($"{Name} giving a loud MOOMOOMOO! | Current Happiness: {Happiness} ");
    }

    #endregion
}
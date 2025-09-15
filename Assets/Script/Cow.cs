using UnityEngine;

public class Cow
{
    #region //Attributes
    //Chicken Attributes
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                name = "Unknown";
            }
            else
            {
                { name = value; }
            }
        }
    }

    private int hunger;
    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value > 50) hunger = 50;
            else if (value <= 0) { hunger = 0; }
            else hunger = value;
        }
    }
    private int happiness;
    public int Happiness
    {
        get { return happiness; }
        set
        {
            if (value > 50) happiness = 50;
            else if (value <= 0) { happiness = 0; }
            else happiness = value;
        }
    }
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
    public Cow(string newName, int newHunger, int newHappiness)
    {
        Name = newName; 
        Hunger = newHunger;
        Happiness = newHappiness;
        Milk = 0;
    }

    public void AdjustHunger(int value)
    {
        Hunger += value;
    }

    public void AdjustHappiness(int value)
    {
        Happiness += value;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says: Mooooo!");
    }

    public void Feed(string food)
    {
        Debug.Log($"{Name} is eating {food} ");
        AdjustHunger(-10);
        AdjustHappiness(+10);
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} | Hunger: {Hunger}, Happiness: {Happiness}, Milks: {Milk}");
    }

    public void Moo()
    {
        AdjustHappiness(+10);
        Debug.Log($"{Name} giving a loud MOOMOOMOO! | Current Happiness: {Happiness} ");
    }

    #endregion
}
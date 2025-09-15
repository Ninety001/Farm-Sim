using UnityEngine;

public class Cow : GameManager
{
    #region //Attributes
    //Chicken Attributes
    private string cowname;
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

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else { health = 0; }
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
    private int milk;

    public int Milk
    {
        get { return Milk ; }
        set
        {
            Milk = 0;
        }

    }

    #endregion

    #region //Behavior
    //Chicken Behavior
    public Cow(string newName, int newHealth, int newHunger, int newHappiness)
    {
        Name = newName;
        Health = newHealth;
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
        Debug.Log($"{Name} is eating ");
        AdjustHunger(-10);
        AdjustHappiness(+10);
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} | Health: {Health}, Hunger: {Hunger}, Happiness: {Happiness}, Milks: {Milk}");
    }

    public void Moo()
    {
        Debug.Log($"{Name} giving a loud MOOMOOMOO! ");
        AdjustHappiness(+10);
    }

    #endregion
}
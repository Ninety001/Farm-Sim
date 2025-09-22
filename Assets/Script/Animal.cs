using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    #region Attibutes
    private string name;
    public string Name
    {
        get { return name; }
        private set
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
        private set
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
        private set
        {
            if (value > 50) happiness = 50;
            else if (value <= 0) { happiness = 0; }
            else happiness = value;
        }
    }
    #endregion


    #region Behavior
    public virtual void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }
    public void AdjustHunger(int value)
    {
        Hunger += value;
    }

    public void AdjustHappiness(int value)
    {
        Happiness += value;
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{Name} says: Katak! Katak!");
    }

    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        Debug.Log($"{Name} received food in amount {amount}.");
    }

    public void Feed(string food, int amount)
    {
        AdjustHunger(-amount);
        Debug.Log($"{Name} received {food} in amount {amount}.");
    }



    public void GetStatus()
    {
        Debug.Log($"{Name} | Hunger: {Hunger}, Happiness: {Happiness},");
    }

    #endregion
}

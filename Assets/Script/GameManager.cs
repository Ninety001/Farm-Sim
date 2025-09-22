using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();
    public Horse horse;
    public Chicken chicken;
    public Cow cow;

    void Start()
    {
        Debug.Log("Welcome to MY FARM !!!");
        Debug.Log($"We have {animals.Count} animal!");

        chicken.Init("Ken",10,10);
        cow.Init("Moomoo",20,20);
        horse.Init("BigBlack",25,25);

        foreach (Animal animal in animals)
        {
            animal.GetStatus();
        }

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Feed(5);
        }

        chicken.Feed("corn", 5);
        chicken.Sleep();

        cow.Feed("Hay", 3);
        cow.Moo();

        horse.Feed("Carrot", 5);
    }


}

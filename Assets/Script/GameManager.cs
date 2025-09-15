using UnityEngine;
public class GameManager : MonoBehaviour
{
    void Start()
    {
        //Chicken
        Chicken chicken = new Chicken("Chicky", 30, 20);
        Cow cow = new Cow("Steak", 30, 20);

        chicken.GetStatus();
        chicken.MakeSound();

        chicken.Feed("Corn");
        chicken.GetStatus();

        chicken.Sleep();
        chicken.GetStatus();

        Debug.Log($"===================================================");

        
        cow.GetStatus();
        cow.MakeSound();

        cow.Feed("Hay");
        cow.GetStatus();

        cow.Moo();
        cow.GetStatus();
    }

}

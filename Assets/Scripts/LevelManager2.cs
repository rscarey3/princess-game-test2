using UnityEngine;
using UnityEngine.Events;

public class LevelManager2 : MonoBehaviour
{
    public static LevelManager2 main;

    public Transform[] path;
    public Transform startPoint;

    public int boneCurrency;

    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        boneCurrency = 100;
    }

    public void IncreaseBones(int amount)
    {
        boneCurrency += amount;
    }

    public bool SpendBones(int amount)
    {
        if (amount <= boneCurrency)
        {
            //buy item
            //buh
            boneCurrency -= amount;
            return true;
        } else
        {
            Debug.Log("not enough bones!"); //later swap to UI popup
            return false;
        }
    }
}

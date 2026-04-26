using UnityEngine;

public class PrincessBaseBehavior : MonoBehaviour
{
    [Header("References")]
    public int princessHealth;
    private int baseHealth;
    //code here

    public bool princessRescued = false;

    private void Awake()
    {
        princessHealth = 5;
        baseHealth = princessHealth;
        princessRescued = false;
    }

    public void DamageBase(int dmg)
    {
        princessHealth = princessHealth - dmg;
    }

    public void PrincessRescued()
    {
        princessRescued = true;
        //script to end game
    }
    void Update()
    {
        if (princessHealth > 0)
        {
            return;
        } else if (princessHealth <= 0)
        {
            PrincessRescued();
        }
    }
}

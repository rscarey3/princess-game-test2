using UnityEngine;

public class PrincessBaseBehavior : MonoBehaviour
{
    [Header("References")]
    public float princessHealth;
    private float baseHealth;
    //code here

    public bool princessRescued;

    private void Awake()
    {
        princessHealth = 5f;
        baseHealth = princessHealth;
        princessRescued = false;
    }

    public void DamageBase(float dmg)
    {
        //princessHealth = princessHealth - dmg;
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

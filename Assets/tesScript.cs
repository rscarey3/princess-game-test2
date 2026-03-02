using UnityEngine;

public class tesScript : MonoBehaviour
{

    // public GameObject previousPos;

    // public GameObject[] points;

    // public LevelManager levelManager;

    // public int danagerLevel;

    void Awake()
    {
        // points = FindObjectsWithTag("Points");
        // levelManager = FindObjectWithName("LevelManager");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // if (collision.hasTag("enemy"))
        // {
            // for(i = 0; i < points.length; i++)
            // {
            //     this.transform.position - points[i];
                // hold point in variable
            // }
            // levelManager.dangerCheck( with closest point);
        // }

         // if (collision.hasTag("corpse"))
        // {
            // danagerLevel += 1;
        // }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
       
    }
}

using UnityEngine;

public class LevelManager : MonoBehaviour
{

    // private Transform previousPoint;
    // private Transform currentPoint;
    public static LevelManager main;
    public Transform startPoint;
    public Transform[] firstSteps;
    public Transform[] mainpath;
    public int d1 = 0;
    public Transform[] altpathA;
    public int d2 = 0;
    public Transform[] altpathB;
    public int d3 = 0;

   // public GameObject FindNextPoint()
    //{
        //GameObject[] pointList;
        //pointList = GameObject.FindGameObjectsWithTag("Points");
        //GameObject closest = null;
        //float distance = Mathf.Infinity;
        //Vector3 position = transform.position;
        //foreach (GameObject po in pointList)
        //{
            //Vector3 diff = po.transform.position - position;
            //float curDistance = diff.sqrMagnitude;
           // if (curDistance < distance)
           // {
               // closest = po;
                //distance = curDistance;
           // }
        //}
        //return closest;
    //}

    private void Awake()
    {
        main = this;

    }

    void dangerCheck()
    {
        //if (transform.position = DangerCheck)
       // {  
       //     if (d1 <= d2 && d1 <= d3)
        //    {
       //       this.path = mainpath;
       //     } else if (d2 < d1 && d2 <= d3)
       //     {
       //       AudioManager.Instance.PlaySFX(AudioManager.Instance.enemyalertSFX);
        //      this.path = altpathA;
        //    } else
       //     {
       //       AudioManager.Instance.PlaySFX(AudioManager.Instance.enemyalertSFX);
         //     this.path = altpathB;
         //   }
        //enemy.selectedPath = this.path

       // }
    }

    void endCheck()
    {
        //if (previousPoint == "Turn Point")
        //{currentPoint = "End Point";}
    }

    void Start()
    {
        //EnemyMovement.target = GameObject.Find("Danger Check");
    }
   void Update()
    {
        // previousPoint = currentPoint;
        // currentPoint = pathIndex + 1;
        //if (this.dangerLevel != 0)
        //{
            //run FindNextPoint
        //} else if (this.dangerLevel == 0)
        //{
            //go for the next item in the basePath array
        //}
       //if (transform.position = "Danger Check")
       //{ dangerCheck();
       //}
    }
}

using UnityEngine;

public class LevelManager : MonoBehaviour
{

    // previousPoint;
    // currentPoint;
    public static LevelManager main;
    public Transform startPoint;
    public Transform[] mainpath;
    public Transform[] altpathA;
    public Transform[] altpathB;

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
        //if (possiblePoint == previousPoint)
        //{ Check again}
        // else {this.path = currentPoint;}
        //if (transform.position = DangerCheck)
       // {  
       //     int d1 = mainPath[1].dangerLevel;
        //    int d2 = altpathA[1].dangerLevel;
       //     int d3 = altpathB[1].dangerLevel;
       //     if (d1 <= d2 && d1 <= d3)
        //    {
       //       this.path = mainpath;
       //     } else if (d2 < d1 && d2 <= d3)
       //     {
        //      this.path = altpathA;
        //    } else
       //     {
         //     this.path = altpathB;
         //   }

       // }
    }

    void endCheck()
    {
        //if (previousPoint == "Turn Point")
        //{currentPoint = "End Point";}
    }

    void Start()
    {
        //code here
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
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
       //code here 
    }
}

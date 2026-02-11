using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    public Transform startPoint;
    public Transform[] path;
    public Transform[] basePath;

    public GameObject FindNextPoint()
    {
        GameObject[] pointList;
        pointList = GameObject.FindGameObjectsWithTag("Points");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject po in pointList)
        {
            Vector3 diff = po.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = po;
                distance = curDistance;
            }
        }
        return closest;
    }

    private void Awake()
    {
        main = this;

    }

    void Start()
    {
        //code here
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
   void Update()
    {
        if (this.dangerLevel != 0)
        {
            //run FindNextPoint
        } else if (this.dangerLevel == 0)
        {
            //go for the next item in the basePath array
        }
       //code here 
    }
}

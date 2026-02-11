using UnityEngine;

public class PointInfo : MonoBehaviour
{
    public int dangerLevel;
    public int visibleCorpses = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //code
    }

    // Update is called once per frame
    void Update()
    {
        //if (this.IsTrigger == true)
        //{
           // visibleCorpses++;
        //} else if (this.IsTrigger == false)
        //{
          //  visibleCorpses = 0;
        //}
        //add a check to update visibleCorpses
        dangerLevel = visibleCorpses;

    }
}

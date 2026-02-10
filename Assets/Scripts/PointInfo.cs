using UnityEngine;

public class PointInfo : MonoBehaviour
{
    private int dangerLevel;
    private int visibleEnemies;
    private int visibleCorpses;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add a check to update visibleEnemies
        //add a check to update visibleCorpses
        dangerLevel = dangerLevel + visibleCorpses + visibleEnemies;
    }
}

using UnityEngine;

public class LevelManager2 : MonoBehaviour
{
    public static LevelManager2 main;

    public Transform[] path;
    public Transform startPoint;

    private void Awake()
    {
        main = this;
    }
}

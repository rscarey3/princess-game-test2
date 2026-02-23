using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;
    public bool chosePath = false;
    //selectedPath = null;
   
    private void Start()
    {
       // target = LevelManager.main.path[pathIndex];
    }

    private void Update()
    {
        //if (Vector2.Distance(target.position, transform.position) <= 0.1f)
       // {
        //    pathIndex++;

        //    if (pathIndex == LevelManager.main.path.Length)
        //    {
        //        Destroy(gameObject);
        //    }
        //}
    }

}

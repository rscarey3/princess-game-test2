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
    public Transform path;
    public int enemyHealth;
    public bool isDead = false;
   
    private void Start()
    {
       //target = GameObject.Find("Danger Check");
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

        //if (enemyHealth <= 0)
        //{ this.isDead = true;
        //  Destroy(gameObject);
        //  Instantiate(corpsePrefab, transform.position, transform.rotation);
        //}
    }

}

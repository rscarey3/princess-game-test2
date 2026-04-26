using UnityEngine;

public class EnemyMovementTest : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Color slomoColor;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private ScreenShakeManager shake;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;

    private float baseSpeed;

    private Color startColor;

    void Start()
    {
        baseSpeed = moveSpeed;
        target = LevelManager2.main.path[pathIndex];
        startColor = sr.color;
    }

    void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;

            if (pathIndex == LevelManager2.main.path.Length)
            {
                EnemySpawnerTest.onEnemyDestroyTest.Invoke();
                Destroy(gameObject);
                //ScreenShakeManager.Shake(2f, 1f);
                return;
            } else
            {
                target = LevelManager2.main.path[pathIndex];
            }
        }

        if (moveSpeed < baseSpeed)
        {
            sr.color = slomoColor;
        } else if (moveSpeed == baseSpeed)
        {
            sr.color = startColor;
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.linearVelocity = direction * moveSpeed;
    }

   // private void FreezeCheck()
   // {
   //     if (moveSpeed > baseSpeed)
   //     {
   //         sr.color = slomoColor;
   //     } else if (moveSpeed == baseSpeed)
   //     {
   //         sr.color = startColor;
   //     }
   // }

    public void UpdateSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    //    FreezeCheck();
    }

    public void ResetSpeed()
    {
        moveSpeed = baseSpeed;
    }
}

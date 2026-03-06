using UnityEngine;

public class BulletTest : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float bulletSpeed = 5f;

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    private Transform target;

    public void SetTargetTest(Transform _target)
    {
        target = _target;
    }

    private void FixedUpdate()
    {
        if (!target) return;

        Vector2 direction = (target.position - transform. position).normalized;

        rb.linearVelocity = direction * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Take Health From Enemy
        Destroy(gameObject);
    }
    
}

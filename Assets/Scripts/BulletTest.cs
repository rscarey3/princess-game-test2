using UnityEngine;

public class BulletTest : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float bulletSpeed = 5f;

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    private Transform target;

    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform. position).normalized;

        rb.linearVelocity = direction * bulletSpeed;
    }
    
}

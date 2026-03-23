using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitPoints = 2;

    private bool isDead = false;

    public void TakeDamage(int dmg)
    {
        hitPoints -= dmg;

        if (hitPoints <= 0 && !isDead)
        {
            EnemySpawnerTest.onEnemyDestroyTest.Invoke();
            isDead = true;
            Destroy(gameObject);
        }
    }
}

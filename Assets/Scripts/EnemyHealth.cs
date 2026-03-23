using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitPoints = 2;

    public void TakeDamage(int dmg)
    {
        hitPoints -= dmg;

        if (hitPoints <= 0 )
        {
            EnemySpawnerTest.onEnemyDestroyTest.Invoke();
            Destroy(gameObject);
        }
    }
}

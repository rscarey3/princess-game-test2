using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject corpsePrefab;
    [SerializeField] private GameOverClass deadEnemies;

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
            deadEnemies.enemiesKilled++;
            Destroy(gameObject);
            Instantiate(corpsePrefab, this.transform.position, Quaternion.identity);
        }
    }
}

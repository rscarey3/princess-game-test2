using System.Collections;
using UnityEngine;

public class SloMoTower : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private LayerMask enemyMask;

    [Header("Attributes")]
    [SerializeField] private float targetingRange = 5f;
    [SerializeField] private float pps = .25f; //projectiles per second
    [SerializeField] private float freezeTime = 1f;

    private float timeUntilFire;

    void Update()
    {
        timeUntilFire += Time.deltaTime;

        if (timeUntilFire >= 1f / pps)
        {
            FreezeInRange();
            timeUntilFire = 0f;
        }
        
    }

    private void FreezeInRange()
    {
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, targetingRange, (Vector2)transform.position, 0f, enemyMask);

        if (hits.Length > 0)
        {
            for(int i = 0; i < hits.Length; i++)
            {
                RaycastHit2D hit = hits[i];

                EnemyMovementTest em = hit.transform.GetComponent<EnemyMovementTest>();
                em.UpdateSpeed(0.25f);

                StartCoroutine(ResetEnemySpeed(em));
            }
        }
    }

    private IEnumerator ResetEnemySpeed(EnemyMovementTest em)
    {
        yield return new WaitForSeconds(freezeTime);

        em.ResetSpeed();
    }
}

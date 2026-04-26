using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincessBaseBehavior : MonoBehaviour
{
    [Header("References")]
    [SerializeField] public int princessHealth;
    [SerializeField] private int baseHealth;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private ScreenShakeManager shake;
    [SerializeField] private GameOverClass gamover;
    //code here

    public bool princessRescued = false;

    private void Awake()
    {
        princessHealth = 5;
        baseHealth = princessHealth;
        princessRescued = false;
    }

    public void PrincessRescued()
    {
        princessRescued = true;
        SceneManager.LoadScene("GameOver");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shake.Shake(2f, 1f);
        princessHealth--;
    }

    void Update()
    {
        if (princessHealth > 0)
        {
            return;
        } else if (princessHealth <= 0)
        {
            PrincessRescued();
        }
    }
}

using UnityEngine;
using TMPro;

public class GameOverClass : MonoBehaviour
{
    [Header("References")]
    public PrincessBaseBehavior prescued;
    [SerializeField] private GameObject gameoverscreen;
    [SerializeField] private Animator anim;
    [SerializeField] TextMeshProUGUI killsUI;
    
    public int enemiesKilled;

    private void Awake()
    {
        gameoverscreen.SetActive(false);
        enemiesKilled = 0;
    }
    private void OnGUI()
    {
        killsUI.text = enemiesKilled.ToString();
    }

    void Update()
    {
        if (prescued.princessRescued = false)
        {
            return;
        } else if (prescued.princessRescued = true)
        {
            //anim.SetBool(CODE HERE) //add animation if time
            gameoverscreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

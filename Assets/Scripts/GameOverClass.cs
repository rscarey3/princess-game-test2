using UnityEngine;
using TMPro;

public class GameOverClass : MonoBehaviour
{
    [Header("References")]
    public PrincessBaseBehavior prescued;
    [SerializeField] private GameObject gameoverscreen;
    [SerializeField] private Animator anim;
    [SerializeField] TextMeshProUGUI killsUI;

    private void OnGUI()
    {
        //killsUI.text = [PUT THING HERE TO COUNT ENEMIES KILLED]
    }

    void Update()
    {
        if (prescued.princessRescued = false)
        {
            return;
        } else if (prescued.princessRescued = true)
        {
            //code to make the screen appear
            Time.timeScale = 0f;
        }
    }
}

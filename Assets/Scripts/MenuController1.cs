using UnityEngine;
using System.Collections;

public class MenuController1 : MonoBehaviour
{
    public CanvasGroup mainMenu;
    public CanvasGroup optionsMenu;
    public CanvasGroup creditsMenu;

    public float transitionDuration = 0.25f;
    
    void Start()
    {
        ShowMainMenuInstant();
    }

    public void OpenOptionsMenu()
    {
        StartCoroutine(TransitionMenus(mainMenu, optionsMenu));
    }

    public void OpenCreditsMenu()
    {
        StartCoroutine(TransitionMenus(creditsMenu, mainMenu));
    }

    public void OptionsBackToMainMenu()
    {
        StartCoroutine(TransitionMenus(optionsMenu, mainMenu));
    }

    public void CreditsBackToMainMenu()
    {
        StartCoroutine(TransitionMenus(creditsMenu, mainMenu));
    }

    void ShowMainMenuInstant()
    {
        mainMenu.alpha = 1; //alpha is connected to opacity
        mainMenu.interactable = true; //self explanatory
        mainMenu.blocksRaycasts = true; //whether or not it is running in the background while invisible

        optionsMenu.alpha = 0;
        optionsMenu.interactable = false;
        optionsMenu.blocksRaycasts = false;
        optionsMenu.gameObject.SetActive(false);

        creditsMenu.alpha = 0;
        creditsMenu.interactable = false;
        creditsMenu.blocksRaycasts = false;
        creditsMenu.gameObject.SetActive(false);
    }

    IEnumerator TransitionMenus(CanvasGroup currentMenu, CanvasGroup nextMenu)
    {
        float timer = 0;
        nextMenu.gameObject.SetActive(true);

        while (timer < transitionDuration)
        {
            timer += Time.deltaTime;
            float progress = timer / transitionDuration;
            currentMenu.alpha = 1 - progress;
            nextMenu.alpha = progress;
            yield return null;
        }
        currentMenu.interactable = false;
        currentMenu.blocksRaycasts = false;
        currentMenu.gameObject.SetActive(false);

        nextMenu.interactable = true;
        nextMenu.blocksRaycasts = true;
    }
}

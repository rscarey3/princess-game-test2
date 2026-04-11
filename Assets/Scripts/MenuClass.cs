using UnityEngine;
using TMPro;

public class MenuClass : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI bonesUI;
    [SerializeField] Animator anim;

    private bool isMenuOpen = true;

    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("ShopMenuOpen", isMenuOpen);
    }

    private void OnGUI()
    {
        bonesUI.text = LevelManager2.main.boneCurrency.ToString();
    }

    public void SetSelected()
    {
        //text
    }
}

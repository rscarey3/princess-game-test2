using UnityEngine;
using TMPro;

public class MenuClass : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI bonesUI;

    private void OnGUI()
    {
        bonesUI.text = LevelManager2.main.boneCurrency.ToString();
    }

    public void SetSelected()
    {
        //text
    }
}

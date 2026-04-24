using UnityEngine;

public class PopupClass : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject popupMenu;

    public bool isPopupOpen;

    private void Awake()
    {
        isPopupOpen = true;
    }
    public void togglePopup()
    {
        isPopupOpen = !isPopupOpen;
        if (isPopupOpen == false)
        {
            //popupMenu.SetActive(false);
        }
    }

    private void Update()
    {
      if (isPopupOpen == false)
        {
            Time.timeScale = 1f;
            popupMenu.SetActive(false);
            Debug.Log("Popup is closed");
            return;
        }  else if (isPopupOpen == true)
        {
            Time.timeScale = 0f;
        }
    }
}

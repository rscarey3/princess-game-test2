using UnityEngine;
using TMPro;

public class HealthUIClass : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI healthUI;
    [SerializeField] private PrincessBaseBehavior phealth;
    
    private void OnGUI()
    {
        healthUI.text = phealth.princessHealth.ToString();
    }
}

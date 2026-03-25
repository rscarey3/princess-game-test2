using UnityEngine;

public class CorpseBehavior : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;
    [Header("Attributes")]
    [SerializeField] public int value = 50;
    

    private Color startColor;

    private void Start()
    {
        startColor = sr.color;
    }

    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
        LevelManager2.main.IncreaseBones(value);
        Destroy(gameObject);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.bonePickupSFX);
    }

}

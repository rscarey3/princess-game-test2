using UnityEngine;

public class CorpseBehavior : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;
    [SerializeField] public AudioClip boneSFX;
    
    [Header("Attributes")]
    [SerializeField] public int value = 1;
    

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
        //bones += value;
        gameObject.GetComponent<AudioManager>().PlaySFX(boneSFX);
        Destroy(gameObject);
    }

}

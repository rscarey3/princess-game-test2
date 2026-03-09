using UnityEngine;
using DG.Tweening;

public class FloatingObjectExample : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveY(transform.position.y + 0.1f, 1f)
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.InOutSine);
    }
}

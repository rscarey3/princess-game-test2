using DG.Tweening;
using UnityEngine;

public class MoveExample : MonoBehaviour
{
    void Start()
    {
        transform.DOMove(new Vector3(5,2,0), 1.5f).SetEase(Ease.OutBounce);
    }
}

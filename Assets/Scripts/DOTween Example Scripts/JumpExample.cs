using DG.Tweening;
using UnityEngine;

public class JumpExample : MonoBehaviour
{
    private float x = 0f; //change to x location of object
    private float y = 0f; //change to y location of object
    void Start()
    {
        transform.DOJump(new Vector3(x, y), .5f, 3, 3f);
    }

}

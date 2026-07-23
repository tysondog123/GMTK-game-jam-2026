using System.Collections;
using UnityEngine;

public class WeponsSwap : MonoBehaviour
{
    [SerializeField]
    GameObject[] Wepons;
    [SerializeField]
    FollowCursor followCursor;

    bool SwapDelay =true;
    public void Laser()
    {
        if (SwapDelay)
        {
            SwapDelay = false;
            followCursor.Projectile = Wepons[0];
            StartCoroutine(Delay());
        }
        
    }
    public void Bomb()
    {
        if (SwapDelay)
        {
            SwapDelay = false;
            followCursor.Projectile = Wepons[2];
            StartCoroutine(Delay());
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        SwapDelay = true;
    }
}

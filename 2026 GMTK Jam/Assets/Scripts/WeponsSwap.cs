using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeponsSwap : MonoBehaviour
{
    
    [SerializeField]
    FollowCursor followCursor;

    bool SwapDelay =true;
    public void Sawp(GameObject Wepon)
    {
        SwapDelay = false;
        followCursor.Projectile = Wepon;
    }
   
    
}

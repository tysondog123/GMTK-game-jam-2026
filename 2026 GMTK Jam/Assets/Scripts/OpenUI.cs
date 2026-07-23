using UnityEngine;
using UnityEngine.UI;

public class OpenUI : MonoBehaviour
{
    [SerializeField]
    GameObject UI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void ToggelMenu()
    {
        if (UI.activeSelf)
        {
            UI.SetActive(false);
        }
        else
        {
            UI.SetActive(true);
        }
        
    }
}

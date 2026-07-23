using UnityEngine;

public class HPController : MonoBehaviour
{
    [SerializeField]
    float HP;
    public void DealDamage(float Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
    public string GetHP() 
    {
        return HP.ToString();
    }

}

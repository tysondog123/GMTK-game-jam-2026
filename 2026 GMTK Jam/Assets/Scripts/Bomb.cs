using UnityEngine;

public class Bomb : BaseProjectile
{
    public float Range;
    
    private void OnDestroy()
    {
        Collider2D[] Enemys = Physics2D.OverlapCircleAll(transform.position, Range);
        foreach (Collider2D Col in Enemys)
        {
            if (Col.GetComponent<BaseEnemyAI>())
            {
                Col.GetComponent<HPController>().DealDamage(Damage);
            }
        }
    }
}

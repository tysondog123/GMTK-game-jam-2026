using UnityEngine;

public class Bomb : BaseProjectile
{
    public float Range;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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

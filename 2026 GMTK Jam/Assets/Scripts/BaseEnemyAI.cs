using System;
using Unity.Mathematics;
using UnityEngine;

public class BaseEnemyAI : MonoBehaviour
{
    GameObject Player;
    Vector3 Goal;

    public float speed;
    [SerializeField]
    FireProjectile Shoot;
    [SerializeField]
    GameObject spawnPoint;
    [SerializeField]
    GameObject Projectile;
    [SerializeField]
    Color ProjectileColour;

    Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = FindFirstObjectByType<FollowCursor>().gameObject;

        
        direction = Player.transform.position - transform.position;

        float Radians = Mathf.Atan2(direction.x, direction.y);
        Radians = Radians * (180 / math.PI);
        quaternion Target = Quaternion.Euler(0, 0, -Radians);
        transform.rotation = Target;
    }

    // Update is called once per frame
    void Update()
    {
        Goal = Player.transform.position - transform.position;

        if (Goal.magnitude > 4)
        {
            transform.position += (Goal.normalized * speed) * Time.deltaTime;
        }
        else
        {
            Shoot.fireProjectile(Projectile, spawnPoint, direction, "Player",ProjectileColour);
        }

    }
    
}

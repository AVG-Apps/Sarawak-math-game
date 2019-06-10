using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 10f;
        public Rigidbody2D rb;
        public int damage = 10;

        // Start is called before the first frame update
        void Start()
        {
            rb.velocity = transform.right * speed;
        }

        void OnTriggerEnter2D(Collider2D hitInfo)
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();

            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}

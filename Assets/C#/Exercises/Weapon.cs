using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Weapon : MonoBehaviour
    {
        public Transform firepoint;
        public GameObject bulletPrefab;
        private Excercise exercise;

        private void Awake()
        {
            exercise = FindObjectOfType<Excercise>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.anyKeyDown)
            {
                shoot();
            }
        }

        void shoot()
        {
            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        }
    }
}

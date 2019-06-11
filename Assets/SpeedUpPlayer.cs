using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{

    public class SpeedUpPlayer : MonoBehaviour
    {
        private Player playerManager;

        void Start()
        {
            playerManager = FindObjectOfType<Player>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {

            if (other.tag == "Player")
            {
                playerManager.setSpeedMovement(800f);
            }
        }


        // Update is called once per frame
        void Update()
        {
            
        }
    }
}

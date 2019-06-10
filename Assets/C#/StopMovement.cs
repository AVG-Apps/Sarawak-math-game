using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{

    public class StopMovement : MonoBehaviour
    {
        private Player player;
        public GameObject bigBossTrigger;
        private Excercise exercise;

        void Start()
        {
            player = FindObjectOfType<Player>();
            exercise = FindObjectOfType<Excercise>();
        }


        private void OnTriggerEnter2D(Collider2D playerCollider)
        {
            if (playerCollider.tag == "Player")
            {
                exercise.bigboss = true;
                player.move = false;
                Destroy(bigBossTrigger);
            }
        }
    }
}

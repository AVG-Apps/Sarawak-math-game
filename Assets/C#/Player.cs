using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Player : MonoBehaviour
    {
        public GameObject player;
        public float moveSpeed;
        public float currentPos;
        public bool posDown = true;
        public bool move = true;
        Vector3 startPos;

        void Update()
        {
            if (move == true)
            {
                transform.Translate((new Vector3(1, 0, 0)) * moveSpeed * Time.deltaTime);
                this.currentPos = player.transform.position.y;
            }

        }

        public void setSpeedMovement(float number)
        {
            this.moveSpeed = number;
        }

        public IEnumerator changeXDirection(int direction)
        { 
            float timePassed = 0;

            while (timePassed < 1)
            {
                player.transform.Translate(direction * 0.5f * Time.deltaTime, 0, 0);

                timePassed += Time.deltaTime;

                //Animation boom

                yield return null;
            }
        }

        public IEnumerator changeYDirection(int direction)
        {
            float timePassed = 0;

            while (timePassed < 1.5)
            {
                player.transform.Translate(0, direction * 300f * Time.deltaTime, 0);
                timePassed += Time.deltaTime;

                yield return null;
            }
        }
    }
}
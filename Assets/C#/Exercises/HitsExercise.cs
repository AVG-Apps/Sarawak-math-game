using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace monkeyMath
{
    public class HitsExercise : MonoBehaviour
    {
        #region Attribute
        public Transform exerciseSprite;
        public float speed = 5f;

        private Player player;

        private Excercise[] listExercises;
        private bool hit = false;
        float timePassed = 0;
        #endregion


        private void Start()
        {
            player = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            if (hit == true)
            {
                StartCoroutine(changeXDirection(-1));
                Destroy(gameObject, 1f);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                hitObstacle();
            }
        }

        public void hitObstacle()
        {
            hit = true;
        }


        IEnumerator changeXDirection(int direction)
        {
            while (timePassed < 4)
            {
                player.transform.Translate(direction * 3f * Time.deltaTime, 0, 0);
                timePassed += Time.deltaTime;

                //Animation boom

                yield return null;
            }
        }

    }
}


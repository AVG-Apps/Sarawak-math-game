using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace monkeyMath
{
    public class HitsExercise : MonoBehaviour
    {
        #region Attribute
        public float speed = 5f;

        private Player player;
        private Live liveManager;
        //private Excercise[] listExercises;
        private LevelManager levelManager;

        private bool hit = false;
        float timePassed = 0;
        #endregion


        private void Start()
        {
            player = FindObjectOfType<Player>();
            liveManager = FindObjectOfType<Live>();
            levelManager = FindObjectOfType<LevelManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if (hit == true)
            {
                StartCoroutine(changeXDirection(-1));

                if (levelManager.totalLives == 0)
                    {
                        Debug.Log("Game Over");
                        //gameover();
                    }

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
            destroyLife();
        }

        public void destroyLife()
        {
            Destroy(gameObject, 1f);

            GameObject[] lifes = levelManager.lifes;
            Destroy(lifes[levelManager.totalLives - 1].gameObject, 1f);

            levelManager.totalLives -= 1;
        }


        IEnumerator changeXDirection(int direction)
        {
            while (timePassed < 4)
            {
                player.transform.Translate(direction * 150f * Time.deltaTime, 0, 0);
                timePassed += Time.deltaTime;
                Debug.Log("go left monkey!");
                //Animation boom

                yield return null;
            }
        }
    }
}


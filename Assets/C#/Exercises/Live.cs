using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Live : MonoBehaviour
    {
        public Sprite fullLive;
        //public Sprite loseLive;


        private LevelManager levelmanager;

        private void Start()
        {
            levelmanager = FindObjectOfType<LevelManager>();
        }

        //public void setLoseLife(Live live)
        //{
        //    levelmanager.totalLives -= 1;
        //    //loseLive = Resources.Load<Sprite>("Heart-full");
        //    //live.GetComponent<SpriteRenderer>().sprite = loseLive;
        //}

        public void loseLife()
        {
            Destroy(gameObject, -1f);
        }
    }
}


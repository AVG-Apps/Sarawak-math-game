using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace monkeyMath
{

    public class Excercise : MonoBehaviour
    {
        #region Attribute
        public string exercise;
        public int answer;
        public bool posDown;
        public bool bigboss = false;

        private LevelManager levelManager;
        private Player player;
        private Excercise[] listExercises;

        private Vector3 updatedPos;
        int firstNumber;
        int secondNumber;

        public float EPSILON { get; private set; }
        #endregion

        void Awake()
        {
            levelManager = FindObjectOfType<LevelManager>();
            player = FindObjectOfType<Player>();
            listExercises = levelManager.exercises;
        }

        public void setExercise()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int position = UnityEngine.Random.Range(0, 1);

            if (position == 1)
            {
                firstNumber = 1;
                secondNumber = UnityEngine.Random.Range(0, 9);
            }

            if (position == 0)
            {
                firstNumber = UnityEngine.Random.Range(0, 9);
                secondNumber = 1;
            }

            this.answer = firstNumber + secondNumber;
            this.exercise = firstNumber + "+" + secondNumber;
            }


        public void changePosition(Excercise exercise, int changeValue)
        {
            exercise.transform.Translate(0, changeValue * 7, 0);
        }


        public void nextExercise()
        {
            //if (bigboss != true)
                levelManager.currentExercise += 1;
                levelManager.checkExercisePosition();

            //else
            //{
            //    levelManager.checkAnswer();
            //    Debug.Log("Enter Big Boss");
            //}
        }
    }
}
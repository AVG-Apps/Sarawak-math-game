using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace monkeyMath
{

    public class LevelManager : MonoBehaviour
    {
        //Public variables
        public GameObject answerLabel;
        public Excercise[] exercises;
        public int currentExercise;

        private Player player;
        private Excercise exercise;

        //Not public variables
        string answer = " ";

        // Start is called before the first frame update
        [Obsolete]

        // Start is called before the first frame update
        private void Awake()
        {
            player = FindObjectOfType<Player>();
            exercise = FindObjectOfType<Excercise>();
        }

        void Start()
        {
            answerLabel.SetActive(false);
            for (int i = 0; i < exercises.Length; i++)
            {
                setLabels(exercises[i]);
            }
        }

        private void Update()
        {
        }

        public void changeAnswerLabel(string number)
        {
            
            answerLabel.SetActive(true);
            //StartCoroutine(FadeTextToFullAlpha(0.1f, answerLabel.GetComponent<Text>()));

            if (number != "remove")
            {
                if (answer.Length > 1) { answer = answer.Substring(1); }
                answer += number;
            }

            else
            {
                if (answer.Length > 1) { answer = answer.Substring(2); }
                if (answer.Length == 1) { answer = answer.Substring(1); }
            }
            answerLabel.GetComponent<Text>().text = answer;
            checkAnswer();
        }

        public void checkAnswer()
        {
            if (String.IsNullOrEmpty(answer) != true)
            {
                if (exercises[currentExercise].answer == Int32.Parse(answer))
                {
                    Debug.Log("Answer Correct");
                    answer = " ";

                    if (player.posDown == true)
                    {
                        int direction = +1;
                        StartCoroutine(player.changeYDirection(direction));
                        player.posDown = !player.posDown;
                    }

                    else
                    {
                        int direction = -1;
                        StartCoroutine(player.changeYDirection(direction));
                        player.posDown = !player.posDown;
                    }
                }

            }
        }

        public void setLabels(Excercise exercise)
        {
            {
                exercise.setExercise();
                exercise.GetComponentInChildren<Text>().text = exercise.exercise;
            }
        }   

        public void checkExercisePosition()
        {
            if (player.posDown == true)
            {
                if (exercises[currentExercise].posDown != true)
                {
                    exercise.changePosition(exercises[currentExercise], -1);
                }
            }

            if (player.posDown != true)
            {
                if (exercises[currentExercise].posDown == true)
                {
                    exercise.changePosition(exercises[currentExercise], +1);
                }
            }
        }
    }
}

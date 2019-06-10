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
        int firstNumber;
        int secondNumber;
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
            setLabels(exercises);
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

        public void setLabels(Excercise[] exercises)
        {
            foreach (Excercise excercise in exercises)
            {
                int position = UnityEngine.Random.Range(0, 1);

                if (position == 1)
                {
                    firstNumber = UnityEngine.Random.Range(0, 9);
                    secondNumber = 1;
                }

                if (position == 0)
                {
                    firstNumber = UnityEngine.Random.Range(0, 9);
                    secondNumber = 1;
                }
                excercise.setExercise(firstNumber, secondNumber);
                excercise.GetComponentInChildren<Text>().text = excercise.exercise;
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

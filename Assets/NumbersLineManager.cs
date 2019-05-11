using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace mathProject
{
    public class Number : MonoBehaviour

    {
        public Vector3 initPos;
        public Vector3 initPosBox;
        public Vector3 initPosBoxOne;
        public Vector3 initPosBoxTwo;

        public Vector3 current;
        public bool answerCorrect = false;
        public int number = 3;


        public void setData(GameObject numObject, GameObject answerBox, int number)
        {
            this.initPos = numObject.transform.position;
            this.initPosBox = answerBox.transform.position;
            this.number = number;
            setImage(numObject, number);
        }

        public void setDataDivideNumbers(GameObject numObject, GameObject answerBoxOne, GameObject answerBoxTwo)
        {
            this.initPos = numObject.transform.position;
            this.initPosBoxOne = answerBoxOne.transform.position;
            this.initPosBoxTwo = answerBoxTwo.transform.position;

            //this.number = number;
            //setImage(numObject, number);
        }

        public Vector3 currentLocation(GameObject number)
        {
            return current = number.transform.position;
        }

        public void setImage(GameObject numObjects, int number)
        {
            Sprite imageNum = Resources.Load<Sprite>("Sprites/Numbers/" + number.ToString());
            Debug.Log(imageNum);
            numObjects.GetComponent<Image>().sprite = imageNum;
        }
    }



    public class NumbersLineManager : MonoBehaviour
    {
        //Visible numbers on the screen
        public GameObject one, two, three, four, five, six, seven;
        //Not visible objects on the screen
        public GameObject boxOne, boxTwo, boxThree, boxFour, boxFive, boxSix, boxSeven;
      
        //Modal object
        public GameObject modal;

        Number posOne = new mathProject.Number();
        Number posTwo = new mathProject.Number();
        Number posThree = new mathProject.Number();
        Number posFour = new mathProject.Number();
        Number posFive = new mathProject.Number();
        Number posSix = new mathProject.Number();
        Number posSeven = new mathProject.Number();

        private int startgetal;
        private int FREQUENTIE = 1;

        //Correct answers
        private Boolean answerOneCorrect, answerTwoCorrect, answerThreeCorrect, answerFourCorrect, answerFiveCorrect, answerSixCorrect, answerSevenCorrect;
        private bool levelCompleted;


        public void Start()
        {  
            startgetal = UnityEngine.Random.Range(0, 10);
            posOne.setData(numObject: one, answerBox: boxOne, number: startgetal);
            posTwo.setData(numObject: two, answerBox: boxTwo, number: posOne.number + FREQUENTIE);
            posThree.setData(numObject: three, answerBox: boxThree, number: posTwo.number + FREQUENTIE);
            posFour.setData(numObject: four, answerBox: boxFour, number: posThree.number + FREQUENTIE);
            posFive.setData(numObject: five, answerBox: boxFive, number: posFour.number + FREQUENTIE);
            posSix.setData(numObject: six, answerBox: boxSix, number: posFive.number + FREQUENTIE);
            posSeven.setData(numObject: seven, answerBox: boxSeven, number: posSix.number + FREQUENTIE);


            modal.SetActive(false);
        }


        public void DragNumber(GameObject number)
        {
            number.transform.position = Input.mousePosition;
        }


        //Drop methodes
        public void DropNumberOne()
        {
            posOne.currentLocation(one);
            float Distance = Vector3.Distance(posOne.current, posOne.initPosBox);
            if (Distance < 25)
            {
                posOne.current = posOne.initPosBox;
                posOne.answerCorrect = true;
                checkLevelsAnswers();
            }
            else {
                posOne.answerCorrect = false;
                one.transform.position = posOne.initPos; 
            }
        }

        public void DropNumberTwo()
        {
            posTwo.currentLocation(two);
            float Distance = Vector3.Distance(posTwo.current, posTwo.initPosBox);
            if (Distance < 25)
            {
                posTwo.current = posTwo.initPosBox;
                posTwo.answerCorrect = true;
                checkLevelsAnswers();
            }
            else {
                posTwo.answerCorrect = false;
                two.transform.position = posTwo.initPos; 
                }
        }


        public void DropNumberThree()
        {
            posThree.currentLocation(three);
            float Distance = Vector3.Distance(posThree.current, posThree.initPosBox);
            if (Distance < 25)
            {
                posThree.current = posThree.initPosBox;
                posThree.answerCorrect = true;
                checkLevelsAnswers();
            }
            else {
                posThree.answerCorrect = false;
                three.transform.position = posThree.initPos; 
                }
        }

        public void DropNumberFour()
        {
            posFour.currentLocation(four);
            float Distance = Vector3.Distance(posFour.current, posFour.initPosBox);
            if (Distance < 25)
            {
                posFour.current = posFour.initPosBox;
                posFour.answerCorrect = true;
                checkLevelsAnswers();
            }
            else {
                posFour.answerCorrect = false;
                four.transform.position = posFour.initPos; 
                }
        }

        public void DropNumberFive()
        {
            posFive.currentLocation(five);
            float Distance = Vector3.Distance(posFive.current, posFive.initPosBox);
            if (Distance < 25)
            {
                posFive.current = posFive.initPosBox;
                posFive.answerCorrect = true;
                checkLevelsAnswers();
            }
            else {
                posFive.answerCorrect = false;
                five.transform.position = posFive.initPos; 
                }
        }


        public void DropNumberSix()
        {
            posSix.currentLocation(six);
            float Distance = Vector3.Distance(posSix.current, posSix.initPosBox);
            if (Distance < 25)
            {
                posSix.current = posSix.initPosBox;
                posSix.answerCorrect = true;
                checkLevelsAnswers();
            }
            else {
                posSix.answerCorrect = false;
                six.transform.position = posSix.initPos; 
                }
        }

        public void DropNumberSeven()
        {
            posSeven.currentLocation(seven);
            float Distance = Vector3.Distance(posSeven.current, posSeven.initPosBox);
            if (Distance < 25)
            {
                posSeven.current = posSeven.initPosBox;
                posSeven.answerCorrect = true;
                checkLevelsAnswers();
            }
            else {
                posSeven.answerCorrect = false;
                seven.transform.position = posSeven.initPos; 
                }
        }

        public void checkLevelsAnswers()
        {
            if ((posOne.answerCorrect == true) &&
                (posTwo.answerCorrect == true) &&
                (posThree.answerCorrect == true) &&
                (posFour.answerCorrect == true) &&
                (posFive.answerCorrect == true) &&
                (posSix.answerCorrect == true) &&
                (posSeven.answerCorrect == true))
            {
                levelCompleted = true;
                modal.SetActive(true);
                Debug.Log("Level gehaald");
            }
        }

    }
}
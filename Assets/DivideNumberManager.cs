using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mathProject
{

    public class DivideNumberManager : MonoBehaviour
    {
        public GameObject answerOne, answerTwo, answerThree;
        public GameObject objectOne, objectTwo, objectThree, objectFour, objectFive, objectSix;
        public GameObject boxOne, boxTwo, boxThree, boxFour, boxFive, boxSix;

        Number numberOne = new mathProject.Number();
        Number numberTwo = new mathProject.Number();
        Number numberThree = new mathProject.Number();
        Number numberFour = new mathProject.Number();
        Number numberFive = new mathProject.Number();
        Number numberSix = new mathProject.Number();

        Number answerTop = new mathProject.Number();
        Number answerMiddle = new mathProject.Number();
        Number answerBottom = new mathProject.Number();

        public bool answerLineOne = false;
        public bool answerLineTwo = false;
        public bool answerLineThree = false;
        public bool answerExercerise = false;
        public GameObject modal;

        public int MAXRANGE = 10;


        // Start is called before the first frame update
        void Start()
        {
            setNumbers(answerOne, answerTop, objectOne, numberOne, objectTwo, numberTwo);
            setNumbers(answerTwo, answerMiddle, objectThree, numberThree, objectFour, numberFour);
            setNumbers(answerThree, answerBottom, objectFive, numberFive, objectSix, numberSix);

            numberOne.setDataDivideNumbers(numObject: objectOne, answerBoxOne: boxOne, answerBoxTwo: boxTwo);
            numberTwo.setDataDivideNumbers(numObject: objectTwo, answerBoxOne: boxOne, answerBoxTwo: boxTwo);
            numberThree.setDataDivideNumbers(numObject: objectThree, answerBoxOne: boxThree, answerBoxTwo: boxFour);
            numberFour.setDataDivideNumbers(numObject: objectFour, answerBoxOne: boxThree, answerBoxTwo: boxFour);
            numberFive.setDataDivideNumbers(numObject: objectFive, answerBoxOne: boxFive, answerBoxTwo: boxSix);
            numberSix.setDataDivideNumbers(numObject: objectSix, answerBoxOne: boxFive, answerBoxTwo: boxSix);
            modal.SetActive(false);

        }

        public void DragNumber(GameObject number)
        {
            number.transform.position = Input.mousePosition;
        }


        public void DropNumberOne()
        {
            numberOne.currentLocation(objectOne);
            float DisObject = Vector3.Distance(numberOne.current, numberTwo.current);
            float DistanceLeft = Vector3.Distance(numberOne.current, numberOne.initPosBoxOne);
            float DistanceRight = Vector3.Distance(numberOne.current, numberOne.initPosBoxTwo);

            if (DistanceLeft < 45 || DistanceRight < 45)
            {
                if (DisObject < 45)
                {
                    numberOne.answerCorrect = false;
                    objectOne.transform.position = numberOne.initPos;
                }
                else
                {
                    if (DistanceLeft < 45) { numberOne.current = numberOne.initPosBoxOne; }
                    if (DistanceRight < 45) { numberOne.current = numberOne.initPosBoxTwo; }

                    numberOne.answerCorrect = true;
                    answerLineOne = checkLineAnswers(numberOne.answerCorrect, numberTwo.answerCorrect);
                    checkAnwers(answerLineOne, answerLineTwo, answerLineThree);
                }
            }
            else
            {
                numberOne.answerCorrect = false;
                objectOne.transform.position = numberOne.initPos;
            }
        }

        public void DropNumberTwo()
        {
            numberTwo.currentLocation(objectTwo);
            float DisObject = Vector3.Distance(numberTwo.current, numberOne.current);
            float DistanceLeft = Vector3.Distance(numberTwo.current, numberTwo.initPosBoxOne);
            float DistanceRight = Vector3.Distance(numberTwo.current, numberTwo.initPosBoxTwo);

            if (DistanceLeft < 45 || DistanceRight < 45)
            {
                if (DisObject < 45)
                {
                    numberTwo.answerCorrect = false;
                    objectTwo.transform.position = numberTwo.initPos;
                }
                else
                {
                    if (DistanceLeft < 45) { numberTwo.current = numberTwo.initPosBoxOne; }
                    if (DistanceRight < 45) { numberTwo.current = numberTwo.initPosBoxTwo; }

                    numberTwo.answerCorrect = true;
                    answerLineOne = checkLineAnswers(numberTwo.answerCorrect, numberOne.answerCorrect);
                    checkAnwers(answerLineOne, answerLineTwo, answerLineThree);
                }
            }
            else
            {
                numberTwo.answerCorrect = false;
                objectTwo.transform.position = numberTwo.initPos;
            }
        }


        public void DropNumberThee()
        {
            numberThree.currentLocation(objectThree);
            float DisObject = Vector3.Distance(numberThree.current, numberFour.current);
            float DistanceLeft = Vector3.Distance(numberThree.current, numberThree.initPosBoxOne);
            float DistanceRight = Vector3.Distance(numberThree.current, numberThree.initPosBoxTwo);

            if (DistanceLeft < 45 || DistanceRight < 45)
            {
                if (DisObject < 45)
                {
                    numberThree.answerCorrect = false;
                    objectThree.transform.position = numberThree.initPos;
                }
                else
                {
                    if (DistanceLeft < 45) { numberThree.current = numberThree.initPosBoxOne; }
                    if (DistanceRight < 45) { numberThree.current = numberThree.initPosBoxTwo; }

                    numberThree.answerCorrect = true;
                    answerLineTwo = checkLineAnswers(numberThree.answerCorrect, numberFour.answerCorrect);
                    checkAnwers(answerLineOne, answerLineTwo, answerLineThree);
                }
            }
            else
            {
                numberThree.answerCorrect = false;
                objectThree.transform.position = numberThree.initPos;
            }
        }

        public void DropNumberFour()
        {
            numberFour.currentLocation(objectFour);
            float DisObject = Vector3.Distance(numberFour.current, numberThree.current);
            float DistanceLeft = Vector3.Distance(numberFour.current, numberFour.initPosBoxOne);
            float DistanceRight = Vector3.Distance(numberFour.current, numberFour.initPosBoxTwo);

            if (DistanceLeft < 45 || DistanceRight < 45)
            {
                if (DisObject < 45)
                {
                    numberFour.answerCorrect = false;
                    objectFour.transform.position = numberFour.initPos;
                }
                else
                {
                    if (DistanceLeft < 45) { numberFour.current = numberFour.initPosBoxOne; }
                    if (DistanceRight < 45) { numberFour.current = numberFour.initPosBoxTwo; }

                    numberFour.answerCorrect = true;
                    answerLineTwo = checkLineAnswers(numberFour.answerCorrect, numberThree.answerCorrect);
                    checkAnwers(answerLineOne, answerLineTwo, answerLineThree);

                }
            }
            else
            {
                numberFour.answerCorrect = false;
                objectFour.transform.position = numberFour.initPos;
            }
        }

        public void DropNumberFive()
        {
            numberFive.currentLocation(objectFive);
            float DisObject = Vector3.Distance(numberFive.current, numberSix.current);
            float DistanceLeft = Vector3.Distance(numberFive.current, numberFive.initPosBoxOne);
            float DistanceRight = Vector3.Distance(numberFive.current, numberFive.initPosBoxTwo);

            if (DistanceLeft < 45 || DistanceRight < 45)
            {
                if (DisObject < 45)
                {
                    numberFive.answerCorrect = false;
                    objectFive.transform.position = numberFive.initPos;
                }
                else
                {
                    if (DistanceLeft < 45) { numberFive.current = numberFive.initPosBoxOne; }
                    if (DistanceRight < 45) { numberFive.current = numberFive.initPosBoxTwo; }

                    numberFive.answerCorrect = true;
                    answerLineThree = checkLineAnswers(numberFive.answerCorrect, numberSix.answerCorrect);
                    checkAnwers(answerLineOne, answerLineTwo, answerLineThree);

                }
            }
            else
            {
                numberFive.answerCorrect = false;
                objectFive.transform.position = numberFive.initPos;
            }
        }

        public void DropNumberSix()
        {
            numberSix.currentLocation(objectSix);
            float DisObject = Vector3.Distance(numberSix.current, numberFive.current);
            float DistanceLeft = Vector3.Distance(numberSix.current, numberSix.initPosBoxOne);
            float DistanceRight = Vector3.Distance(numberSix.current, numberSix.initPosBoxTwo);

            if (DistanceLeft < 45 || DistanceRight < 45)
            {
                if (DisObject < 45)
                {
                    numberSix.answerCorrect = false;
                    objectSix.transform.position = numberSix.initPos;
                }
                else
                {
                    if (DistanceLeft < 45) { numberSix.current = numberSix.initPosBoxOne; }
                    if (DistanceRight < 45) { numberSix.current = numberSix.initPosBoxTwo; }

                    numberSix.answerCorrect = true;
                    answerLineThree = checkLineAnswers(numberFive.answerCorrect, numberSix.answerCorrect);
                    checkAnwers(answerLineOne, answerLineTwo, answerLineThree);
                }
            }
            else
            {
                numberSix.answerCorrect = false;
                objectSix.transform.position = numberSix.initPos;
            }
        }


        public bool checkLineAnswers(bool answerOne, bool answerTwo)
        {
            bool lineAnswer = false;
            if (answerOne == answerTwo)
            {
                lineAnswer = true;
            }
            return lineAnswer;
        }


        public void checkAnwers(bool lineOne, bool lineTwo, bool lineThree)
        {
            if(lineOne == true && lineTwo == true && lineThree == true)
            {
                answerExercerise = true;
                modal.SetActive(true);
            }
        }

        public void setNumbers(
            GameObject answerObject, Number answer,
            GameObject objectLeft, Number numberLeft,
            GameObject objectRight, Number numberRight)
        {
            int answerInt = 0;
            answerInt = Random.Range(0, 10);

            numberLeft.number = Random.Range(0, answerInt);
            numberRight.number = answerInt - numberLeft.number;

            numberLeft.setImage(objectLeft, numberLeft.number);
            numberRight.setImage(objectRight, numberRight.number);
            answer.setImage(answerObject, answerInt);

        }

        public void restartGame()
        {

        }
    }
}
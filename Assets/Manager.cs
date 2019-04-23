//using System;
//using System.Collections;
//using System.Collections.Generic;
////using NUnit.Framework;
//using UnityEngine;
//using UnityEngine.UI;

//public class Manager : MonoBehaviour
//{
//    //Visible numbers on the screen
//    public GameObject one, two, three, four, five, six, seven;

//    //Not visible objects on the screen
//    public GameObject boxOne, boxTwo, boxThree, boxFour, boxFive, boxSix, boxSeven;

//    private List<Number> numberList;
//    public int strucLength;
//    public int FREQUENTIE = 1;

//    public List<Number> NumberList { get => numberList; set => numberList = value; }

//    //initialize first position number
//    Vector2 oneInitialPos;
//    Vector2 twoInitialPos;
//    Vector2 threeInitialPos;
//    Vector2 fourInitialPos;
//    Vector2 fiveInitialPos;
//    Vector2 sixInitialPos;
//    Vector2 sevenInitialPos;

//    public void Start()
//    {
//        // Create Objectives Numbers
//        Number posOne = new Number(one);
//        Number posTwo = new Number(two);
//        Number posThree = new Number(three);
//        Number posFour = new Number(four);
//        Number posFive = new Number(five);
//        Number posSix = new Number(six);
//        Number posSeven = new Number(seven);

//        // Initaliseren answerBoxes
//        posOne.boxNumber = boxOne;
//        posTwo.boxNumber = boxTwo;
//        posThree.boxNumber = boxThree;
//        posFour.boxNumber = boxFour;
//        posFive.boxNumber = boxFive;
//        posSix.boxNumber = boxSix;
//        posSeven.boxNumber = boxSeven;

//        // Create list
//        numberList.Add(posOne);
//        numberList.Add(posTwo);
//        numberList.Add(posThree);
//        numberList.Add(posFour);
//        numberList.Add(posFive);
//        numberList.Add(posSix);
//        numberList.Add(posSeven);

//        setNumbers(numberList);


//        oneInitialPos = one.transform.position;
//        twoInitialPos = two.transform.position;
//        threeInitialPos = three.transform.position;
//        fourInitialPos = four.transform.position;
//        fiveInitialPos = five.transform.position;
//        sixInitialPos = six.transform.position;
//        sevenInitialPos = seven.transform.position;


//        //foreach (GameObject objectNum in numArray)
//        //{
//        //    Number number = new Number(objectNum);
//        //    //initialPos = setInitialPos(objectNum);
//        //    //changeImage(objectNum, number);	
//        //};

//        //foreach (int number in numArray)
//        //{
//        //    Debug.Log(number);
//        //}
//    }


//    static void setNumbers(List<Number> numberList)
//    {
//        int structLength = 0;
//        structLength = UnityEngine.Random.Range(0, 10);


//        for (int i = 0; i < numberList.Count; i++)
//        {
//            numberList[i].number = structLength;
//            structLength += 2;
//            Debug.Log(numberList[i].number);

//        }

//    }



//    //public static Array<GameObject> setNumberObjects(numObject)
//    //{
//    //    Number[] numArray = new Number[7];

//    //    for (int i = 0; i < numArray.Length; i++)
//    //    {
//    //        Number number = new Number(numObject);
//    //        numArray[i] = number; 
//    //    }

//    //    return numArray;
//    //}


//    //public static Array<GameObject> setNumbers(Array numArray)
//    //{ 
//    //    var numberList = new List<int>();
//    //    int startgetal = 0;
//    //    startgetal = UnityEngine.Random.Range(0, 10);


//    //    foreach (int number in numArray)
//    //    {
//    //        Debug.Log(number);          
//    //        startgetal += 1;
//    //        }
//    //        return numArray;

//    //    //int randomnr = 0;
//    //    //int = previousNum;

//    //    //while (i <= 7)
//    //    //{
//    //    //    randomnr = UnityEngine.Random.Range(0, 10);
//    //    //    numberList.Add(randomnr);
//    //    //    i += 1;
//    //    //}

//    //    //foreach (int i in numArray)
//    //    //{
//    //    //    i
//    //    //}
//    //        //return numberList; 
//    //}


//    //public void DropNumber(GameObject number, GameObject transnumber) {
//    //    float Distance = Vector3.Distance(number.transform.position, transnumber.transform.position);
//    //    if (Distance < 15)
//    //    {
//    //        number.transform.position = transnumber.transform.position;
//    //    }
//    //    else
//    //    {
//    //        number.transform.position = numthreeInitialPos;
//    //    }
//    //}


//    public void DragNumber(GameObject number)
//    {
//        number.transform.position = Input.mousePosition;
//    }


//    //Drop methodes
//    public void DropNumberOne()
//    {
//        float Distance = Vector3.Distance(one.transform.position, boxOne.transform.position);
//        if (Distance < 15)
//        {
//            one.transform.position = boxOne.transform.position;
//            //correctOne = true;
//        }
//        else
//        {
//            one.transform.position = oneInitialPos;
//        }

//    }

//    public void DropNumberTwo()
//    {
//        float Distance = Vector3.Distance(two.transform.position, boxTwo.transform.position);
//        if (Distance < 15)
//        {
//            two.transform.position = boxTwo.transform.position;
//        }
//        else
//        {
//            two.transform.position = twoInitialPos;
//        }

//    }


//    public void DropNumberThree()
//    {
//        float Distance = Vector3.Distance(three.transform.position, boxThree.transform.position);
//        if (Distance < 15)
//        {
//            three.transform.position = boxThree.transform.position;
//        }
//        else
//        {
//            three.transform.position = threeInitialPos;
//        }

//    }

//    public void DropNumberFour()
//    {
//        float Distance = Vector3.Distance(four.transform.position, boxFour.transform.position);
//        if (Distance < 15)
//        {
//            four.transform.position = boxFour.transform.position;
//        }
//        else
//        {
//            four.transform.position = fourInitialPos;
//        }

//    }

//    public void DropNumberFive()
//    {
//        float Distance = Vector3.Distance(five.transform.position, boxFive.transform.position);
//        if (Distance < 15)
//        {
//            five.transform.position = boxFive.transform.position;
//        }
//        else
//        {
//            five.transform.position = fiveInitialPos;
//        }

//    }

//    public void DropNumberSix()
//    {
//        float Distance = Vector3.Distance(six.transform.position, boxSix.transform.position);
//        if (Distance < 15)
//        {
//            six.transform.position = boxSix.transform.position;
//        }
//        else
//        {
//            six.transform.position = sixInitialPos;
//        }

//    }

//    public void DropNumberSeven()
//    {
//        float Distance = Vector3.Distance(seven.transform.position, boxSeven.transform.position);
//        if (Distance < 15)
//        {
//            seven.transform.position = boxSeven.transform.position;
//        }
//        else
//        {
//            seven.transform.position = sevenInitialPos;
//        }

//    }
//}

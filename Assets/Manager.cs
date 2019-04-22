using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Numbers;

public class Manager : MonoBehaviour
{
    public GameObject one, two, three, four, five, six, seven, oneTrans, twoTrans, threeTrans, fourTrans, fiveTrans, sixTrans, sevenTrans;

    public Sprite[] images;
		
    public int[] numberList;
    public GameObject[] numObjects;
    public Vector2 initialPos;
		
    //initialize first position number
    Vector2 oneInitialPos;
    Vector2 twoInitialPos;
    Vector2 threeInitialPos;
    Vector2 fourInitialPos;
    Vector2 fiveInitialPos;
    Vector2 sixInitialPos;
    Vector2 sevenInitialPos;

    private void Start()
    {
        numObjects = new GameObject[7];
        numObjects[0] = one;
        numObjects[1] = two;
        numObjects[2] = three;
        numObjects[3] = four;
        numObjects[4] = five;
        numObjects[5] = six;
        numObjects[6] = seven;
				
//				var dictionary = new Dictionary<String, Tuple<>();


				
				numberList = newNumbers();
				
				foreach (int number in numberList){
				
					foreach (GameObject objectNum in numObjects)
					{
							initialPos = setInitialPos(objectNum);
							changeImage(objectNum, number);
							
//							dictionary.Add("initialPos", initialPos);
//							dictionary.Add("number", number);		
        	};
				};


        oneInitialPos = one.transform.position;
        twoInitialPos = two.transform.position;
        threeInitialPos = three.transform.position;
        fourInitialPos = four.transform.position;
        fiveInitialPos = five.transform.position;
        sixInitialPos = six.transform.position;
        sevenInitialPos = seven.transform.position;
    }

    static Vector2 setInitialPos(GameObject number)
    {
        Vector2 InitialPos;
        InitialPos = number.transform.position;
        return InitialPos;
    }


	public void changeImage(GameObject numObjects, int number)
    {
        Sprite twoNum = Resources.Load<Sprite>("Sprites/Numbers/" + number.ToString());
        Debug.Log(twoNum);
        numObjects.GetComponent<Image>().sprite = twoNum;
    }

    public int[] newNumbers()
    {
        int[] numberList = new int[7];

				foreach (int i in numberList){ numberList[i] = UnityEngine.Random.Range(0, 10);}
        Array.Sort(numberList);
				return numberList;
    }

    public void DragNumber(GameObject number)
    {
        number.transform.position = Input.mousePosition;
    }


    //Drop methodes
    public void DropNumberOne()
    {
        float Distance = Vector3.Distance(one.transform.position, oneTrans.transform.position);
        if (Distance < 15)
        {
            one.transform.position = oneTrans.transform.position;
        }
        else
        {
            one.transform.position = oneInitialPos;
        }

    }

    public void DropNumberTwo()
    {
        float Distance = Vector3.Distance(two.transform.position, twoTrans.transform.position);
        if (Distance < 15)
        {
            two.transform.position = twoTrans.transform.position;
        }
        else
        {
            two.transform.position = twoInitialPos;
        }

    }


    public void DropNumberThree()
    {
        float Distance = Vector3.Distance(three.transform.position, threeTrans.transform.position);
        if (Distance < 15)
        {
            three.transform.position = threeTrans.transform.position;
        }
        else
        {
            three.transform.position = threeInitialPos;
        }

    }

    public void DropNumberFour()
    {
        float Distance = Vector3.Distance(four.transform.position, fourTrans.transform.position);
        if (Distance < 15)
        {
            four.transform.position = fourTrans.transform.position;
        }
        else
        {
            four.transform.position = fourInitialPos;
        }

    }

    public void DropNumberFive()
    {
        float Distance = Vector3.Distance(five.transform.position, fiveTrans.transform.position);
        if (Distance < 15)
        {
            five.transform.position = fiveTrans.transform.position;
        }
        else
        {
            five.transform.position = fiveInitialPos;
        }

    }

    public void DropNumberSix()
    {
        float Distance = Vector3.Distance(six.transform.position, sixTrans.transform.position);
        if (Distance < 15)
        {
            six.transform.position = sixTrans.transform.position;
        }
        else
        {
            six.transform.position = sixInitialPos;
        }

    }

    public void DropNumberSeven()
    {
        float Distance = Vector3.Distance(seven.transform.position, sevenTrans.transform.position);
        if (Distance < 15)
        {
            seven.transform.position = sevenTrans.transform.position;
        }
        else
        {
            seven.transform.position = sevenInitialPos;
        }

    }

    //public void DropNumber(GameObject number, GameObject transnumber) {
    //    float Distance = Vector3.Distance(number.transform.position, transnumber.transform.position);
    //    if (Distance < 15)
    //    {
    //        number.transform.position = transnumber.transform.position;
    //    }
    //    else
    //    {
    //        number.transform.position = numthreeInitialPos;
    //    }
    //}

}

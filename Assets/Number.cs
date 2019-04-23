using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour

{
    public Vector3 initPosNumber;
    public Vector3 initPosBox;
    public Vector3 current;
    public bool answerCorrect;
    public int number;


    public void setData(GameObject number, GameObject answerBox)
    {
        Debug.Log("hallo");
        this.initPosNumber = number.transform.position;
        this.initPosBox = answerBox.transform.position;
        Debug.Log("doei");

    }


    }



 //   //public int changeNumber()
 //   //{
 //   //    this.number = UnityEngine.Random.Range(0, 10);
 //   //}

	////public int[] newNumberList()
	////{
  ////      int[] numberList = new int[7];

		////foreach (int i in numberList)
  ////      { numberList[i] = UnityEngine.Random.Range(0, 10);}
  ////      Array.Sort(numberList);
		////return numberList;
    ////}

    ////static Vector2 setInitialPos(GameObject number)
    ////{
    ////    Vector2 InitialPos;
    ////    InitialPos = number.transform.position;
    ////    return InitialPos;
    ////}

    ////public void DragNumber(GameObject numObject)
    ////{
    ////    numObject.transform.position = Input.mousePosition;
    ////}



    ////public void DropNumber()
    ////{
    ////    float Distance = Vector3.Distance(this.initialPosition, this.answerBox.transform.position);
    ////    if (Distance < 15)
    ////    {
    ////        this.initialPosition = this.answerBox.transform.position;
    ////        this.answerCorrect = true;
    ////    }
    ////    else { numObject.transform.position = this.initialPosition; }
    ////}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public Vector2 initialPosition;
    public GameObject[] numObject;
	public Sprite[] image;


	public void changeImage(GameObject numObjects, int number)
    {
        Sprite twoNum = Resources.Load<Sprite>("Sprites/Numbers/" + number.ToString());
        Debug.Log(twoNum);
        numObjects.GetComponent<Image>().sprite = twoNum;
    }

	public int[] newNumberList()
	{
        int[] numberList = new int[7];

		foreach (int i in numberList){ numberList[i] = UnityEngine.Random.Range(0, 10);}
        Array.Sort(numberList);
		return numberList;
    }
}

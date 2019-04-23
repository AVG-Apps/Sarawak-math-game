using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberLineLvl : MonoBehaviour
{
    public GameObject one, two, three, four, five, six, seven;

    public GameObject answerOne, answerTwo, answerThree, answerFour, answerFive, answerSix, answerSeven;

    // Start is called before the first frame update
    void Start()
    {

        changeImage(one, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void changeImage(GameObject numObject, int number)
    {
        Sprite twoNum = Resources.Load<Sprite>("Sprites/Numbers/" + number.ToString());
        numObject.GetComponent<Image>().sprite = twoNum;
    }
}

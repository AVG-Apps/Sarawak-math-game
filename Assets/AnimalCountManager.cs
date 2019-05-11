using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimalCountManager : MonoBehaviour
{
    public GameObject[] animalObjects;
    public GameObject[] answerBtn;
    public GameObject headerLabel;
    public int answer;

    void Awake()
    {
        animalObjects = GameObject.FindGameObjectsWithTag("Animals");
        answerBtn = GameObject.FindGameObjectsWithTag("AnswerBtn");
        headerLabel = GameObject.FindWithTag("HeaderLabel");

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Time.time);
        setData();
        restartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[]randomizeArray(GameObject[] arrayList)
    {
        for (int positionOfArray = 0; positionOfArray < arrayList.Length; positionOfArray++)
        {
            GameObject obj = arrayList[positionOfArray];
            int randomizeArray = Random.Range(0, positionOfArray);
            arrayList[positionOfArray] = arrayList[randomizeArray];
            arrayList[randomizeArray] = obj;
        }
        return arrayList;

    }

    public void updateLabelsBtn(GameObject[] buttons, int correctanswer)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i == 0)
            {
                buttons[i].GetComponentInChildren<Text>().text = correctanswer.ToString();
            }
            else
            {
                int incorrectAnswer = UnityEngine.Random.Range(0, 20);
                if (incorrectAnswer != correctanswer)
                {
                    buttons[i].GetComponentInChildren<Text>().text = incorrectAnswer.ToString();
                }
            }
        }
    }

    public int setAnswer(GameObject[] arrayList)
    {
        int amountToDisable = UnityEngine.Random.Range(0, 19);
        int answer = animalObjects.Length - amountToDisable;
        int i = 0;

        while (i < amountToDisable)
        {
            arrayList[i].SetActive(false);
            i++;
        }
        return answer;
    }


    public void checkAnswer(GameObject button)
    {
        string clickedBtn = button.GetComponentInChildren<Text>().text;
        Debug.Log(clickedBtn);

        if(clickedBtn == answer.ToString())
        {
            headerLabel.GetComponentInChildren<Text>().text = "Good Answer! Try Another";
            
            setData();
            restartGame();
        }
        else
        {
            headerLabel.GetComponentInChildren<Text>().text = "jawapan yang salah, cuba lagi!";
        }
    }

    public void setData()
    {
        foreach (GameObject animalObject in animalObjects)
        {
            animalObject.SetActive(true);
        }
    }

    public void restartGame()
    {
        //StartCoroutine(waitingFor(3));
        headerLabel.GetComponentInChildren<Text>().text = "Mengira Haiwan";
        GameObject[] animals = randomizeArray(animalObjects);
        randomizeArray(answerBtn);

        answer = setAnswer(animals);
        updateLabelsBtn(answerBtn, answer);
    }

    //IEnumerator waitingFor(int seconds)
    //{
    //    yield return new WaitForSeconds(seconds);
    //}
}

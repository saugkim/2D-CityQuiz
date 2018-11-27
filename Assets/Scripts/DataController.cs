using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class DataController : MonoBehaviour
{
    public QuestionsAnswers[] questions;

    public Text title;
    public Text answerFirstText;
    public Text answerSecondText;
    public Text answerThirdText;

    public Text scoreText;
    public Text resultText;
    private int score;

    List<int> previousQuestions = new List<int>() { -1, -1, -1, -1 }; //placehold number just forget it
    public int questoinNumber = 0;

    public int totalQuestions;

    public static string selectedAnswer;

    public static int randQuestion = -1;

    public static string choiceSelected = null;


    private string gameDataFileName = "world.json";

    void Start()
    {
        LoadData();
    }

    private void LoadData()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            GameData myStoredData = JsonUtility.FromJson<GameData>(dataAsJson);

            questions = myStoredData.QandA;
        }

        else
        {
            Debug.LogError("Cnnot load game data!");
        }
    }

    void Update()
    {
        if (randQuestion == -1)
        {
            randQuestion = Random.Range(0, questions.Length - 1);

            for (int i = 0; i < previousQuestions.Count; i++)
            {
                if (randQuestion != previousQuestions[i])
                {

                }
                else
                {
                    randQuestion = -1;
                }
            }
        }


        if (randQuestion > -1)
        {
            title.text = questions[randQuestion].Question;
            previousQuestions[questoinNumber] = randQuestion;
            previousQuestions.Add(randQuestion);

            answerFirstText.text = questions[randQuestion].Answer1;
            answerSecondText.text = questions[randQuestion].Answer2;
            answerThirdText.text = questions[randQuestion].Answer3;

        }

        if (choiceSelected == "y")
        {
            choiceSelected = null;
            questoinNumber++;
            totalQuestions++;

            if (questions[randQuestion].CorrectAnswer == selectedAnswer)
            {
                resultText.text = "Correct, press next button";
                score++;
            }

            else
            {
                resultText.text = "Incorrect, try again or move to next question";
            }

            scoreText.text = "Score: " + score + "  Total Questions: " + totalQuestions;
            StartCoroutine(ResetResultText());
        }
    }

    IEnumerator ResetResultText()
    {
        yield return new WaitForSeconds(3);
        resultText.text = null;
    }

    public void Button1Clicked()
    {
        choiceSelected = "y";
        selectedAnswer = answerFirstText.text;
    }

    public void Button2Clicked()
    {
        choiceSelected = "y";
        selectedAnswer = answerSecondText.text;
    }

    public void Button3Clicked()
    {
        choiceSelected = "y";
        selectedAnswer = answerThirdText.text;
    }

    public void CallNextQuestion()
    {
        randQuestion = -1;
    }

}

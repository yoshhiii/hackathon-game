using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    // Scoring
    private int Score;

    // Questions
    private string[] QuestionText = new string[1];
    private int QuestionNumber;

    // Text Objects
    public Text ScoreText;
    public Button[] Button = new Button[4];
    public Text Question;

    //Answers
    private string[] AnswerText = new string[1];
    private string[] firstAnswer = new string[4];


    // Use this for initialization
    void Start()
    {
        Score = 0;
        QuestionNumber = 0;

        QuestionText[0] = "Here's Our First Question";

        firstAnswer[0] = "First Answer";
        firstAnswer[1] = "Second Answer";
        firstAnswer[2] = "Third Answer";
        firstAnswer[3] = "Fourth Answer";
    }

    public void SetupQuestions()
    {
        Question.text = QuestionText[QuestionNumber];
        QuestionNumber++;

        for (int i = 0; i < Button.Length; i++)
        {
            Button[i].gameObject.SetActive(true);
        }

        SetCorrectAnswer();
    }

    private void SetCorrectAnswer()
    {
        int x = Random.Range(1, 4);
        switch (x)
        {
            case 1:
                Swap(firstAnswer, 2, 3);
                break;
            case 2:
                Swap(firstAnswer, 0, 1);
                Swap(firstAnswer, 2, 3);
                break;
            case 3:
                Swap(firstAnswer, 0, 2);
                Swap(firstAnswer, 1, 3);
                break;
            case 4:
                Swap(firstAnswer, 0, 3);
                Swap(firstAnswer, 1, 2);
                break;
            default:
                break;
        }
        for (int i = 0; i < firstAnswer.Length; i++) {
            Debug.Log(firstAnswer[i]);
         }
    }

    private void Swap(string[] array, int s, int m)
    {
        int x = m;
        array[m] = array[s];
        array[s] = array[x];
    }

    public void CorrectAnswerClicked()
    {
        Score++;
    }

    public void WrongAnswerClicked()
    {
        Score--;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Correct Answers: " + Score.ToString();
    }
}

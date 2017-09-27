using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionObject : MonoBehaviour {

    private string[] answerText = new string[4];

	// Use this for initialization
	void Start () {
        answerText[0] = "First Answer";
        answerText[1] = "Second Answer";
        answerText[2] = "Third Answer";
        answerText[3] = "Fourth Answer";

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

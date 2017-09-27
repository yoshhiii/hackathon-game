using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Text questionText;
    public Button playButton;

    // Use this for initialization
    void Awake()
    {

    }

    public void PlayGame()
    {
        questionText.text = "First Question?";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

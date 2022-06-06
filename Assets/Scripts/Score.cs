using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float newScore = 0;
    public TextMeshProUGUI textbox;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        newScore = newScore+Time.deltaTime;
        textbox.text = "Score: "+Math.Round(newScore).ToString();
        StaticData.score = newScore;
    }
}

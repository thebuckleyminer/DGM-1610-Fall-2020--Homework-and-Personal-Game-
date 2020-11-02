using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public float startTime;
    public float elapsedTime;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
    startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;
        scoreText.text = elapsedTime.ToString();
    }
}

using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {
    
    public Text scoreT;
    public Text tryT;
    private int scoreCount = 0;
    public int tryCount = 5;

    void Start() 
    {
        scoreT.text = "Points: " + scoreCount.ToString();
        tryT.text = "Throws Left: " + tryCount.ToString();
    }

    public void AddScore(int points)
    {
        StartCoroutine(UpdateScore());
        scoreCount += points;
    }
      
    public void DecrementTries()
    {
        tryCount--;
        print("try count: " + tryCount);
        tryT.text = "Throws Left: " + tryCount.ToString();

    }

    IEnumerator UpdateScore() {
        yield return new WaitForSeconds(3);
        print("current score: " + scoreCount);
        scoreT.text = "Points: " + scoreCount.ToString();
        tryT.text = "Throws Left: " + tryCount.ToString();
    }
}
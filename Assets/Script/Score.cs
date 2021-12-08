using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int myScore = 0;

    public void addScore()
    {
        Debug.Log("fgdhd");
        myScore++;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
        
    }

    public void resetScore()
    {
        myScore = 0;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();

    }

}

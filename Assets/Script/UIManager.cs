using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject gameOverPanel;

    private void Start()
    {
        startPanel.gameObject.SetActive(true);
        gameOverPanel.gameObject.SetActive(false);
    }

    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
    }
}

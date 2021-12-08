using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartTheGame()
    {
        UIManager _UIManager = FindObjectOfType<UIManager>();
        _UIManager.startPanel.SetActive(false);
        Player _gondola = FindObjectOfType<Player>();
        _gondola._rigid.bodyType = RigidbodyType2D.Dynamic;
        Pipes[] _pipes = FindObjectsOfType<Pipes>();
        foreach (Pipes _pipe in _pipes)
        {
            _pipe.enabled = true;
        }
    }

    // Update is called once per frame
    public void RestartTheGame()
    {
        Player _gondola = FindObjectOfType<Player>();
        Pipes[] _pipes = FindObjectsOfType<Pipes>();
        Checkpoint[] _checkpoints = FindObjectsOfType<Checkpoint>();
        UIManager _UIManager = FindObjectOfType<UIManager>();
        _UIManager.gameOverPanel.SetActive(false);
        Score _score = FindObjectOfType<Score>();
        _score.resetScore();

        _gondola.caRepart();

        foreach (Pipes _pipe in _pipes)
        {
            _pipe.caRepart();
        }
        
        foreach (Checkpoint _checkpoint in _checkpoints)
        {
            _checkpoint.caRepart();
        }
    }
}

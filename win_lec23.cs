using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int _score = 0;
    public Text scoretext;
    // Start is called before the first frame update
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    
    
    public void AddScore(int points)
    {
        _score += points;
        Debug.Log(_score);
        scoretext.text = "Score :" + _score.ToString();

    }
}

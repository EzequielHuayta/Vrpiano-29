using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int currentScore;

public int scorePerNote = 100;

public int miss = 0;
public int actualmiss = 1;

public int currentMultiplier;
public int multiplierTracker;

public int[] multiplierThresholds;
public static GameManager instance;
public TextMeshProUGUI scoreText;
public TextMeshProUGUI missText;
public TextMeshProUGUI multiplier;
    // Start is called before the first frame update

    void Start()
    {
        instance=this;
        currentMultiplier = 1;
    }
    public void NoteHit()
    {
        if(currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;
                if(multiplierThresholds[currentMultiplier -  1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier ++;
            }
        }

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score " + currentScore;
    }


    // Update is called once per frame
    public void NoteMissed()
    {
        miss += actualmiss;
        missText.text = "Miss " + miss;
    }
}

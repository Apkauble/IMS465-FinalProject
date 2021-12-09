using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField]
    public Text text;

    private int score;
    private float timeRemaining = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            //Debug.Log(timeRemaining);
        }

        else
        {
            timeRemaining = 1;
            if (GameObject.Find("Player(Clone)") != null)
            {
                score += 10;
                text.text = "Score: " + score;
            }
            Debug.Log("RESET!");
        }
    }
}

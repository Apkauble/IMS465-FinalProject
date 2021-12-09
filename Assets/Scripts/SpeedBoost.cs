using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{

    [SerializeField]
    public PlayerScript player;

    private bool isBoosting = false;
    private float timeRemaining = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (isBoosting)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    //Debug.Log(timeRemaining);
                }

                else
                {
                    isBoosting = false;
                    timeRemaining = 10;
                    player.speed = 7;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
           // Debug.Log("PLAYER!");
            player.speed = 13;
            isBoosting = true;
        }
    }
}

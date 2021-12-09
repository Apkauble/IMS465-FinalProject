using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPathFinder : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;
    [SerializeField]
    private GameObject player;


    private bool isBoosting = false;
    private bool isPlaying = false;
    private float timeRemaining = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
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
            isBoosting = false;
            timeRemaining = 1;
            if (player != null)
            {
                agent.SetDestination(player.transform.position);
            }
            else agent.SetDestination(new Vector3(0, 0, 0));
            //Debug.Log("SETTING!");
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            //Debug.Log("COLLIDE!");
            Destroy(player);
            
        }
    }

}

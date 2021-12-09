using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    float randX = 0;
    float randZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randX = Random.Range(-15f, 15f);
        randZ = Random.Range(-15f, 15f);
    }

    private void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("HIT");
        collision.rigidbody.AddForce(randX, 0, randZ, ForceMode.Impulse);
    }
}

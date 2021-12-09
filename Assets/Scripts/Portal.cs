using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    private bool canSpawn = true;
    [SerializeField]
    GameObject otherPortal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        canSpawn = true;
        if(canSpawn)
        {
            other.transform.position = otherPortal.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canSpawn = false;
    }
}

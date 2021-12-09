using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    [SerializeField]
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(0, 300, 0, ForceMode.Force);
                }
                else
                {
                    Destroy(hit.collider.gameObject);
                }
                Debug.Log("You selected the " + hit.transform.name);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounds : MonoBehaviour
{

    [SerializeField]
    public GameObject gameOver;

    [SerializeField]
    public GameObject white;

    [SerializeField]
    public GameObject gmScore;


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
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("WALLLL " + this.gameObject.name);
            Destroy(other.gameObject);
            white.SetActive(true);
            gameOver.SetActive(true);
            gmScore.SetActive(true);
        }
    }
}

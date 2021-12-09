using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    [SerializeField]
    public int speed = 4;
    [SerializeField]
    private Rigidbody rigid;

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

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.L))
        {
            rigid.MovePosition(transform.position + (new Vector3(1, 0, 0) * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.I))
        {
            rigid.MovePosition(transform.position + (new Vector3(0, 0, 1) * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.J))
        {
            rigid.MovePosition(transform.position + (new Vector3(-1, 0, 0) * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.K))
        {
            rigid.MovePosition(transform.position + (new Vector3(0, 0, -1) * speed * Time.deltaTime));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           // Debug.Log("COLLIDE!");
            Destroy(GameObject.Find("Player"));
            white.SetActive(true);
            gameOver.SetActive(true);
            gmScore.SetActive(true);
        }
    }
}

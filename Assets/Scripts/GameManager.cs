using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    public GameObject ui;

    [SerializeField]
    public Button p1button;

    [SerializeField]
    public Button p2button;

    [SerializeField]
    public GameObject player1;

    [SerializeField]
    public GameObject player2;

    [SerializeField]
    public GameObject playerAI;

    [SerializeField]
    public Text text;

    [SerializeField]
    public Text gmText;

    [SerializeField]
    public GameObject gameOver;

    [SerializeField]
    public GameObject white;

    [SerializeField]
    public GameObject gmScore;


    //[SerializeField]
    //public TextAsset File;

    private int score;
    private float timeRemaining = 1;
    private bool isPlaying = false;
    AudioSource audioData;
    


    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(true);
        p1button.onClick.AddListener(P1Choice);
        p2button.onClick.AddListener(P2Choice);
        audioData = GetComponent<AudioSource>();
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
            if (GameObject.Find("Player") != null && isPlaying)
            {
                score += 10;
                text.text = "Score: " + score;
                gmText.text = "Score: " + score;
                //StreamWriter writer = new StreamWriter("Assets/Text/Score.txt", false);
                //writer.Write(score);
                //File.text = score;
            }
            //Debug.Log("RESET!");
        }

        if(GameObject.Find("Player") == null)
        {
            white.SetActive(true);
            gameOver.SetActive(true);
            gmScore.SetActive(true);
            audioData.Stop();
        }
    }

    public void P1Choice()
    {
        Destroy(p1button.gameObject);
        Destroy(p2button.gameObject);
        //ui.SetActive(false);
        player1.transform.position = new Vector3(-4, 4, 4);
        Instantiate(playerAI, new Vector3(4, 0, -4), Quaternion.identity);
        //playerAI.transform.position = new Vector3(4, 0, -4);
        isPlaying = true;
        audioData.Play();
    }

    public void P2Choice()
    {
        Destroy(p1button.gameObject);
        Destroy(p2button.gameObject);
        //ui.SetActive(false);
        //Instantiate(player1, new Vector3(-4, 4, 4), Quaternion.identity);
        player1.transform.position = new Vector3(-4, 4, 4);
        //Instantiate(player2, new Vector3(4, 0, -4), Quaternion.identity);
        player2.transform.position = new Vector3(4, 0, -4);
        isPlaying = true;
        audioData.Play();
    }


}

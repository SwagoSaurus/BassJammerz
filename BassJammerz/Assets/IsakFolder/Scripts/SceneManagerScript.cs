using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public KeyCode RestartKey;
    public KeyCode MainScreenKey;
    public float SlowMo;
    public GameObject Player1Needle;
    public GameObject Player2Needle;
    public GameObject Player3Needle;
    public GameObject Player4Needle;
    public GameObject HowManyPlayers;
    HowManyPlayersScript howmanyplayersScript;
    public bool Player1Dead;
    public bool Player2Dead;
    public bool Player3Dead;
    public bool Player4Dead;
    // Start is called before the first frame update
    void Start()
    {
        howmanyplayersScript = HowManyPlayers.GetComponent<HowManyPlayersScript>();
        Time.timeScale = 1.0f;
        SlowMo = 1.0f;

        if(howmanyplayersScript.Player1Playing == false)
        {
            Player1Dead = true;
        }
        if (howmanyplayersScript.Player2Playing == false)
        {
            Player2Dead = true;
        }
        if (howmanyplayersScript.Player3Playing == false)
        {
            Player3Dead = true;
        }
        if (howmanyplayersScript.Player4Playing == false)
        {
            Player4Dead = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Player1Needle.GetComponent<MeterScript>().Lost == true)
        {
            Player1Dead = true;
        }
        if (Player2Needle.GetComponent<MeterScript>().Lost == true)
        {
            Player2Dead = true;
        }
        if (Player3Needle.GetComponent<MeterScript>().Lost == true)
        {
            Player3Dead = true;
        }
        if (Player4Needle.GetComponent<MeterScript>().Lost == true)
        {
            Player4Dead = true;
        }


        if (Player1Dead && Player2Dead && Player3Dead && Player4Dead)
        {
            if(SlowMo > 0.4)
            SlowMo -= 0.005f;

            if (SlowMo <= 0.4)
                SlowMo = 0;
            
            Time.timeScale = SlowMo;
           
        }
    }

    private void Update()
    {
        if (Player1Dead && Player2Dead && Player3Dead && Player4Dead)
        {
            if (Input.GetKeyDown(RestartKey))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            }

            if(Input.GetKeyDown(MainScreenKey))
            {
                SceneManager.LoadScene("ChooseSongScene");
            }
        }


        if (Player1Needle.GetComponent<MeterScript>().Won || Player2Needle.GetComponent<MeterScript>().Won || Player3Needle.GetComponent<MeterScript>().Won || Player4Needle.GetComponent<MeterScript>().Won)
        {
            if (Input.GetKeyDown(MainScreenKey))
            {
                SceneManager.LoadScene("ChooseSongScene");
            }
        }
    }
}

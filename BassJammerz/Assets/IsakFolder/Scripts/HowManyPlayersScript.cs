using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowManyPlayersScript : MonoBehaviour
{
    public Camera Player1;
    public Camera Player2;
    public Camera Player3;
    public Camera Player4;
    public bool Player1Playing = false;
    public bool Player2Playing = false;
    public bool Player3Playing = false;
    public bool Player4Playing = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Player1Playing == true && Player2Playing == false && Player3Playing == false && Player4Playing == false)
        {
            Player1.rect = new Rect(0, 0, 1, 1);
            Player2.rect = new Rect(0, 0, 0, 0);
            Player3.rect = new Rect(0, 0, 0, 0);
            Player4.rect = new Rect(0, 0, 0, 0);
        }
        if (Player1Playing == false && Player2Playing == true && Player3Playing == false && Player4Playing == false)
        {
            Player1.rect = new Rect(0, 0, 0, 0);
            Player2.rect = new Rect(0, 0, 1, 1);
            Player3.rect = new Rect(0, 0, 0, 0);
            Player4.rect = new Rect(0, 0, 0, 0);
        }
        if (Player1Playing == false && Player2Playing == false && Player3Playing == true && Player4Playing == false)
        {
            Player1.rect = new Rect(0, 0, 0, 0);
            Player2.rect = new Rect(0, 0, 0, 0);
            Player3.rect = new Rect(0, 0, 1, 1);
            Player4.rect = new Rect(0, 0, 0, 0);
        }
        if (Player1Playing == false && Player2Playing == false && Player3Playing == false && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0, 0, 0);
            Player2.rect = new Rect(0, 0, 0, 0);
            Player3.rect = new Rect(0, 0, 0, 0);
            Player4.rect = new Rect(0, 0, 1, 1);
        }
        if (Player1Playing == true && Player2Playing == true && Player3Playing == false && Player4Playing == false)
        {
            Player1.rect = new Rect(0, 0.5f, 1, 0.5f);
            Player2.rect = new Rect(0, 0, 1, 0.5f);
            Player3.rect = new Rect(0, 0, 0, 0);
            Player4.rect = new Rect(0, 0, 0, 0);
        }
        if (Player1Playing == true && Player2Playing == false && Player3Playing == true && Player4Playing == false)
        {
            Player1.rect = new Rect(0, 0.5f, 1, 0.5f);
            Player2.rect = new Rect(0, 0, 0, 0);
            Player3.rect = new Rect(0, 0, 1, 0.5f);
            Player4.rect = new Rect(0, 0, 0, 0);
        }
        if (Player1Playing == true && Player2Playing == false && Player3Playing == false && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0.5f, 1, 0.5f);
            Player2.rect = new Rect(0, 0, 0, 0);
            Player3.rect = new Rect(0, 0, 0, 0);
            Player4.rect = new Rect(0, 0, 1, 0.5f);
        }
        if (Player1Playing == false && Player2Playing == true && Player3Playing == true && Player4Playing == false)
        {
            Player1.rect = new Rect(0, 0, 0, 0);
            Player2.rect = new Rect(0, 0.5f, 1, 0.5f);
            Player3.rect = new Rect(0, 0, 1, 0.5f);
            Player4.rect = new Rect(0, 0, 0, 0);
        }
        if (Player1Playing == false && Player2Playing == true && Player3Playing == false && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0, 0, 0);
            Player2.rect = new Rect(0, 0.5f, 1, 0.5f);
            Player3.rect = new Rect(0, 0, 0, 0);
            Player4.rect = new Rect(0, 0, 1, 0.5f);
        }
        if (Player1Playing == false && Player2Playing == false && Player3Playing == true && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0, 0, 0);
            Player2.rect = new Rect(0, 0, 0, 0);
            Player3.rect = new Rect(0, 0.5f, 0, 0.5f);
            Player4.rect = new Rect(0, 0, 1, 0.5f);
        }
        if (Player1Playing == true && Player2Playing == true && Player3Playing == true && Player4Playing == false)
        {
            Player1.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
            Player2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Player3.rect = new Rect(0, 0, 1, 0.5f);
            Player4.rect = new Rect(0, 0, 0, 0);
        }
        if (Player1Playing == true && Player2Playing == true && Player3Playing == false && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
            Player2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Player3.rect = new Rect(0, 0, 0, 0);
            Player4.rect = new Rect(0, 0, 1, 0.5f);
        }
        if (Player1Playing == true && Player2Playing == false && Player3Playing == true && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
            Player2.rect = new Rect(0, 0, 0, 0);
            Player3.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Player4.rect = new Rect(0, 0, 1, 0.5f);
        }
        if (Player1Playing == false && Player2Playing == true && Player3Playing == true && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0, 0, 0);
            Player2.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
            Player3.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Player4.rect = new Rect(0, 0, 1, 0.5f);
        }
        if (Player1Playing == true && Player2Playing == true && Player3Playing == true && Player4Playing == true)
        {
            Player1.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
            Player2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Player3.rect = new Rect(0, 0, 0.5f, 0.5f);
            Player4.rect = new Rect(0.5f, 0, 0.5f, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{

    public ParticleSystem ps;
    public GameObject comboscript;
    ScoreScript cs;

    // Start is called before the first frame update
    void Start()
    {

        cs = comboscript.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (cs.Combo >= 2)
        {
            var main = ps.main;
            ps.Play();
            if (cs.Combo == 2)
            {

                main.maxParticles = 10;
            }
            else if (cs.Combo == 3)
            {
                main.maxParticles = 100;
            }
            else if (cs.Combo == 4)
            {
                main.maxParticles = 500;
            }

        }
        else
        {
            ps.Stop();
        }

    }
}

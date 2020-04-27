using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestarterScript : MonoBehaviour
{
    static public bool Restart;
    public bool Restarter;
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneName == "Bloom")
        {
            Restart = true;
        }

        if(sceneName == "ChooseSongScene")
        {
            if(Restart == true)
            {
                Restart = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

    }
}

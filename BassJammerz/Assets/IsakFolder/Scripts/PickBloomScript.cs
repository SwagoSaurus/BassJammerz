using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickBloomScript : MonoBehaviour
{
   
   public void PlayBloom ()
    {
        SceneManager.LoadScene("Bloom");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScreenScript : MonoBehaviour
{
    public GameObject MeterScript;
    MeterScript meterScript;
    public RectTransform Red;
    // Start is called before the first frame update
    void Start()
    {
        meterScript = MeterScript.GetComponent<MeterScript>();
        Red.anchoredPosition = new Vector3(1000, 1500, 1000);
    }

    // Update is called once per frame
    void Update()
    {
        if(meterScript.Lost == true)
        {
            Red.anchoredPosition = new Vector3(0, 0, 0);
        }
    }
}

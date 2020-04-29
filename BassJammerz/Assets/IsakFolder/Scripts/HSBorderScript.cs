using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSBorderScript : MonoBehaviour
{
    public RectTransform objectRectTransform;

    public GameObject PickLetter;
    PickLetterScript pickLetter;
    // Start is called before the first frame update
    void Start()
    {
        pickLetter = PickLetter.GetComponent<PickLetterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pickLetter.WhatLetter == 1)
        {
            objectRectTransform.anchoredPosition = new Vector3(-156, 0, 0);
        }
        else if (pickLetter.WhatLetter == 2)
        {
            objectRectTransform.anchoredPosition = new Vector3(0, 0, 0);
        }
        else if (pickLetter.WhatLetter == 3)
        {
            objectRectTransform.anchoredPosition = new Vector3(156, 0, 0);
        }
    }
}

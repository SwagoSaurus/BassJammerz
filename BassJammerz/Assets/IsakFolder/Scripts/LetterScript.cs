using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterScript : MonoBehaviour
{

    public RectTransform objectRectTransform;
    public GameObject PickLetter;
    PickLetterScript pickLetter;
    Vector3 OGPos;
    // Start is called before the first frame update
    void Start()
    {
        pickLetter = PickLetter.GetComponent<PickLetterScript>();
        OGPos = objectRectTransform.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        objectRectTransform.anchoredPosition = new Vector3(objectRectTransform.anchoredPosition.x, OGPos.y - pickLetter.LetterPlace * -60);

        if(objectRectTransform.anchoredPosition.y == 0)
        {
            objectRectTransform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            objectRectTransform.localScale = new Vector3(0, 0, 0);
        }
    }
}

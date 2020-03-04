using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    [SerializeField]
    float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = Speed / 6;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMakerNoteScript : MonoBehaviour
{
    Rigidbody rb;
    Vector3 direction;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        rb.velocity = new Vector3(speed * 4, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }
}
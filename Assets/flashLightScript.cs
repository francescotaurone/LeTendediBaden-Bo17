﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashLightScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x != 0f) transform.eulerAngles = new Vector3(0, 0, 0);
        transform.rotation = new Quaternion (0, 0, 0, 0);
    }
}

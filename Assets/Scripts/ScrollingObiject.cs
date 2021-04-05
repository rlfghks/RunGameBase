﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObiject : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
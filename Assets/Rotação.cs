﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotação : MonoBehaviour
{
    public GameObject prefab;
    public float rotatespeed;

    void FixedUpdate()
    {
        prefab.transform.Rotate(Vector3.up * rotatespeed * Time.deltaTime);   
    }

   
}

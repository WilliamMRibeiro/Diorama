﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{

    public GameObject prefab;
    public float rotatespeed;
    

    private void Update()
    {

        prefab.transform.Rotate(Vector3.up, rotatespeed * Time.deltaTime);

    }

}





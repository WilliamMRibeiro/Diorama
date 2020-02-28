using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamanho : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float xsize = Random.Range(500, 1000);
        float ysize = xsize;
        float zsize = xsize;

        
        transform.localScale = new Vector3(xsize, ysize, zsize);
    }

    
}

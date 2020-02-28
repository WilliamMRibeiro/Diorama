using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirclone : MonoBehaviour
{

    public float timeLimit = 10f;//tempo limite
    private float timer = 0f;// tempo

    void Update()
    {
        timer += Time.deltaTime;// aumenta o tempo

        if (timer >= timeLimit)//condição para destruir o projetil em determinado tempo
        {
            timer = 0;
            Destroy(gameObject);
        }
    }
}

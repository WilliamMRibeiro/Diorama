using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    public GameObject GameObject;
    
    public float speed;

    
    private void Update()
    {

        GameObject.transform.Translate(Vector3.left * speed * Time.deltaTime); 
        
    }


    
}

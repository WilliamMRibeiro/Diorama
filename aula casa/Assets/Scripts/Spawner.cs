using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;//define prefab
    public float minZpos;//posição de z minima
    public float minXpos;//posição de x minima
    public float maxZpos;//posição de z maxima
    public float maxXpos;//posição de x maxima
    public int spawnumber;

    private void Awake()
    {       
        for (int i = 0; i < spawnumber; i++)//condição que faz a contagem de quantos prefabs vão aparecer
        {
            float zpos = Random.Range(minZpos, maxZpos);//escolhe o z de forma aleatoria
            float xpos = Random.Range(minXpos, maxXpos);//define o valor de x
            
            GameObject instafab = Instantiate(prefab, new Vector3(xpos, 0, zpos), prefab.transform.rotation ) as GameObject;//instancia o prefab          
        }
    }
    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respwan : MonoBehaviour
{
    public GameObject nuvem;//define prefab
    float time = 0f;//tempo
    float timeLimit = 4f;//tempo limite
    
    public float minZpos;//posição de z minima
    public float maxZpos;//posição de z maxima
    public float maxXpos;//posição de x maxima
    public float minYpos;//posição de y minima
    public float maxYpos;//posição de y maxima

    private void Update()
    {
        time += Time.deltaTime;//contador
        
        if (time >= timeLimit)//condição
        {
            float zpos = Random.Range(minZpos, maxZpos);//escolhe o y de forma aleatoria
            float ypos = Random.Range(minYpos, maxYpos);
            float xpos = maxXpos;//define o valor de x

            GameObject instanuvem = Instantiate(nuvem, new Vector3(xpos, ypos, zpos), Quaternion.identity) as GameObject;//instancia o prefab da nuvem
            
            time = 0;//reseta a condição e começa o loop
        }
        
    }
}

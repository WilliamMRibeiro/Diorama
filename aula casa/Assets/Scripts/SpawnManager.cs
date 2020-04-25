using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private int spawnAmount;

	public GameObject prefab;	

	public float sizeX, sizeZ;

	public static int cubes = 0;	

	private void Start()
	{
        spawnAmount = Random.Range(1, 10);

        for (int i = 0; i < spawnAmount; i++)
		{
			//Instancia o prefab na posição aleatória, e na rotação que já está definida no prefab
			Instantiate(prefab, Aleatorio.RandomPosition(sizeX, sizeZ), prefab.transform.rotation);

			cubes++;
		}
	}	
}

public static class Aleatorio
{
	public static Vector3 RandomPosition(float sizeX, float sizeZ)
	{
		//Cria o vetor que vai receber a posição aleatória
		Vector3 position;
		//Inicializa as variáveis que vão receber um valor aleatório, conforme o valor de sizeX e sizeZ
		float posX = Random.Range(sizeX * -1, sizeX);
		float posZ = Random.Range(sizeZ * -1, sizeZ);
		//Instancia o vetor com os valores aletórios
		position = new Vector3(posX, 0.5f, posZ);
		//Retorna o vetor
		return position;
	}
}

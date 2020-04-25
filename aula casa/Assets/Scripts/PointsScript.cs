using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PointsScript : MonoBehaviour
{
	public static event Action OnItemCollected;
    public static event Action OnWinCondition;

    private int points = 0;

	public UIScript uiScript;

    private void Awake()
	{	
		uiScript.UpdatePointsText(points);       
	}	

	public void Coletou()
	{
		Debug.Log("Coletou");        
	}

	//Callback chamado quando este script é habilitado
	private void OnEnable()
	{
		//Registra a função "Coletou" no evento "OnItemCollected"
		OnItemCollected += Coletou;
	}

	//Callback chamado quando este script é desabilitado
	private void OnDisable()
	{
		//Remove a função "Coletou" do evento "OnItemCollected"
		OnItemCollected -= Coletou;
	}

	private void OnTriggerEnter(Collider other)
	{
		//Se a tag do trigger é "Collectable"...
		if (other.tag == "Collectable")
		{
			//Adicionar um ponto
			points++;
			//Desativar o game object do trigger que foi ativado
			other.gameObject.SetActive(false);
			//Atualizar o texto de pontuação
			uiScript.UpdatePointsText(points);
			//Se o evento não for nulo...
			if(OnItemCollected != null)
			{
				//Disparar o evento
				OnItemCollected.Invoke();
			}
			//Se o valor de pontos é igual ao numero de coletáveis instanciados
			if (points == SpawnManager.cubes)
			{
                //Mostrar o texto de fim de jogo
                //uiScript.ShowWinText();
                OnWinCondition.Invoke();
			}
		}
	}
}

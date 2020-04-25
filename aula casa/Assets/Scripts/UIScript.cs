using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    private GameManager gameManager;

	public Text pointsText;
	public GameObject WinPanel;
    public GameObject InstructionPanel; //Permite acessar as informações do painel
        
	private void Awake()
	{
        //procurar a game object que possui a tag "GameManager"
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        //Desabilitar o objeto que possui o texto no início do jogo
        if (WinPanel != null)// se o WinPanel não for nulo
        {
            //desabilita da mensagem de vitoria no inicio do jogo
            WinPanel.SetActive(false);
        }
	}
    
    private void OnEnable()
    {
        PointsScript.OnWinCondition += ShowWinPanel;
    }

    private void OnDisable()
    {
        PointsScript.OnWinCondition -= ShowWinPanel;
    }

    public void UpdatePointsText(int points)
	{
		//Atualiza a string do componente de texto com o valor da pontuação do jogador
		pointsText.text = "Pontos: " + points.ToString();
	}

	public void ShowWinPanel()
	{
		//Tonar ativo o Game Object que possui o texto de fim de jogo
		WinPanel.SetActive(true);        
	}

    public void ShowInstructionPanel()
    {
        //Mostra as informações do painel "instruições"
        InstructionPanel.SetActive(true);
    }
    public void ShowOffInstructionPanel()
    {
        //Desabilita o painel "instruções"
        InstructionPanel.SetActive(false);
    }
    
    public void ChanceScene()
    {
        //Carrega a cena "Game"
        gameManager.ChangeScene();
    }

    public void LoadMenu()
    {
        //Carrega a cena "Menu"
        gameManager.LoadPreviousScene();
    }

    public void Restart()
    {
        //recarregar a cena do jogo
        gameManager.ReloadScene();
    }

    public void EndApplication()
    {
        //Encerra o jogo
        gameManager.EndGame();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeScene()
    {
        //Carregar a cena que contém Game
        SpawnManager.cubes = 0;
        SceneManager.LoadScene("Game");
    }

    public void LoadPreviousScene()
    {
        //carregar a cena que contém o Menu
        SceneManager.LoadScene("Menu");
    }

    public void ReloadScene()
    {
        SpawnManager.cubes = 0;
        //acessar o nome da cena que está ativa e atribuir a string "scene"
        string scene = SceneManager.GetActiveScene().name;
        //recarregar a cena ativa
        SceneManager.LoadScene(scene);
    }

    public void EndGame()
    {
        //Encerra o jogo
        Application.Quit();
    }
}


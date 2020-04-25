using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPrefab : MonoBehaviour
{
    public float rotatespeed; // define velocidade da rotação
    Material colorprefab; //recebe a informação de material
    Color colorRandom;//recebe a informação das cores do prefab

    private void Start()
    {
        //adiciona o componente material para o prefab
        colorprefab = GetComponent<MeshRenderer>().material;
        //define as cores de forma aleatória
        colorRandom = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0F, 1.0F), Random.Range(0.0f, 1.0f), 1);
        //muda a cor do prefab
        colorprefab.color = colorRandom;
    }
    private void Update()
    {
        //faz o prefab rotacionar
        transform.Rotate(Vector3.up, rotatespeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;  

    // Variáveis que vão receber os valores de input
    private float horizontal, vertical;

    // Velocidade do personagem
    public float speed = 5f;    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();		
    }

    // Let inputs aqui
    private void Update()
    {
        // Ler o valor de entrada do eixo horizontal e armazenar variável "horizontal"
        horizontal = Input.GetAxis("Horizontal");
        // Ler o valor de entrada do eixo vertical e armazenar variável "vertical"
        vertical = Input.GetAxis("Vertical");      
    }

    // Executar funções com física aqui
    private void FixedUpdate()
    {
        Move(horizontal, vertical);
    }

    // Deslocar o personagem
    private void Move(float x, float z)
    {
        // Cria um vetor pra armazenar a direção do movimento
        Vector3 direction = new Vector3(x, 0, z);

        // Cria um vetor para armazenar a magnetude do movimento
        Vector3 movement = direction * speed * Time.deltaTime;

        // Aplicar como uma força no Rigidbody
        rb.AddForce(movement);
    }    
}   

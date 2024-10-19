using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    //Criando a vari�vel para saber quem � meu rigidbody
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;

    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //Passando a velocidade para a minha velocidade
        minhaVelocidade.x = -velocidade;
        //Adicionando uma velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

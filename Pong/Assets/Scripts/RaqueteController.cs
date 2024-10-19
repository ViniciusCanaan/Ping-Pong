using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    //Criando o meu vector 3
    private Vector3 minhaPosicao;
    private float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.4f;

    //Verificando se sou o Player 1 
    public bool Player1;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando a posição inicial da raquete e aplicando a minha posição.
        minhaPosicao.x = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        //Passando o meuY para o eixo Y da minhaPosicao
        minhaPosicao.y = meuY;
        //Modificar a posição da minha raquete
        transform.position = minhaPosicao;

        //Velocidade multiplicada pelo deltatime
        float deltaVelocidade = velocidade * Time.deltaTime;

        //Pegando a setinha para cima
        //SE eu apertar a setinha para cima ele vai subir a raquete
        //Controlando a raquete como o player 1
        if (Player1) { 
            if (Input.GetKey(KeyCode.UpArrow)){
            
            //Aumentar o valor do meu Y 
            meuY = meuY + deltaVelocidade;
                 
             }

            if (Input.GetKey(KeyCode.DownArrow)){
        
                meuY = meuY - deltaVelocidade;
            
             }
        }
        else
        {
            //Subindo
            if (Input.GetKey(KeyCode.W))
            {
                //Aumentar o valor do meu Y 
                meuY = meuY + deltaVelocidade;
             
            }
            //Descendo
            if (Input.GetKey(KeyCode.S))
            {
               
                meuY = meuY - deltaVelocidade;
                
            }
           
        }
        //Impedindo que eu saia por baixo da tela
        if (meuY < -meuLimite)
        {
            meuY = -meuLimite;
        }
        //Impedindo que eu saia por cima da tela
        if (meuY > meuLimite)
        {
            meuY = meuLimite;
        }

    }
}

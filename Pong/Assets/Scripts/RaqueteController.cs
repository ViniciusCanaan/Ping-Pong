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

    //Vari�vel para checar se ele deve ser controlado pela intelig�ncia artificial
    public bool automatico = false;

    //Pegando a posi��o da bola
    public Transform transformBola;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando a posi��o inicial da raquete e aplicando a minha posi��o.
        minhaPosicao.x = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        //Passando o meuY para o eixo Y da minhaPosicao
        minhaPosicao.y = meuY;
        //Modificar a posi��o da minha raquete
        transform.position = minhaPosicao;

        //Velocidade multiplicada pelo deltatime
        float deltaVelocidade = velocidade * Time.deltaTime;

        //Se o autom�tico N�O � TRUE (ou seja ele � FALSE)
        if (!automatico)
        {

            //Pegando a setinha para cima
            //SE eu apertar a setinha para cima ele vai subir a raquete
            //Controlando a raquete como o player 1
            if (Player1)
            {
                if (Input.GetKey(KeyCode.W))
                {

                    //Aumentar o valor do meu Y 
                    meuY = meuY + deltaVelocidade;

                }

                if (Input.GetKey(KeyCode.S))
                {

                    meuY = meuY - deltaVelocidade;

                }
            }
            else
            {
                //Meu c�digo para colocar ele no autom�tico
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    automatico = true;
                }

                //Subindo
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    //Aumentar o valor do meu Y 
                    meuY = meuY + deltaVelocidade;

                }
                //Descendo
                if (Input.GetKey(KeyCode.DownArrow))
                {

                    meuY = meuY - deltaVelocidade;

                }

            }

        }
        else
        {
            //Tirando ele do autom�tico
            //Checando se a setinha para cima ou setinha para baixo foi pressionada

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                automatico = false;
            }

            //Se a raquete est� no autom�tico
            //Para acessar fun��es matem�ticas, n�s usamos a classe Mathf
            meuY = Mathf.Lerp(meuY, transformBola.position.y, 0.02f);

            //Se meu valor � 0 e o da bola � 10 a diferen�a entre eles � de 10, 10% de 10 � 1
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


        //Checando o exio Y da bola
        Debug.Log(transformBola.position.y);

    }
}

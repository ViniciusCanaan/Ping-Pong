using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    //Criando o meu vector 3
    private Vector3 minhaPosicao;
    public float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.4f;
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


        //Pegando a setinha para cima
        //SE eu apertar a setinha para cima ele vai subir a raquete
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Checar se meuY é menor que meu limite
            if (meuY < meuLimite) {
                //Aumentar o valor do meu Y
                meuY = meuY + velocidade * Time.deltaTime;
            }
           

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(meuY > -meuLimite)
            {
                meuY = meuY - velocidade * Time.deltaTime;
            }
           
        }
    }
}

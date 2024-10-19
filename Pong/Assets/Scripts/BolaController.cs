using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    //Criando a variável para saber quem é meu rigidbody
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;

    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //Passando a velocidade para a minha velocidade
        minhaVelocidade.x = velocidade;
        minhaVelocidade.y = velocidade;

        //Tentando gerar um valor aletório
        int direcao = Random.Range(0, 4);

        if (direcao == 0)
        {
            minhaVelocidade.x = velocidade;
            minhaVelocidade.y = velocidade;
        }
        else if (direcao == 1)
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = -velocidade;
        }
        else if (direcao == 2)
        {
            minhaVelocidade.x = velocidade;
            minhaVelocidade.y = -velocidade;
        }
        else
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = velocidade;
        }
            

        Debug.Log(direcao);

        //Adicionando uma velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

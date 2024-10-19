using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaController : MonoBehaviour
{
    //Criando a vari�vel para saber quem � meu rigidbody
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;

    public float velocidade = 5f;

    public float limiteHorizontal = 12f;

    public AudioClip boing;

    public Transform transformCamera;

    public float delay = 1f;

    public bool jogoIniciado = false;

    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {

        //Iniciando a bola com um delay

        //Diminuindo o valor do delay
        delay = delay - Time.deltaTime;


        //Checando se o delay chegou em 0 para ent�o iniciar o jogo

        if (delay <= 0 && jogoIniciado == false)
        {

            //Alterar o valor da vari�vel de controle
            jogoIniciado = true;

            //Iniciando o jogo

            //Tentando gerar um valor alet�rio
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


            //Debug.Log(direcao);

            //Adicionando uma velocidade para a esquerda
            meuRB.velocity = minhaVelocidade;


        }

        //Checando se a bola saiu da tela
        if (transform.position.x > limiteHorizontal || transform.position.x < -limiteHorizontal)
        {
            //Recarregando a minha cena esse � o ID da Cena
            SceneManager.LoadScene(0);
        }
    }
    //Criando o meu evento de colis�o
    private void OnCollisionEnter2D()
    {
        //Falando oi para com quem eu colidi
       // Debug.Log("Ol�");
        AudioSource.PlayClipAtPoint(boing, transformCamera.position);
    }
}

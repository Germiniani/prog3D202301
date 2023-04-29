using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviaoController : MonoBehaviour
{
    [Header("Configuração da Helice")]
    public GameObject helice;
    public float fatorDeGiro;

    [Header("Movimentação Avião")]
    public KeyCode paraCima;
    public KeyCode paraBaixo;
    public KeyCode paraDireita;
    public KeyCode paraEsquerda;
    public KeyCode acelerar;
    public KeyCode freiar;
    private float aceleracao = 0.01f;
    private float movX = 0.01f;
    private float movY = 0.01f;
    public bool ligado = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ligado)
        {
            giroHelice();
            movimentoAviao();
        }
        

    }
    public void movimentoAviao()
    {
        #region Aceleração do avião
        if (Input.GetKey(acelerar))
        {
            //aceleracao++;
            aceleracao = aceleracao - 0.01f * Time.deltaTime;
        }
        if (Input.GetKey(freiar))
        {

            if (aceleracao < 0)
            {
                aceleracao = aceleracao + 0.01f;
            }
        }
        #endregion  
        movX = 0.01f; movY = 0.01f;
        #region Movimento do avião
        if (Input.GetKey(paraCima))
        {
            movX = 0.01f;
        }
        if (Input.GetKey(paraBaixo))
        {
            movX = -0.01f;
        }
        if (Input.GetKey(paraDireita))
        {
            movY = 0.01f;
        }
        if (Input.GetKey(paraEsquerda))
        {
            movY = -0.01f;
        }
        #endregion
        transform.Translate(Vector3.up * aceleracao);
        transform.Rotate(new Vector3(movX, movY, movY));
    }
    public void giroHelice()
    {
        helice.transform.Rotate(new Vector3(0, fatorDeGiro * Time.deltaTime, 0));   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "jogador")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            ligado = true;
        }
    }

}

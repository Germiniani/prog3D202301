using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCamera : MonoBehaviour
{
    public GameObject bolinha;
    
    public Vector3 posicaoInicial;
    public Vector3 posicaoAtual;

    //solu��o Nicolas
    //public Vector3 diferenca;

    // Start is called before the first frame update
    void Start()
    {
        #region Solu��o Nicolas
        //posicaoInicial = bolinha.transform.position;
        //diferenca = bolinha.transform.position - transform.position;
        #endregion

        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        #region Solu��o Nicolas
        //posicaoAtual = bolinha.transform.position;
        //transform.position = bolinha.transform.position - diferenca;
        #endregion

        transform.position = posicaoInicial + bolinha.transform.position;


    }
}

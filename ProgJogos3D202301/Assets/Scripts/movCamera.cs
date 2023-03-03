using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCamera : MonoBehaviour
{
    public GameObject bolinha;
    public Vector3 posicaoInicial;
    public Vector3 posicaoAtual;
    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = bolinha.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoAtual = bolinha.transform.position;
        transform.position = transform.position +
            (posicaoAtual - posicaoInicial);
;    }
}

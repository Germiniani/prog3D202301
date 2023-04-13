using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoController : MonoBehaviour
{
    public aviaoController aviao;
    public Camera cam1Pessoa;
    public Camera cam3Pessoa;
    public Camera camRetrovisor;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aviao.ligado)
        {
            cam1Pessoa.enabled = true;
            cam3Pessoa.enabled = true; 
            camRetrovisor.enabled = true;
        }
        else
        {
            cam1Pessoa.enabled = false;
            cam3Pessoa.enabled = false;
            camRetrovisor.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoController : MonoBehaviour
{
    public aviaoController aviao;
    public Camera cam1Pessoa;
    public Camera cam3Pessoa;
    public Camera camRetrovisor;


    public KeyCode habilitarRetrovisor;
    public KeyCode trocaCamera;
    private bool habilitaCam3Pessoa = false;
    
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
        trocaDeCamera();
        retrovisor();
    }
    public void trocaDeCamera()
    {
        if (Input.GetKeyDown(trocaCamera))
        {
            habilitaCam3Pessoa = !habilitaCam3Pessoa;
            if (habilitaCam3Pessoa)
            {
                cam3Pessoa.depth = 2;
                cam1Pessoa.depth = 0;
            }
            else
            {
                cam3Pessoa.depth = 0;
                cam1Pessoa.depth = 2;
            }
        }
    }
    public void retrovisor()
    {
        if (Input.GetKey(habilitarRetrovisor))
        {
            camRetrovisor.depth = 10;
        }
        else{
            camRetrovisor.depth = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenaController : MonoBehaviour
{
    [SerializeField] private Transform jogador;
    [SerializeField] private Transform mar;
    [SerializeField] private Color corAgua;
    [SerializeField] private Color corForaAgua;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador.position.y < mar.position.y)
        {
            //debaixo da agua
            RenderSettings.fog = true;
            RenderSettings.fogDensity = 0.03f;
            RenderSettings.fogMode = FogMode.Exponential;
            RenderSettings.fogColor = corAgua;
        }
        else
        {
            //acima da água
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Linear;
            RenderSettings.fogColor = corForaAgua;
            RenderSettings.fogStartDistance = 100;
            RenderSettings.fogEndDistance = 300;
        }
    }
}

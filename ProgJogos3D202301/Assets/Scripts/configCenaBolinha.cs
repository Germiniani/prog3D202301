using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class configCenaBolinha : MonoBehaviour
{
    public float tempo = 0;
    public Text txtRelogio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;
        txtRelogio.text = "Tempo: " + tempo.ToString("000");
    }
}

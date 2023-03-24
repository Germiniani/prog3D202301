using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miraLaser : MonoBehaviour
{
    private LineRenderer linha;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        linha = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        linha.SetPosition(0, transform.position);
        linha.SetPosition(1, transform.position + transform.forward * distancia);
    }
}

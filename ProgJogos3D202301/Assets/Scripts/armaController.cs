using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armaController : MonoBehaviour
{
    public KeyCode teclaLaser;
    private bool habilitado = false;
    public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teclaLaser))
        {
            habilitado = !habilitado;
            if (habilitado)
            {
                laser.SetActive(true);
            }
            else
            {
                laser.SetActive(false);
            }
            
        }
    }
}

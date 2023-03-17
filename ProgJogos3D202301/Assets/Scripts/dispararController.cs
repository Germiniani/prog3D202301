using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispararController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bala;
    [SerializeField] private GameObject canoArma;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
 
            var b = Instantiate(bala, canoArma.transform.position,
                canoArma.transform.rotation);
            Destroy(b, 2f);
        }
    }
}

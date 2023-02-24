using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBolinha : MonoBehaviour
{
    public float movX;
    public float movZ;
    public float velocidade;
    //teclas
    public KeyCode paraCima;
    public KeyCode paraBaixo;
    public KeyCode esquerda;
    public KeyCode direita;
    private Rigidbody fisica;
    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        #region 1� maneira de pegar entrada do jogador
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        #endregion
        #region 2� maneira de pegar entrada do jogador
        movX = 0;
        movZ = 0;
        if (Input.GetKey(paraCima))
        {
            movZ = 1;
        }
        if (Input.GetKey(paraBaixo))
        {
            movZ = -1;
        }
        if (Input.GetKey(esquerda))
        {
            movX = -1;
        }
        if (Input.GetKey(direita))
        {
            movX = 1;
        }
        #endregion

        Vector3 mov = new Vector3(movX * Time.deltaTime * velocidade,
            0,
            movZ * Time.deltaTime * velocidade);
        #region 1� forma de movimenta��o
        //transform.Translate(mov);
        #endregion

        #region 2� forma de movimenta��o
        fisica.AddForce(mov * velocidade);
        #endregion

        #region 3� forma de movimenta��o
        //fisica.velocity = mov * velocidade;
        #endregion
    }
}

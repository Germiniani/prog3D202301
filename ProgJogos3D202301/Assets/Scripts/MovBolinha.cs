using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBolinha : MonoBehaviour
{
    public float movX;
    public float movZ;
    public float velocidade;
    public float forcaPulo;
    //teclas
    public KeyCode paraCima;
    public KeyCode paraBaixo;
    public KeyCode esquerda;
    public KeyCode direita;
    private Rigidbody fisica;

    private bool estaNoChao = false;
    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        #region 1ª maneira de pegar entrada do jogador
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        #endregion
        #region 2ª maneira de pegar entrada do jogador
        //movX = 0;
        //movZ = 0;
        //if (Input.GetKey(paraCima))
        //{
        //    movZ = 1;
        //}
        //if (Input.GetKey(paraBaixo))
        //{
        //    movZ = -1;
        //}
        //if (Input.GetKey(esquerda))
        //{
        //    movX = -1;
        //}
        //if (Input.GetKey(direita))
        //{
        //    movX = 1;
        //}
        #endregion

        Vector3 mov = new Vector3(movX * Time.deltaTime * velocidade,
            0,
            movZ * Time.deltaTime * velocidade);
        #region 1ª forma de movimentação
        //transform.Translate(mov);
        #endregion

        #region 2ª forma de movimentação
        fisica.AddForce(mov * velocidade);
        #endregion

        #region 3ª forma de movimentação
        //fisica.velocity = mov * velocidade;
        #endregion

        //pulo da bolinha
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao == true)
        {
            fisica.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "chao")
        {
            estaNoChao = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "chao")
        {
            estaNoChao = false;
        }
    }
}

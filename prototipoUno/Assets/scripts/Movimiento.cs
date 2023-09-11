using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Monobehaviour contiene metodos inherentes a la 
ejecución frame by frame*/
public class Movimiento : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start() {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(movimientoHorizontal, 0, movimientoVertical);

        rb.AddForce(mov*speed);
    }
}

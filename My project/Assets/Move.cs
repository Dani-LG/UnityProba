using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float moveSpeed = 5f; // Velocidad de movimiento


    // Update is called once per frame
     void Update()
    {
        // Movimiento en el eje X
        float horizontal = Input.GetAxis("Horizontal"); // A, D, flecha izquierda, flecha derecha
        // Movimiento en el eje Y
        float vertical = Input.GetAxis("Vertical"); // W, S, flecha arriba, flecha abajo

        // Movimiento de la esfera
        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);  // Mueve la esfera
    }
}

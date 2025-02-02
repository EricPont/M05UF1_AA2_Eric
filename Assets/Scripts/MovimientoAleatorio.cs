using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float maxSpeed = 133f;
    public float minSpeed = 33f;

    void Start()
    {
        //Fuerza alatoria
        rb = GetComponent<Rigidbody2D>();

        float verticalSpeed = Random.Range(minSpeed, maxSpeed);
        float horizontalSpeed = Random.Range(minSpeed, maxSpeed);

        rb.AddForce(new Vector2(verticalSpeed, horizontalSpeed));

        //Rotacion Aleatoria
        float RandomRotation = Random.Range(0, 180f);

        transform.eulerAngles = new Vector3(0, 0, -RandomRotation * RandomRotation);
    }
}

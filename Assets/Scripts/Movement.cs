using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Xspeed = 1.0f;
    public Text Texto_de_direccion;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.left * Xspeed) * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.right * Xspeed) * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = transform.localScale - new Vector3(0, 1.0f, 0);
            transform.position = new Vector3(transform.position.x, -2.4f, transform.position.z);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = transform.localScale + new Vector3(0, 1.0f, 0);
            transform.position = new Vector3(transform.position.x, -1.9f, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, -0.850f, transform.position.z);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, -1.9f, transform.position.z);
        }


        if (Input.GetMouseButton(0))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            Texto_de_direccion.text = "Left";
        }
        if (Input.GetMouseButton(1))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            Texto_de_direccion.text = "Right";
        }

    }
}
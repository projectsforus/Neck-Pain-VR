using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmm : MonoBehaviour {

    // Use this for initialization

    public float keySpeed = 20;
    public float mouseSpeed = 1.25f;
    public GameObject eye;

    private Quaternion originalRotation;
    private Vector2 angle = new Vector2(40f, 30f);


    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Strafe(-keySpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Strafe(keySpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Fly(keySpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Fly(-keySpeed * Time.deltaTime);
        }

        float dx = Input.GetAxis("Mouse X");
        float dy = Input.GetAxis("Mouse Y");
        Look(new Vector2(dx, dy) * mouseSpeed);
    }

    void Strafe(float dist)
    {
        transform.position += eye.transform.right * dist;
    }

    void Fly(float dist)
    {
        transform.position += eye.transform.forward * dist;
    }

    void Look(Vector2 dist)
    {
        angle += dist;


        Quaternion quatX = Quaternion.AngleAxis(angle.x, Vector3.up);
        Quaternion quatY = Quaternion.AngleAxis(angle.y, -Vector3.right);

        transform.localRotation = originalRotation * quatX * quatY;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float rotX;
    public float rotY;
    public float rotZ;


    //Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("z"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if (Input.GetKey("z") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey("q") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("d") && !Input.GetKey("q"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
    }

    void Update()
    {
        rotX -= Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed;
        rotY += Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
        if (rotX < -90)
        {
            rotX = -90;
        }
        else if (rotX > 90)
        {
            rotX = 90;
        }
        transform.rotation = Quaternion.Euler(0, rotY, 0);
        GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(rotX, rotY, 0);
    }
}

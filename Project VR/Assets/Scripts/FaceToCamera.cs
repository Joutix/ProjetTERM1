using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceToCamera : MonoBehaviour
{
    void Update()
    {
        Vector3 UpAxis = Vector3.up;
        transform.rotation = Quaternion.LookRotation(Vector3.Cross(UpAxis, Vector3.Cross(UpAxis, -Camera.main.transform.forward)), UpAxis);
        
    }
}

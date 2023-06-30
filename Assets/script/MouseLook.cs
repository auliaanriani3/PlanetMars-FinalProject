using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float rotX;
    float rotY;
    [SerializeField] float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotX += Input.GetAxis("Mouse Y") * sensitivity;
        rotY += Input.GetAxis("Mouse X") * sensitivity;
        transform.localEulerAngles = new Vector3(rotX, rotY, 0);
    }

}

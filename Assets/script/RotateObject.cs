using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(20 * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(-20 * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -20 * Time.deltaTime,0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 20 * Time.deltaTime,0));
        }
    }
}

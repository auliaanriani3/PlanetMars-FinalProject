using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSwipe : MonoBehaviour
{
    Vector3 previousPosition;
    [SerializeField] public float Sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 dir = previousPosition - Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //Debug.Log(dir);
            transform.Rotate(Vector3.right, dir.y * Sensitivity * Time.deltaTime);
            transform.Rotate(Vector3.down, dir.x * Sensitivity * Time.deltaTime);
            previousPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    Vector3 previousPosition;
    [SerializeField] public float Sensitivity;
    Vector3 moveDestination;
    public float speed;
    public bool isClick;


    // Start is called before the first frame update
    void Start()
    {
        moveDestination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ObjectToMouse();
        if (isClick == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                previousPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            }
            if (Input.GetMouseButton(0))
            {
                Vector3 dir = previousPosition - Camera.main.ScreenToViewportPoint(Input.mousePosition);
                Camera.main.transform.Rotate(Vector3.right, dir.y * Sensitivity * Time.deltaTime);
                transform.Rotate(Vector3.down, dir.x * Sensitivity * Time.deltaTime);
                previousPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            }
        }
    }

    public void ClickOn()
    {
        isClick = true;
    }

    public void ClickOff()
    {
        isClick = false;
    }
    void ObjectToMouse()
    {
        transform.position = Vector3.Lerp(transform.position, moveDestination, speed * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.PositiveInfinity))
            {
                if (hit.collider.tag == "Ground")
                {
                    Debug.Log(hit.point);
                    moveDestination = new Vector3(hit.point.x, hit.point.y + 1, hit.point.z);

                }
            }
            
        }
    }
}

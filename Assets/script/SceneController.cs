using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    bool clickStart;
    bool clickEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveScene();
    }

    public void MoveScene()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.PositiveInfinity))
            {
                if (hit.collider.tag == "Planet")
                {
                    clickStart = true;
                }
            }
            else
            {
                clickStart = false;
            }
        }
        else if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.PositiveInfinity))
            {
                if (hit.collider.tag == "Planet" && clickStart)
                {
                    clickEnd = true;  
                }
            }
            else
            {
                clickEnd = false;
            }
        }
        else if(Input.GetMouseButtonUp(0) && clickEnd)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
        
}
/*
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
*/
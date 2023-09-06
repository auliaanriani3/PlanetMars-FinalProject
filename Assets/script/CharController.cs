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
    public GameObject[] items;
    public GameObject[] itemInfos;
    public float distanceToShowInfo;
    public GameObject[] sign;

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

        for (int i = 0; i < items.Length; i++) 
        {
            if(Vector3.Distance(transform.position, items[i].transform.position) <= distanceToShowInfo)
            {
                itemInfos[i].SetActive(true);
                sign[i].SetActive(false);
            }
            else
            {
                itemInfos[i].SetActive(false);
                sign[i].SetActive(true);
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
}

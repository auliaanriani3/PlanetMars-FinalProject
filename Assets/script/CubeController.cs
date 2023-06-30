using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public int a;
    public int b;
    public int hasil;
    public int jumlah;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Penjumlahan();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Perkalian();
        }
    }

    void Penjumlahan()
    {
        hasil = a + b;
    }

    void Perkalian()
    {
        hasil = a * b;
    }
}

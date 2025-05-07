using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class counter : MonoBehaviour
{
    public int numero = 30;
    void Start()
    {
        while (numero >= 0)
        {

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Debug.Log("FizzFuzz");
            }
            else if (numero % 5 == 0)
            {
                Debug.Log("Fuzz");
            }
            else if (numero % 3 == 0)
                Debug.Log("Fizz");
            else
            {
                Debug.Log(numero);
            }
        numero--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public int num = 0;
    public int index = 10;
    void Start()
    {
        while (index >= 0)
        {
            Debug.Log(num ++);
            index--;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

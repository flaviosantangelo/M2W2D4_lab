using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public int num = 0;
    private int index = 10;
    void Start()
    {
        while (index >= 0)
        {
            num = num + 1;
            Debug.Log(num);
            index--;
        }

    }
}
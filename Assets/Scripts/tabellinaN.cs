using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabellinaN : MonoBehaviour
{
    private int i = 0;
    public int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (i < 10)
        {
            int num = (i + 1) * n;
            Debug.Log(num);
            i++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        long a = 2;
        long b = 1;
        int c = 1;
        int d = 2;
        
        add(c,d);
        add(a,b);

    }

    public int add(int a, int b){
        return a + b;
    }

    public long add(long a, long b){
        return a + b;
    }
}

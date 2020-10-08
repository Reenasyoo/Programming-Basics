using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool test = true;
    public int x = 2;
    
    void Start()
    {
        func2();
    }

    void func()
    {
        int s = 12;
        int p = 0;

        if (s == p)
        {
            Debug.Log(p);
        }
        else if ((s > p) && ((s - 7) != 5))
        {
            Debug.Log("aaaaaa");
        }
        else
        {
            Debug.Log(s);
        }
    }

    void func2()
    {
        switch (x)
        {
            case 0:
                Debug.Log(1111);
                break;
            case 1:
                Debug.Log(222);
                break;
            case 2:
                Debug.Log(4444);
                break;

        }
    }
}

// Single line comment

/* 
multi
line
comment


int a;
float f = 1.2f;
string sss = "text";
bool b = false;


*/

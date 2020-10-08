using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool test = true;
    public int x = 2;

    void Start()
    {
        func3();
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

    void func3()
    {
        int x = 0;
        int y = 0;

        while (x < 5)
        {
            Debug.Log(x);
            x++;
        }

        do
        {
            Debug.Log(y);
            y++;
        } while (y < 5);
    }

    void func4()
    {
        int x = 3;
        int j = 0;

        for (j = 0; j < x; j++)
        {

        }

        for (int i = 0; i < x; i++)
        {
            Debug.Log(i);
        }
    }

    void uzd1()
    {
        int x = 5;
        int y = 5;

        if (x > y)
        {
            Debug.Log("was it so hard?");
        }
    }

    void uzd2()
    {
        int x = 5;
        if ((x % 2) == 0)
        {
            Debug.Log("was it so hard?");
        }
    }

    void uzd3()
    {
        int x = 5;

        if (x > 0)
        {
            Debug.Log("was it so hard?");
        }
        else
        {
            Debug.Log("was it so hard?");
        }
    }

    void uzd4()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i);
        }
    }

    void uzd5()
    {
        int x = 0;
        for (int i = 1; i <= 10; i++)
        {
            x = x + i;
        }
        Debug.Log(x);

    }

    void uzd6()
    {
        int x = 0;
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i);
            x = x + i;
        }
        Debug.Log(x);
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

x++
x += 2
x = x+1

*/

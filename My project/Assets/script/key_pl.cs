using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_pl : MonoBehaviour
{
    public float keynum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getkey()
    {
        keynum++;
    }

    public bool usekey(int num)
    {
        if (keynum >= num)
        {
            return true;
        }
        else {
            return false;
        }
    }
}

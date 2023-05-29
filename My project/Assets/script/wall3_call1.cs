using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall3_call1 : MonoBehaviour
{
    public wall3_moveout wall1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Player"))
        {
            wall1.call();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Player"))
        {
            wall1.leave();
        }
    }
}

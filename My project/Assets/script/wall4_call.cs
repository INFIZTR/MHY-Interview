using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall4_call : MonoBehaviour
{
    public wall4_movement wall1;
    public wall4_movement1 wall2;

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
            wall2.call();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Player"))
        {
            wall1.leave();
            wall2.leave();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Call_ele1_up : MonoBehaviour
{
    public controller_ele1 elevator1;

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
            elevator1.callUP(transform.position);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Player"))
        {
            elevator1.leave();
        }
    }
}

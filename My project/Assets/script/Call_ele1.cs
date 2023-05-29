using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Call_ele1 : MonoBehaviour
{
    public controller_ele1 Elevator1;

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
            Elevator1.call();
        }
    }
}
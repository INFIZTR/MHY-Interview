using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plate1_Call : MonoBehaviour
{
    public plate1_moveout plate1;
    public box1_moveout plate2;

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
            plate1.call();
            plate2.call();
        }
    }
}

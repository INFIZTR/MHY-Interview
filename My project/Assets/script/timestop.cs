using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timestop : MonoBehaviour
{
    public bool triggered = false;
    public bool timestopped = false;

    bool stoplock = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!stoplock)
                {
                    timestopped = true;
                    stoplock = true;
                }
            }
        }
    }

    public void timebegin() {
        stoplock = false;
        timestopped = false;
    }

    public void trigger()
    {
        triggered = true;
    }
}

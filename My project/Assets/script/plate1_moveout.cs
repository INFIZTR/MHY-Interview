using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plate1_moveout : MonoBehaviour
{
    public float wall = -10;
    public float ceiling = 0;
    public float speed = 3;

    bool readycounter = true;
    bool ready = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ready)
        {
            
            if (wall < transform.position.x)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }       
            else if (ceiling > transform.position.y)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            else
            {
                ready = false;
            }
            
            return;
        }
    }

    public void call()
    {
        if (readycounter)
        {
            ready = true;
        }
        readycounter = false;
    }
}

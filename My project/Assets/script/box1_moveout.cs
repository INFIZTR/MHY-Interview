using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box1_moveout : MonoBehaviour
{
    public float wall = -12;
    public float ceiling = 1;
    public float speed = 2;

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
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            
            else if (ceiling > transform.position.y)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
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

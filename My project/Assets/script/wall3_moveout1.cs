using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall3_moveout1 : MonoBehaviour
{
    public float rightside = 170;
    public float leftside = -85;
    public float speed = 5;

    public timestop t1;
    public float stopFrame = 1500;
    public float st;


    bool ready = false;
    bool leaving = false;


    // Start is called before the first frame update
    void Start()
    {
        st = stopFrame;
        rightside = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (t1.timestopped)
        {
            if (st > 0)
            {
                st = st--;
                return;
            }
            else
            {
                st = stopFrame;
            }
        }
        else
        {
            move();
        }

    }

    void move()
    {
        if (ready)
        {
            if (leftside > transform.position.x)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            else
            {
                ready = false;
            }

            return;
        }

        if (leaving)
        {
            if (transform.position.x > rightside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                leaving = false;
            }
            return;
        }
    }

        public void call()
    { 
        ready = true;

    }

    public void leave()
    {
        leaving = true;
    }
    
}

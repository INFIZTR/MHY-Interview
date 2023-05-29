using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall1_moveout : MonoBehaviour
{
    public float ceiling = 3;
    public float floor = 165;
    public float speed = 5;

    public timestop t1;
    public float stopFrame = 1500;
    float st;

    bool ready = false;
    bool leaving = false;

    // Start is called before the first frame update
    void Start()
    {
        st = stopFrame;
        floor = transform.position.y;
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
        else {
            move();
        }
    }

    void move() {
        if (ready)
        {

            if (ceiling > transform.position.y)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            else
            {
                ready = false;
            }

            return;
        }
        if (leaving)
        {
            if (transform.position.y > floor)
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
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

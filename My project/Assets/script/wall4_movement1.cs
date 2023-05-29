using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall4_movement1 : MonoBehaviour
{

    public float Lwall = -48;
    public float Rwall = -50;
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
        Lwall = transform.position.z;
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

            if (transform.position.z > Rwall)
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            else
            {
                ready = false;
            }

            return;
        }
        if (leaving)
        {
            if (Lwall > transform.position.z)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
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

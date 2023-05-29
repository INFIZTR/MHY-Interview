using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall5_movement : MonoBehaviour
{

    public float Lwall = -55;
    public float Rwall = 165;
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
        Rwall = transform.position.z;
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

            if (Lwall > transform.position.z)
            {
                transform.Translate(Vector3.down * Time.deltaTime * speed);
            }
            else
            {
                ready = false;
            }

            return;
        }
        if (leaving)
        {
            if (transform.position.z > Rwall)
            {
                transform.Translate(Vector3.down * Time.deltaTime * speed);
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

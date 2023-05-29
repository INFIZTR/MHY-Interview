using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public float Lwall = 1;
    public float Rwall = 165;
    public float speed = 3;

    public timestop t1;
    public float stopFrame = 1500;
    float st;

    bool ready = false;
    bool leaving = false;

    // Start is called before the first frame update
    void Start()
    {
        Lwall = transform.position.y;
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

            if (transform.position.y < Rwall)
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
            if (Lwall < transform.position.y)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
            else
            {
                leaving = false;
            }
            return;
        }
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Player"))
        {
            call();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Player"))
        {
            leave();
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

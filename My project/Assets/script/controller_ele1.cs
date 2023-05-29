using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class controller_ele1 : MonoBehaviour
{
    public float floor = 160;
    public float ceiling = 10;
    public float speed = 3;

    bool goingUP = true;
    public bool iswaiting = false;
    bool readycounter = true;
    bool ready = false;//升起来一点点
    bool readyUP = false;//降下去一点点
    bool leaving = false;

    Vector3 callposition;

    public timestop t1;

    public float stopFrame = 500;
    public float st;
    // Start is called before the first frame update
    void Start()
    {
        st = stopFrame;
    }

    // Update is called once per frame
    void Update()
    {
        if (t1.timestopped)
        {
            if (st > 0)
            {
                st = st - 1;
                return;
            }
            else {
                st = stopFrame;
                t1.timebegin();
            }
        }
        else {
            move();
        }
    }

    
    void move()
    {
        if (ready) {
            for (int i = 0; i < 3; i++) {
                transform.Translate(Vector3.forward * Time.deltaTime * 30);
            }
            floor = transform.position.y;
            ready = false;
            return;
        }

        if (readyUP)
        {
           
            bool isDown = callposition.y < transform.position.y;
            transform.Translate((isDown ? Vector3.back : Vector3.forward) * Time.deltaTime * speed);
            
            if (callposition.y < transform.position.y + 9) {
                readyUP = false;
                goingUP = false;
                return;
            }
            return;
        }

        if (iswaiting)
        {
            if (transform.position.y > ceiling)
            {
                goingUP = false;
                iswaiting = false;
                return;
            }
            if (transform.position.y < floor)
            {
                goingUP = true;
                iswaiting = false;
                return;
            }
            transform.Translate((goingUP ? Vector3.forward : Vector3.back) * Time.deltaTime * speed);
            //transform.Translate((goingUP ? Vector3.forward : Vector3.back) * Time.deltaTime * speed);
            /*
            if (transform.position.y >= ceiling)
            {
                goingUP = false;
            }
            if (transform.position.y <= floor)
            {
                goingUP = true;
            }
            */
        }

        if (leaving)
        {

            if (transform.position.y < floor)
            {
                leaving = false;
                return;
            }
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            return;
            /*
            if (transform.position.y >= ceiling)
            {
                goingUP = false;
            }
            if (transform.position.y <= floor)
            {
                goingUP = true;
            }
            */
        }

    }

    void OnTriggerEnter(Collider other)
    {
        transform.Translate((goingUP ? Vector3.forward : Vector3.back) * Time.deltaTime * 20);
        iswaiting = true;
    }

    public void call()
    {
        if (readycounter) {
            ready = true;
        }
        readycounter = false;
    }

    public void callUP(Vector3 position)
    {
        callposition = position;
        readyUP = true;
    }

    public void leave()
    {
        leaving = true;
    }

}
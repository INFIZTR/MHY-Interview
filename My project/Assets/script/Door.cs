using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float Lwall = 1;
    public float Rwall = 165;
    public float speed = 3;


    bool ready = false;
    bool leaving = false;

    // Start is called before the first frame update
    void Start()
    {
        Rwall = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (ready)
        {

            if (Lwall > transform.position.z)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
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

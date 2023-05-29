using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_counter : MonoBehaviour
{
    public float points = 0;

    float boxpoint = 0;

    bool hitted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hitted)
        {
            points = points + boxpoint;
            hitted = false;
            return;
        }
    }

    public void boxhit(float point) {
        boxpoint = point;
        hitted = true;
    }
}

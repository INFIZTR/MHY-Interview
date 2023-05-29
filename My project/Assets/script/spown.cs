using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spown : MonoBehaviour
{
    [SerializeField] private Transform respawnpoint;
    public float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = respawnPoint.transform.position;
    }

    public void respawn()
    {
        counter++;
        transform.position = respawnpoint.transform.position;
        //transform.Translate(respawnPoint.transform.position);
    }
}

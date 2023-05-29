
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{
    public float counter = 0;
    [SerializeField] private PlayerMotor player;

    void OnTriggerEnter(Collider players)
    {
        counter++;
        player.respawn();
    }
}




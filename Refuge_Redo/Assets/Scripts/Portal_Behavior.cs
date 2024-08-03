using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Behavior : MonoBehaviour
{

    public Transform end_location;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("hit");
            player.transform.position = end_location.transform.position;
        }
    }
}

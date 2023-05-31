using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloader : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMirrorDude : MonoBehaviour
{
   public GameObject mirrorDude;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        Instantiate(mirrorDude);
    }
}

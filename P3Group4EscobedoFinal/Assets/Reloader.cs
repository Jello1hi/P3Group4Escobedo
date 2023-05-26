using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloader : MonoBehaviour
{
   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(0,1,-3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

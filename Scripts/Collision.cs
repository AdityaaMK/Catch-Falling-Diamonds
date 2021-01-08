using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -20)
        {
            Debug.Log("Too far!");
            Destroy(gameObject);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Collided!");
    //    Destroy(gameObject);
    //}
}

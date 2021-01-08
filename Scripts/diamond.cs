using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    public float delay = 2f;
    public GameObject gem;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(gem, new Vector3(Random.Range(-7, 8), 10, Random.Range(0, 5)), Quaternion.Euler(-90, 0, 0));
    }
} 

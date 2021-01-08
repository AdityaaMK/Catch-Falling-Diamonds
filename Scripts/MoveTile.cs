using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTile : MonoBehaviour
{
    public Text score;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //Debug.Log(Input.GetAxis("Horizontal"));
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    transform.Translate(new Vector3(-5,0,0) * Time.deltaTime);
        //if (Input.GetKey(KeyCode.RightArrow))
        //    transform.Translate(new Vector3(5,0,0) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided!");
        Destroy(other.gameObject);
        count++;
        score.text = "Score: " + count.ToString();
    }

}

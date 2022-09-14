using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting.APIUpdating;


public class player : MonoBehaviour
{
    public float inc;
    public Transform minx;
    public Transform maxx;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
    move();
    }

void move()
{
    if(Input.GetKeyDown(KeyCode.D))
    {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minx.position.x, maxx.position.x), transform.position.y, transform.position.x);
    }
    else if(Input.GetKeyDown(KeyCode.A))
    {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minx.position.x, maxx.position.x), transform.position.y, transform.position.x);
        }
}

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
            SceneManager.LoadScene(0);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public float delay;
    public Transform left;
    public Transform right;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, delay);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        int rand = Random.Range(1, 4);
        Instantiate(enemy, transform);
        if(rand == 1)
        {
            Instantiate(enemy, left);
        }
        else if(rand == 2)
        {
            Instantiate(enemy, right );
        }
        else 
        {
            Instantiate(enemy, transform);
        }
    }
}

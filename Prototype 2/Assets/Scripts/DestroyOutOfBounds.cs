using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40;
    private float lowerBound = -20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            //destroy out of bound
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //gameover log
            Debug.Log("GameOver!");
            //destroy out of bound 
            Destroy(gameObject);
        }
    }
}

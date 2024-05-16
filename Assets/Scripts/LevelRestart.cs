using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            Debug.Log(collision.collider.name);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}

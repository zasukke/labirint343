using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    public Rigidbody rb;

    public int rand;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        x = -1;
        Invoke("changeVector", 2f);
    }

    void Update()
    {
        rb.velocity = new Vector3(x, y, z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            rand = Random.Range(1, 5);
            if (rand == 1)
            {
                rand = Random.Range(2,5);
            }

            if (rand == 2)
            {
                rand = Random.Range(3, 5);
            }

            if (rand == 3)
            {
                rand = Random.Range(1, 3);
            }

            if (rand == 4)
            {
                rand = Random.Range(1, 4);
            }

            changeVector();
        }
    }

    public void changeVector()
    {
        rand = Random.Range(1, 5);
        if (rand == 1)
        {
            x = 1;
            y = 0;
            z = 0;
        }

        if (rand == 2)
        {
            x = -1;
            y = 0;
            z = 0;
        }

        if (rand == 3)
        {
            x = 0;
            y = 0;
            z = 1;
        }

        if (rand == 4)
        {
            x = 0;
            y = 0;
            z = -1;
        }

        Invoke("changeVector", 4f);
    }

}

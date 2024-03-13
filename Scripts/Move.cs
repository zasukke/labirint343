using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Скорость игрока")][Range(1,10)]
    public float speed = 2;
    public float Ourtime;
    [HideInInspector]
    public bool isGround;

    [SerializeField]
    private GameObject Dialog;
    public GameObject WinText;

    public AnimationCurve AnimCurve;
    void Start()
    {
        
    }

    void Update()
    {
        Ourtime += Time.deltaTime;
        if (Ourtime > 2)
        {
            Ourtime = 0.5f;
        }
        speed = AnimCurve.Evaluate(Ourtime);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space) && isGround == true)
        {
            transform.position += new Vector3(0, 5, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }

        if (collision.gameObject.tag == "NPC")
        {
            Dialog.SetActive(true);
        }

        if (collision.gameObject.tag == "Win")
        {
            WinText.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }

        if (collision.gameObject.tag == "NPC")
        {
            Dialog.SetActive(false);
        }
    }

}

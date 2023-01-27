using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float geschwindigkeit = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(0, 0, geschwindigkeit * 2);
            }
           
            transform.position += new Vector3(0, 0, geschwindigkeit);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(-geschwindigkeit * 2,  0, 0);
            }

            transform.position += new Vector3(-geschwindigkeit, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(0, 0, -geschwindigkeit * 2);
            }

            transform.position += new Vector3(0, 0, -geschwindigkeit);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(geschwindigkeit * 2, 0, 0);
            }

            transform.position += new Vector3(geschwindigkeit, 0, 0);
        }
    }
}

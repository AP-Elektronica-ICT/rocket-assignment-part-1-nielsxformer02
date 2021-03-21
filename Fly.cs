using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody rb;


    Vector3 m_EulerAngleVelocity;
    void Start()
    {
        rb.GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * speed);


        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_EulerAngleVelocity = new Vector3(-5, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_EulerAngleVelocity = new Vector3(5, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
            // transform.Rotate(new Vector3(0.1f, 0, 0));
        }
  

        

    }
}

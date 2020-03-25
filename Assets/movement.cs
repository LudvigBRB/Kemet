using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpPower = 10f;
    Rigidbody rb;
    int limit = 0;

    private Vector3 target = new Vector3(5.0f, 0.0f, 0.0f);

    float y = 0f;
    float x = 0f;

    //get component 
    //GetComponent

    // Start is called before the first frame update  

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame     

    //alt der kører i spillet, bevægelse, skydning, skal ligge i Update()
    void Update()
    {
        Move(); //bevægelse med awsd uden rotation
        Jump();
        Rotate(); //rotation
    }

    void Move()
    {
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
    }

    void Rotate()
    {
        if (Input.GetKey("d"))
        {
            y = y + 0.05f;
        }
        if (Input.GetKey("a"))
        {
            y = y - 0.05f;
        }

        if (Input.GetKey("w"))
        {
            x = x + 0.05f;
        }
        if (Input.GetKey("s"))
        {
            x = x - 0.05f;
        }

        transform.Rotate(0, y, 0);
    }

    /*   void OnCollisionEnter(Collision collision)
       {
           x = 0f;
           transform.Rotate(x, y, 0);
       }
   */
    void Jump()
    {
        if (limit > 60) //denne grænse bestemmer hvor meget man kan hoppe
        {
            return;
        }
        if (Input.GetKey(KeyCode.Space)) //når der trykkes på mellemrum hoppes der
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            //limit++;
        }
    }
}
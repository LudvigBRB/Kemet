using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_level : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    float y = 0f;

    private Vector3 target = new Vector3(5.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        RiseAndFall();
    }

    void Move()
    {
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        //transform.Translate(Vector3.up * moveSpeed);
        //transform.Translate(0f, 1f * moveSpeed, 0f);
    }

    void RiseAndFall()
    {
        if (Input.GetKey("r"))
        {
            y = y + 10f;
        }
        if (Input.GetKey("f"))
        {
            y = y - 10f;
        }
    }
}

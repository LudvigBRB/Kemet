using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water_level : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    float y = 0f;
    public GameObject Water ;
    private Vector3 waterVector1 = new Vector3(0.0f, 5.0f, 0.0f);
    private Vector3 waterVector2 = new Vector3(0.0f, -5.0f, 0.0f);
    private float waterSpeed = 20f;
    private float timer = 0f;
    public TextMesh timertext;

    // Start is called before the first frame update
    void Start()
    {


    }



    void Move()
    {
    //    transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        //transform.Translate(Vector3.up * moveSpeed);
        //transform.Translate(0f, 1f * moveSpeed, 0f);
    }

    public void Flow()
    {

        transform.Translate(waterVector1);
        
    }
    public void Eb()
    {

        transform.Translate(waterVector2);
    }
    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        
        if (Mathf.Approximately(timer,3))
        {
            Flow();
        }
        if (Mathf.Approximately(timer, 6))
        {
            Eb();
            timer = 0f;
        }
        timertext.text = timer.ToString();

    }
}

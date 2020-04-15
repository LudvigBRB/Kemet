using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//testing
public class Water_level : MonoBehaviour
{

    //[SerializeField] float moveSpeed = 10f;

    //float y = 0f;
    public GameObject Water;
    private Vector3 waterVector1 = new Vector3(0.0f, 5.0f, 0.0f); //higehst position of the water
    private Vector3 waterVector2 = new Vector3(0.0f, -5.0f, 0.0f); //lowest position of the water
    //private float waterSpeed = 20f;
    private float timer = 0f;
    public TextMesh timertext;

    void Move()
    {
        //    transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        //transform.Translate(Vector3.up * moveSpeed);
        //transform.Translate(0f, 1f * moveSpeed, 0f);
    }

    public void Flow() //transforms water height to low
    {

        transform.Translate(waterVector1);

    }
    public void Eb() //transforms water height to high
    {

        transform.Translate(waterVector2);
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime; //counts time since last frame

        if (Mathf.Approximately(timer, 3)) //after 3 frames, place water at lowest position
        {
            Flow();
        }
        if (Mathf.Approximately(timer, 6)) //after another 3 frames, place water at highest position
        {
            Eb();
            timer = 0f; //reset timer to 0
        }
        timertext.text = timer.ToString(); //write text

    }
}

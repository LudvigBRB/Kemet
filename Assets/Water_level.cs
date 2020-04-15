using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Water_level : MonoBehaviour
{

    public GameObject Water;
    private float timer = 0f;
    public TextMesh timertext;
    private float waterspeed = 5f;
    public Vector3 waterPosition;
    private bool waterUpDown = false;
    private float y1 = 0.01f;
    private float y2 = -0.01f;


    void Start()
    {
        timer = Time.deltaTime;

    }




    private void FixedUpdate()
    {




        if (timer >= 10)
            waterUpDown = true;
        if (timer <= 0)
            waterUpDown = false;

        if (waterUpDown == false)
        {
            timer += Time.deltaTime;
            transform.Translate(new Vector3(0.0f, y1, 0.0f));
        }
        else
        {
            timer -= Time.deltaTime;
            transform.Translate(new Vector3(0.0f, y2, 0.0f));
        }

        timertext.text = timer.ToString();



        //    transform.Translate(new Vector3(0.0f, y, 0.0f));

        //   GameObject.Find("Water").transform.position = waterPosition;



    }
}

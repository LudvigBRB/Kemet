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
    //private float waterspeed = 5f;
    public Vector3 waterPosition;
    private bool waterUpDown = false;
    private float y1 = 0.0013f;
    private float y2 = -0.0013f;

    public GameObject[] plants;
    public GameObject[] saplings;
    public GameObject[] wheats;


    void Start()
    {
        timer = Time.deltaTime;

    }

    void Calender()
    {
        if (timer >= 65) // 85:y1 = 0.001f;
        {
            //Debug.Log("det sker");
            plants = GameObject.FindGameObjectsWithTag("plant");
            saplings = GameObject.FindGameObjectsWithTag("sapling");
            wheats = GameObject.FindGameObjectsWithTag("wheat");

            foreach (GameObject plant in plants)
            {
                Destroy(plant);
            }
            foreach (GameObject sapling in saplings)
            {
                Destroy(sapling);
            }

            foreach (GameObject wheat in wheats)
            {
                Destroy(wheat);
            }

        }
    }

    private void FixedUpdate()
    {
        if (timer >= 100)
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

    void Update()
    {
        Calender();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthController : MonoBehaviour
{

    public GameObject plant;

    private float timer = 0f;
    private float oldTimer = 0f;

    float y = 0f;

    private Vector3 waterVector1 = new Vector3(0.0f, 5.0f, 0.0f); //higehst position of the water
    private Vector3 waterVector2 = new Vector3(0.0f, -5.0f, 0.0f);

    private Vector3 plantVector = new Vector3(0.0f, 0.0f, 0.0f);

    void GrowPlant()
    {
        while (y < 30f)
        {
            timer += Time.deltaTime;
            int n = 0;

            n++;

            //if (timer % 3 == 0)
            //{
            y = y + 5f;
            transform.Translate(new Vector3(0.0f, y, 0.0f));
            //}
        }
    }

    IEnumerator GrowPlantNew()
    {
        while (y < 3f)
        {
            yield return new WaitForSeconds(2f);
            y = y + 1f;
            Debug.Log(y);
            transform.Translate(new Vector3(0.0f, y, 0.0f));
        }

    }

    void Update()
    {
        //GrowPlant();
        GrowPlantNew();
    }

    void Start()
    {
        //StartCoroutine("GrowPlantNew");
    }

    /*
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
            //timertext.text = timer.ToString(); //write text

        }

        public void Flow() //transforms water height to low
        {

            transform.Translate(waterVector1);

        }
        public void Eb() //transforms water height to high
        {

            transform.Translate(waterVector2);
        }*/
}

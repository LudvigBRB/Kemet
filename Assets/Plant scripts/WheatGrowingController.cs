using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatGrowingController : MonoBehaviour
{

    public GameObject plant;

    float y = 0f;

    public float growthSpeed;

    public float height;

    public float jump; //can't be less than 0.1???

    bool start = true;

    public IEnumerator GrowWheatNew()
    {
        plant.tag = "sapling";
        while (y < height)
        {
            yield return new WaitForSeconds(growthSpeed);
            y = y + jump;
            //Debug.Log(y);
            transform.Translate(new Vector3(0.0f, y, 0.0f));
        }
        if (y == height)
        {
            plant.tag = "wheat"; //Debug.Log("her?");
        }
    }

    public void StartGrowth()
    {
        StartCoroutine("GrowWheatNew");
    }

    void Update()
    {
        if (start)
        {
            StartGrowth();
            start = false;
        }
        GrowWheatNew();
    }
}

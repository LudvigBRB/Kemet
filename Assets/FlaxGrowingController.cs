﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaxGrowingController : MonoBehaviour
{

    public GameObject plant;

    float y = 0f;

    public float growthSpeed;

    //int n = 0;

    bool start = true;

    public IEnumerator GrowFlaxNew()
    {
        plant.tag = "sapling";
        while (y < 1f)
        {
            yield return new WaitForSeconds(growthSpeed);
            y = y + 0.2f;
            //Debug.Log(y);
            transform.Translate(new Vector3(0.0f, y, 0.0f));
        }
        if (y == 1f)
        {
            plant.tag = "plant"; //Debug.Log("her?");
        }
    }

    public void StartGrowth()
    {
        StartCoroutine("GrowFlaxNew");
    }

    void Update()
    {
        if (start)
        {
            StartGrowth();
            start = false;
        }
        GrowFlaxNew();
    }
}

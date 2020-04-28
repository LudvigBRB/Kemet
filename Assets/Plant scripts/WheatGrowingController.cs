using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatGrowingController : MonoBehaviour
{

    public GameObject plant;

    float y = 0f;

    public float growthSpeed;

    bool start = true;

    public IEnumerator GrowWheatNew()
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

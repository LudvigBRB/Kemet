using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthController : MonoBehaviour
{

    public GameObject plant;

    float y = 0f;

    float growthSpeed = 1f;

    int n = 0;

    bool start = true;

    public IEnumerator GrowPlantNew()
    {
        plant.tag = "sapling";
        while (y < 3f)
        {
            yield return new WaitForSeconds(growthSpeed);
            y = y + 1f;
            //Debug.Log(y);
            transform.Translate(new Vector3(0.0f, y, 0.0f));
        }
        if (y == 3f)
        {
            plant.tag = "plant"; //Debug.Log("her?");
        }
    }

    public void StartGrowth()
    {
        StartCoroutine("GrowPlantNew");
    }

    void Update()
    {
        if (start)
        {
            StartGrowth();
            start = false;
        }
        GrowPlantNew();
    }
}

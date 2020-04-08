using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthController : MonoBehaviour
{

    public GameObject plant;
    private float timer = 0f;
    private float oldTimer = 0f;

    float y = 0f;

    bool start = true;

    public IEnumerator GrowPlantNew()
    {
        while (y < 3f)
        {
            yield return new WaitForSeconds(1f);
            y = y + 1f;
            Debug.Log(y);
            transform.Translate(new Vector3(0.0f, y, 0.0f));
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

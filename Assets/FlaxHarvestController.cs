using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FlaxHarvestController : MonoBehaviour
{

    public ThingController controller;

    void HarvestFlax()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 placement = Input.mousePosition;

            //UnityEngine.Debug.Log("snart");

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                //UnityEngine.Debug.Log("hvornår");
                if (hit.collider.gameObject.tag == "plant")
                {
                    //UnityEngine.Debug.Log("efter");
                    Destroy(hit.collider.gameObject);
                    controller.HarvestFlaxCrop();
                }
                if (hit.collider.gameObject.tag == "sapling")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        HarvestFlax();
    }
}
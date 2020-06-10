using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaxyHarvyController : MonoBehaviour
{

    public ThingController controller;

    // Start is called before the first frame update
    void HarvestFlax()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 placement = Input.mousePosition;

            //Debug.Log("snart");

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                //Debug.Log("hvornår");
                if (hit.collider.gameObject.tag == "plant")
                {
                    //Debug.Log("efter");
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
        //Debug.Log("enden");
        HarvestFlax();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatHarvestController : MonoBehaviour
{
    //public Inventory textMa;
    public ThingController controller;

    void HarvestWheat()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 placement = Input.mousePosition;

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "wheat")
                {
                    Destroy(hit.collider.gameObject);
                    controller.HarvestWheatCrop();
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
        HarvestWheat();
    }
}

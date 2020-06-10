using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernController : MonoBehaviour
{

    //public Inventory textMa;
    public ThingController controller;

    void SellBeer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "tavern")
                {
                    //textMa.CropSell();
                    controller.BeerSell();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        SellBeer();
    }
}
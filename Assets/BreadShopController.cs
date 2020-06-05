using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadShopController : MonoBehaviour
{

    //public Inventory textMa;
    public ThingController controller;

    void SellBread()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "bread_shop")
                {
                    //textMa.CropSell();
                    controller.BreadSell();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        SellBread();
    }
}

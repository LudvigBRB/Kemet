using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatSeedDispenser : MonoBehaviour
{

    //public Inventory textMa;

    public ThingController controller;

    void RequestSeed()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "dispenser")
                {
                    //if (textMa.ReturnCobberNumb() > 0)
                    if (controller.ReturnCobberNumb() > 0)
                    {
                        //textMa.GiveSeed();
                        //textMa.TakeCobber();
                        controller.GiveWheatSeed();
                        controller.TakeCobber();
                    }

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        RequestSeed();
    }
}

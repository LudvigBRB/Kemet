using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrewingController : MonoBehaviour
{

    public ThingController controller;

    // Start is called before the first frame update
    void BrewBeer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "jar")
                {
                    controller.MakeBeer();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        BrewBeer();
    }
}
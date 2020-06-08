using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaxHarvestControl : MonoBehaviour
{
    //public Inventory textMa;
    public ThingController controller;

    void Harvest()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 placement = Input.mousePosition;

<<<<<<< HEAD
            //UnityEngine.Debug.Log("snart");

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                //UnityEngine.Debug.Log("hvornår");
                if (hit.collider.gameObject.tag == "plant")
                {
                    //UnityEngine.Debug.Log("efter");
=======
            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "plant")
                {
>>>>>>> parent of fed7fe8... hopefully fixing a unity bug
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
        Harvest();
    }
}

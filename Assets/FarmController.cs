﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmController : MonoBehaviour
{

    public Inventory textMa;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Clicker()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "dirt")
                {
                    textMa.PlantSeed();
                    //textMa.PlantCrop();
                }
                //Debug.Log("klikkede på sædgiverern");
                //new WaitForSeconds(2);
                //Debug.Log("");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Clicker();
    }
}

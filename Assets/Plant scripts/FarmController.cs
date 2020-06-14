using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmController : MonoBehaviour
{

    //public Inventory textMa;
    public ThingController controller;
    public GameObject flax;
    public GameObject wheat;

    string type = "e";

    void PlantFlax(Vector3 position)
    {
        Vector3 point = new Vector3();
        Vector2 mousePos = new Vector2();
        mousePos.y = Camera.main.pixelHeight - position.y;

        point = Camera.main.ScreenToWorldPoint(new Vector3(position.x, mousePos.y - 100, Camera.main.nearClipPlane)); //change the height at which the plant appears at Camera.main.nearClipPlane
        //Debug.Log(point);
        Instantiate(flax, point, Quaternion.identity);
    }

    void PlantWheat(Vector3 position)
    {
        Vector3 point = new Vector3();
        Vector2 mousePos = new Vector2();
        mousePos.y = Camera.main.pixelHeight - position.y;

        point = Camera.main.ScreenToWorldPoint(new Vector3(position.x, mousePos.y - 500, Camera.main.nearClipPlane + 8)); //change the height at which the plant appears at mousePos.y - x
        //Debug.Log(point);
        Instantiate(wheat, point, Quaternion.identity);
    }

    void Clicker()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 placement = Input.mousePosition;

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "dirt")
                {
                    if (type == "e")
                    {
                        if (controller.ReturnFlaxSeedNumb() != 0)
                        {
                            PlantFlax(placement);
                        }
                        controller.PlantFlaxSeed();
                    }
                    if (type == "r")
                    {
                        if (controller.ReturnWheatSeedNumb() != 0)
                        {
                            PlantWheat(placement);
                        }
                        controller.PlantWheatSeed();
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            type = "e";
        }
        if (Input.GetKey("r"))
        {
            type = "r";
        }

        Clicker();
    }
}

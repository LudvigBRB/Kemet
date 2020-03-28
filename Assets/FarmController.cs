using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmController : MonoBehaviour
{

    public Inventory textMa;
    public GameObject cylinder;

    // Start is called before the first frame update

    void PlantCrop(Vector3 position)
    {
        Vector3 point = new Vector3();
        Vector2 mousePos = new Vector2();
        mousePos.y = Camera.main.pixelHeight - position.y;

        point = Camera.main.ScreenToWorldPoint(new Vector3(position.x, mousePos.y, Camera.main.nearClipPlane + 5));
        Debug.Log(point);
        Instantiate(cylinder, point, Quaternion.identity);
    }

    void Clicker()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; // : RaycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 placement = Input.mousePosition;
            //Debug.Log(placement);

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "dirt")
                {
                    textMa.PlantSeed();

                    if (textMa.ReturnSeedNumb() > 0)
                    {
                        PlantCrop(placement);
                    }
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Clicker();
    }
}

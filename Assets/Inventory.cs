using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    enum ItemTypes { Seed, Crop };
    int[] items = new int[2]; //array

    public Text seedText;
    public Text seedInfoText;
    public Text cropText;
    public Text cropInfoText;

    public void GiveSeed()
    {
        ++items[(int)ItemTypes.Seed];
    }

    public void PlantSeed()
    {
        --items[(int)ItemTypes.Seed];
    }

    void SeedControl()
    {
        if (Input.GetKey("y"))
        {
            ++items[(int)ItemTypes.Seed];
        }
        if (Input.GetKey("h") && items[(int)ItemTypes.Seed] != 0)
        {
            --items[(int)ItemTypes.Seed];
        }
    }

    void CropControl()
    {
        if (Input.GetKey("u"))
        {
            ++items[(int)ItemTypes.Crop];
        }
        if (Input.GetKey("j") && items[(int)ItemTypes.Crop] != 0)
        {
            --items[(int)ItemTypes.Crop];
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        items[(int)ItemTypes.Seed] = 4;
        items[(int)ItemTypes.Crop] = 0;

        seedInfoText.text = "Number of seeds";
        cropInfoText.text = "Number of crops";
    }

    // Update is called once per frame
    void Update()
    {
        SeedControl();
        seedInfoText.text.ToString();
        seedText.text = items[(int)ItemTypes.Seed].ToString();

        CropControl();
        cropInfoText.text.ToString();
        cropText.text = items[(int)ItemTypes.Crop].ToString();
    }
}

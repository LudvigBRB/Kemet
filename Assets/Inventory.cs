using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    enum ItemTypes { Seed, Crop, Cobber };
    int[] items = new int[3]; //array

    public Text seedText;
    public Text seedInfoText;
    public Text cropText;
    public Text cropInfoText;
    public Text cobberText;
    public Text cobberInfoText;

    public void GiveCobber()
    {
        ++items[(int)ItemTypes.Cobber];
    }

    public void GiveSeed()
    {
        ++items[(int)ItemTypes.Seed];
    }

    public void PlantSeed()
    {
        if (items[(int)ItemTypes.Seed] != 0)
        {
            --items[(int)ItemTypes.Seed];
        }
    }

    public void PlantCrop()
    {
        if (items[(int)ItemTypes.Seed] > -1)
        {
            ++items[(int)ItemTypes.Crop];
        }
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

    public void CropSell()
    {
        if (items[(int)ItemTypes.Crop] != 0)
        {
            --items[(int)ItemTypes.Crop];
            GiveCobber();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        items[(int)ItemTypes.Seed] = 4;
        items[(int)ItemTypes.Crop] = 0;

        seedInfoText.text = "Number of seeds";
        cropInfoText.text = "Number of crops";
        cobberInfoText.text = "Number of cobber pieces";
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

        cobberInfoText.ToString();
        cobberText.text = items[(int)ItemTypes.Cobber].ToString();
    }
}

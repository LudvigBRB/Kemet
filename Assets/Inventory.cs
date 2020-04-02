using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public ThingController controller;

    public Text seedText;
    public Text seedInfoText;
    public Text cropText;
    public Text cropInfoText;
    public Text cobberText;
    public Text cobberInfoText;


    // Start is called before the first frame update
    void Start()
    {
        controller.SetSeed(4);
        controller.SetCrops(0);

        seedInfoText.text = "Number of seeds";
        cropInfoText.text = "Number of crops";
        cobberInfoText.text = "Number of cobber pieces";
    }

    // Update is called once per frame
    void Update()
    {
        controller.SeedControl();
        seedInfoText.text.ToString();
        seedText.text = controller.ReturnSeedNumb().ToString();

        controller.CropControl();
        cropInfoText.text.ToString();
        cropText.text = controller.ReturnCropNumb().ToString();

        cobberInfoText.ToString();
        cobberText.text = controller.ReturnCobberNumb().ToString();
    }
}

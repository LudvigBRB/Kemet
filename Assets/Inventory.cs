using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public ThingController controller;

    public Text flaxSeedText;
    public Text flaxSeedInfoText;
    public Text flaxCropText;
    public Text flaxCropInfoText;
    public Text wheatSeedText;
    public Text wheatSeedInfoText;
    public Text wheatCropText;
    public Text wheatCropInfoText;
    public Text cobberText;
    public Text cobberInfoText;


    // Start is called before the first frame update
    void Start()
    {
        controller.SetSeeds(4, 3);
        controller.SetWheatCrops(0);

        flaxSeedInfoText.text = "Number of flax seeds";
        wheatSeedInfoText.text = "Number of wheat seeds";
        flaxCropInfoText.text = "Number of flax crops";
        wheatCropInfoText.text = "Number of wheat crops";
        cobberInfoText.text = "Number of cobber pieces";
    }

    // Update is called once per frame
    void Update()
    {
        controller.SeedControl();

        flaxSeedInfoText.text.ToString();
        flaxSeedText.text = controller.ReturnFlaxSeedNumb().ToString();

        wheatSeedInfoText.text.ToString();
        wheatSeedText.text = controller.ReturnWheatSeedNumb().ToString();

        controller.CropControl();

        flaxCropInfoText.text.ToString();
        flaxCropText.text = controller.ReturnFlaxCropNumb().ToString();

        controller.CropControl();

        wheatCropInfoText.text.ToString();
        wheatCropText.text = controller.ReturnWheatCropNumb().ToString();

        cobberInfoText.ToString();
        cobberText.text = controller.ReturnCobberNumb().ToString();
    }
}

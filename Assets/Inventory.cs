using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    enum ItemTypes { Seed, Crop };
    int[] items = new int[2]; //array

    public Text myText;

    void GiveSeed()
    {
        ++items[(int)ItemTypes.Seed];
    }

    void TakeSeed()
    {
        --items[(int)ItemTypes.Seed];
    }

    // Start is called before the first frame update
    void Start()
    {
        items[(int)ItemTypes.Seed] = 4;
        items[(int)ItemTypes.Crop] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = items[(int)ItemTypes.Seed].ToString();
    }
}

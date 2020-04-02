using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingController : MonoBehaviour
{
    enum ItemTypes { Seed, Crop, Cobber };
    int[] items = new int[3]; //array

    //seed methods
    public void SetSeed(int seeds)
    {
        items[(int)ItemTypes.Seed] = seeds;
    }
    public void GiveSeed()
    {
        ++items[(int)ItemTypes.Seed];
    }

    public int ReturnSeedNumb()
    {
        return items[(int)ItemTypes.Seed];
    }

    public void PlantSeed()
    {
        if (items[(int)ItemTypes.Seed] > 0)
        {
            --items[(int)ItemTypes.Seed];
        }
    }

    //crop methods
    public void SetCrops(int crops)
    {
        items[(int)ItemTypes.Crop] = crops;
    }

    public int ReturnCropNumb()
    {
        return items[(int)ItemTypes.Crop];
    }


    public void HarvestCrop()
    {
        ++items[(int)ItemTypes.Crop];
    }

    public void CropSell()
    {
        if (items[(int)ItemTypes.Crop] != 0)
        {
            --items[(int)ItemTypes.Crop];
            GiveCobber();
        }
    }

    //cobber methods
    public void GiveCobber()
    {
        ++items[(int)ItemTypes.Cobber];
    }

    public void TakeCobber()
    {
        --items[(int)ItemTypes.Cobber];
    }

    public int ReturnCobberNumb()
    {
        return items[(int)ItemTypes.Cobber];
    }

    //other methods  
    public void SeedControl()
    {
        if (Input.GetKey("y"))
        {
            ++items[(int)ItemTypes.Seed];
        }
        if (Input.GetKey("h") && items[(int)ItemTypes.Seed] > -1)
        {
            --items[(int)ItemTypes.Seed];
        }
    }

    public void CropControl()
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingController : MonoBehaviour
{
    enum ItemTypes { Flax, Wheat, FlaxCrop, WheatCrop, Cobber };
    int[] items = new int[5]; //array

    public void SetSeeds(int flaxSeeds, int wheatSeeds)
    {
        items[(int)ItemTypes.Flax] = flaxSeeds;
        items[(int)ItemTypes.Wheat] = wheatSeeds;
    }

    //flax seed methods
    public void GiveFlaxSeed()
    {
        ++items[(int)ItemTypes.Flax];
    }

    public int ReturnFlaxSeedNumb()
    {
        return items[(int)ItemTypes.Flax];
    }

    public void PlantFlaxSeed()
    {
        if (items[(int)ItemTypes.Flax] > 0)
        {
            --items[(int)ItemTypes.Flax];
        }
    }

    //Flax crop methods
    public void SetFlaxCrops(int flaxCrops)
    {
        items[(int)ItemTypes.FlaxCrop] = flaxCrops;
    }

    public int ReturnFlaxCropNumb()
    {
        return items[(int)ItemTypes.FlaxCrop];
    }

    public void HarvestFlaxCrop()
    {
        Debug.Log("nu");
        ++items[(int)ItemTypes.FlaxCrop];
    }

    public void FlaxCropSell()
    {
        if (items[(int)ItemTypes.FlaxCrop] != 0)
        {
            --items[(int)ItemTypes.FlaxCrop];
            GiveCobber();
            GiveCobber();
        }
    }


    //wheat methods 
    public void GiveWheatSeed()
    {
        ++items[(int)ItemTypes.Wheat];
    }
    public int ReturnWheatSeedNumb()
    {
        return items[(int)ItemTypes.Wheat];
    }

    public void PlantWheatSeed()
    {
        if (items[(int)ItemTypes.Wheat] > 0)
        {
            --items[(int)ItemTypes.Wheat];
        }
    }

    //Wheat crop methods
    public void SetWheatCrops(int wheatCrops)
    {
        items[(int)ItemTypes.WheatCrop] = wheatCrops;
    }

    public int ReturnWheatCropNumb()
    {
        return items[(int)ItemTypes.WheatCrop];
    }


    public void HarvestWheatCrop()
    {
        ++items[(int)ItemTypes.WheatCrop];
    }

    public void WheatCropSell()
    {
        if (items[(int)ItemTypes.WheatCrop] != 0)
        {
            --items[(int)ItemTypes.WheatCrop];
            GiveCobber();
            // GiveCobber();
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
            ++items[(int)ItemTypes.Flax];
        }
        if (Input.GetKey("h") && items[(int)ItemTypes.Flax] > -1)
        {
            --items[(int)ItemTypes.Flax];
        }
    }

    public void CropControl()
    {
        if (Input.GetKey("u"))
        {
            ++items[(int)ItemTypes.FlaxCrop];
        }
        if (Input.GetKey("j") && items[(int)ItemTypes.FlaxCrop] != 0)
        {
            --items[(int)ItemTypes.FlaxCrop];
        }
    }
}

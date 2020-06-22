using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingController : MonoBehaviour
{
    enum ItemTypes { Flax, Wheat, FlaxCrop, WheatCrop, Thread, Textile, Beer, Bread, Cobber };
    int[] items = new int[9]; //array

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
        ++items[(int)ItemTypes.FlaxCrop];
    }

    public void FlaxCropSell()
    {
        if (items[(int)ItemTypes.FlaxCrop] != 0)
        {
            --items[(int)ItemTypes.FlaxCrop];
            GiveCobber();
            //GiveCobber();
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

    public void GiveCobberNumb(int n)
    {
        for (int i = 0; i < n; i++)
        {
            ++items[(int)ItemTypes.Cobber];
        }

    }

    //thread methods

    public void GiveThread()
    {
        ++items[(int)ItemTypes.Thread];
    }

    public void MakeThread()
    {
        if (items[(int)ItemTypes.FlaxCrop] >= 4)
        {
            --items[(int)ItemTypes.FlaxCrop];
            --items[(int)ItemTypes.FlaxCrop];
            --items[(int)ItemTypes.FlaxCrop];
            --items[(int)ItemTypes.FlaxCrop];

            GiveThread();
        }
    }

    public int returnThreadAmount()
    {
        return items[(int)ItemTypes.Thread];
    }

    //Textile methods
    public void GiveTextile()
    {
        ++items[(int)ItemTypes.Textile];
    }

    public void MakeTextile()
    {
        if (items[(int)ItemTypes.Thread] >= 9)
        {
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];
            --items[(int)ItemTypes.Thread];

            GiveTextile();
        }
    }

    public int returnTextileAmount()
    {
        return items[(int)ItemTypes.Textile];
    }

    public void TextileSell()
    {
        if (items[(int)ItemTypes.Textile] != 0)
        {
            --items[(int)ItemTypes.Textile];
            GiveCobberNumb(40);
        }
    }

    //Beer methods
    public void GiveBeer()
    {
        ++items[(int)ItemTypes.Beer];
    }

    public void MakeBeer()
    {
        if (items[(int)ItemTypes.WheatCrop] >= 2)
        {
            --items[(int)ItemTypes.WheatCrop];
            --items[(int)ItemTypes.WheatCrop];

            GiveBeer();
        }
    }

    public void BeerSell()
    {
        if (items[(int)ItemTypes.Beer] != 0)
        {
            --items[(int)ItemTypes.Beer];
            GiveCobber();
            GiveCobber();
            //GiveCobber();
        }
    }

    public int ReturnBeerAmount()
    {
        return items[(int)ItemTypes.Beer];
    }

    //Bread methods
    public void GiveBread()
    {
        ++items[(int)ItemTypes.Bread];
    }

    public void MakeBread()
    {
        if (items[(int)ItemTypes.WheatCrop] >= 3)
        {
            --items[(int)ItemTypes.WheatCrop];
            --items[(int)ItemTypes.WheatCrop];
            --items[(int)ItemTypes.WheatCrop];
            GiveBread();
        }
    }

    public void BreadSell()
    {
        if (items[(int)ItemTypes.Bread] != 0)
        {
            --items[(int)ItemTypes.Bread];
            GiveCobber();
            GiveCobber();
            GiveCobber();
            //GiveCobber();
        }
    }

    public int ReturnBreadAmount()
    {
        return items[(int)ItemTypes.Bread];
    }

    //other methods  
    public void SeedControl()
    {
        if (Input.GetKey("y"))
        {
            ++items[(int)ItemTypes.Flax];
            ++items[(int)ItemTypes.Wheat];
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
            ++items[(int)ItemTypes.WheatCrop];
        }
        if (Input.GetKey("j") && items[(int)ItemTypes.FlaxCrop] != 0)
        {
            --items[(int)ItemTypes.FlaxCrop];
        }
    }

    public void ThreadControl()
    {
        if (Input.GetKey("t"))
        {
            ++items[(int)ItemTypes.Thread];
        }
    }
}

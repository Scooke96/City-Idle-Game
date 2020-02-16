using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Population_Control : MonoBehaviour
{
    public GameObject parentObject, resourceController, buildspotController;
    public Text textBox;

    private void Update()
    {
        resourceController = GameObject.FindGameObjectWithTag("RC");
        buildspotController = GameObject.FindGameObjectWithTag("BC");
        Mine_Control MC = resourceController.GetComponent<Mine_Control>();
        BuildSpot_Controller BC = buildspotController.GetComponent<BuildSpot_Controller>();
        textBox = GameObject.Find(BC.textBoxIdentifier).GetComponent<Text>();
        textBox.text = MC.mine1Workers.ToString() + "/" + Mine_Control.mine1MaxWorkers;
    }

    public void OnMouseUpAsButton()
    {
        
        Mine_Control MC = resourceController.GetComponent<Mine_Control>();
        Generator_Control GC = resourceController.GetComponent<Generator_Control>();
        Shop_Control SC = resourceController.GetComponent<Shop_Control>();

        if (this.gameObject.name == "AddSquare" && Resources_Control.currentPopulation >= 1)
        {
            if (parentObject.name == "Mine 1(Clone)" && MC.mine1Workers < Mine_Control.mine1MaxWorkers)
            {
                Resources_Control.currentPopulation -= 1;
                MC.mine1Workers += 1;
            }
            else if (parentObject.name == "Gen 1(Clone)")
            {
                Resources_Control.currentPopulation -= 1;
                GC.gen1Workers += 1;
            }
            else if (parentObject.name == "Shop 1(Clone)")
            {
                Resources_Control.currentPopulation -= 1;
                SC.shop1Workers += 1;
            }
        }
        else if (this.gameObject.name == "MinusSquare" && Resources_Control.currentPopulation <= Resources_Control.maxPopulation - 1)
        {
            if (parentObject.name == "Mine 1(Clone)")
            {
                Resources_Control.currentPopulation += 1;
                MC.mine1Workers -= 1;
                
            }
            else if (parentObject.name == "Gen 1(Clone)")
            {
                Resources_Control.currentPopulation += 1;
                GC.gen1Workers -= 1;
            }
            else if (parentObject.name == "Shop 1(Clone)")
            {
                Resources_Control.currentPopulation += 1;
                SC.shop1Workers -= 1;
            }
        }

    }
}

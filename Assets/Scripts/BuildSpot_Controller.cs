using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildSpot_Controller : MonoBehaviour 
{
	public GameObject[] buildings;
    public Text textbox;
    public SpriteRenderer spriteRenderer;

    public string textBoxIdentifier;

    public static int buildingSelection;
    public static int buildingCost;

    public bool active = true;

	void OnMouseUpAsButton()
	{
		if (Resources_Control.money >= buildingCost && active) 
		{	
			GameObject g = (GameObject)Instantiate (buildings [buildingSelection]);
			g.transform.position = transform.position + new Vector3 (0, 0, -0.1f);

			Resources_Control.money -= buildingCost;
            if (buildingSelection == 0)
            {
                Shop_Control.shop1Amount += 1;
            }
            else if (buildingSelection == 1)
            {
                Generator_Control.gen1Amount += 1;
            }
            else if (buildingSelection == 2)
            {
                Mine_Control.mine1Amount += 1;
                Mine_Control.mine1MaxWorkers += 5;
                textbox.gameObject.SetActive(true);
            }
            else if (buildingSelection == 3)
            {
                Resources_Control.maxPopulation += 5;
                Resources_Control.currentPopulation += 5;
            }

            textBoxIdentifier = textbox.name;
            spriteRenderer.enabled = false;
            active = false;
		}
	}
    public void BuildingSelection(int selectedBuilding)
    {
        buildingSelection = selectedBuilding;
    }
    public void BuildingCost(int selectedBuildingCost)
    {
        buildingCost = selectedBuildingCost;
    }
    
    
} 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopITemSelector : MonoBehaviour
{
    public TextMeshProUGUI descriptionTxt;

    public GridLayoutGroup gridLayoutGroup;
    private GameObject selectedItemButton;
    private int selectedi;

    public void OnPurchaseButtonClick()
    {

        // Use the selectedIndex to purchase the selected item
        if (selectedi != -1)
        {
            Debug.Log("Purchased item at index " + selectedi);
        }
        else
        {
            Debug.Log("No item selected!");
        }
    }

    public void OnItemButtonSelected()
    {
        selectedItemButton = EventSystem.current.currentSelectedGameObject;

        // Get the index of the selected item button in the grid
        selectedi = -1;
        for (int i = 0; i < gridLayoutGroup.transform.childCount; i++)
        {
            GameObject itemButton = gridLayoutGroup.transform.GetChild(i).gameObject;
            if (itemButton == selectedItemButton)
            {
                selectedi = i;
                break;
            }
        }
    }

    public void O1U()
    {
        Debug.Log("You have clicked up");
        descriptionTxt.text = "A Basic Offense item, forward direction, every 5 seconds";
        OnItemButtonSelected();
    }

    public void O1D()
    {
        Debug.Log("You have clicked down");
        descriptionTxt.text = "A Basic Offense item, backward direction, every 5 seconds";
        OnItemButtonSelected();
    }

    public void O1L()
    {
        Debug.Log("You have clicked left");
        descriptionTxt.text = "A Basic Offense item, left direction, every 5 seconds";
        OnItemButtonSelected();
    }

    public void O1R()
    {
        Debug.Log("You have clicked right");
        descriptionTxt.text = "A Basic Offense item, right direction, every 5 seconds";
        OnItemButtonSelected();
    }


    public void D1U()
    {
        Debug.Log("You have clicked up");
        descriptionTxt.text = "A Basic Defense item, forward direction, 1 hit max";
    }

    public void D1D()
    {
        Debug.Log("You have clicked down");
        descriptionTxt.text = "A Basic Defense item, backward direction, 1 hit max";
    }

    public void D1L()
    {
        Debug.Log("You have clicked left");
        descriptionTxt.text = "A Basic Defense item, left direction, 1 hit max";
    }

    public void D1R()
    {
        Debug.Log("You have clicked right");
        descriptionTxt.text = "A Basic Defense item, right direction, 1 hit max";
    }
}

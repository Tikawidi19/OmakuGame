using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class craftingscore : MonoBehaviour
{
    private item currentItem;
    public Image CustomCurson;

    public slot[] craftingSlots;

    public List<item> itemList;
    public string[] recipes;
    public item[] recipeResults;
    public slot resultSlot;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (currentItem != null)
            {
                CustomCurson.gameObject.SetActive(false);
                slot neareSlot = null;
                float shortestDistance = float.MaxValue;

                foreach (slot slot in craftingSlots)
                {
                    float dist = Vector2.Distance(Input.mousePosition, slot.transform.position);
                    if (dist < shortestDistance)
                    {
                        shortestDistance = dist;
                        neareSlot = slot;
                    }
                }
                neareSlot.gameObject.SetActive(true);
                neareSlot.GetComponent<Image>().sprite = currentItem.GetComponent<Image>().sprite;
                neareSlot.item = currentItem;
                itemList[neareSlot.index] = currentItem;

                currentItem = null;

                CheckForCreatedRecipes();
            }
        }
    }
    public void OnMouseDown(item item)
    {
        if (currentItem == null)
        {
            currentItem = item;
            CustomCurson.gameObject.SetActive(true);
            CustomCurson.sprite = currentItem.GetComponent<Image>().sprite;
            Debug.Log("craff");
        }
    }
    private void CheckForCreatedRecipes()
    {
        resultSlot.gameObject.SetActive(false);
        resultSlot.item = null;


        string currentRecipeString = "";
        foreach (item item in itemList)
        {
            if (item != null)
            {
                currentRecipeString += item.itemname;


            }
            else
            {
                currentRecipeString += null;
            }
        }

        for (int i = 0; i < recipes.Length; i++)
        {
            if (recipes[i] == currentRecipeString)
            {
                if (recipes[i] == currentRecipeString)
                {
                    resultSlot.gameObject.SetActive(true);
                    resultSlot.GetComponent<Image>().sprite = recipeResults[i].GetComponent<Image>().sprite;
                    resultSlot.item = recipeResults[i];

                }
            }
        }
        //itemList.Add(recipes); //AddItem(recipes.craftedItem);

    }

    public void OnClickSlot(slot Slot)
    {
        Slot.item = null;
        itemList[Slot.index] = null;
        Slot.gameObject.SetActive(false);
        CheckForCreatedRecipes();

    }
}

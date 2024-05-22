using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using TMPro;

public class jamu : MonoBehaviour
{
    private slot currentSlot;
    public Image CustomCurson;
    private item currentItem;
    //public custom custom;
    //public slot slot;

   public List<slot> slotList;
    public List<item> itemList;
    public slot[] craftingSlots;
    public slot resultSRS;
    ////public item item;
    public string[] recipes;
    public item[] recipeResuls;
    //public score score;
    public TMP_Text TextScore;
    public int intscore;
    int score;
    TMP_Text finalscore;
    //public object recipeResult { get; private set; }

    //public item[] custom.image;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (currentSlot != null)
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
                neareSlot.GetComponent<Image>().sprite = currentSlot.GetComponent<Image>().sprite;
                //neareSlot.Slot = currentSlot;
                //slotList[neareSlot.index] = currentSlot;

                currentSlot = null;

                Crafting();

            }
        }
    }
    public void OnMouseDown(slot item)
    {
        if (currentSlot == null)
        {
            currentSlot = item;
            CustomCurson.gameObject.SetActive(true);
            CustomCurson.sprite = currentSlot.GetComponent<Image>().sprite;
            Debug.Log("craff");
        }
    }
    private void Crafting()
    {
        resultSRS.gameObject.SetActive(false);
        resultSRS.item = null;
        


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
                    resultSRS.gameObject.SetActive(true);
                    resultSRS.GetComponent<Image>().sprite = recipeResuls[i].GetComponent<Image>().sprite;
                    resultSRS.item = recipeResuls[i];
                    score += intscore;
                    TextScore.text = score.ToString();

                }
            }
        }
        

    }
    public void OnClickSlot(slot Slot)
    {
        Slot.item = null;
        itemList[Slot.index] = null;
        Slot.gameObject.SetActive(false);
        Crafting();
    }






    //public void Crafting()
    //{
    //    resultSRS.gameObject.SetActive(false);
    //    resultSRS.item = null;
    //
    //    item s = null;
    //    foreach(slot slot in itemList)
    //    {
    //        if (slot != null)
    //        {
    //            //s += slot.item;
    //        }
    //        else
    //        {
    //
    //        }
    //    }
    //              
    //}

    //private void ChekForCreateCustomor()
    //{
    //    resultSRS.gameObject.SetActive(false);
    //    resultSRS.item = null;
    //
    //    Image currentRecipes = null;
    //    //Debug.Log("Ingredients: ");
    //    foreach (item ingredient in custom.item)
    //    {
    //        if(ingredient != null)
    //        {
    //            currentRecipes = ingredient.Image; 
    //        }
    //        else
    //        {
    //            currentRecipes = null;
    //        }
    //    }
    //    //item[] recipes = custom.item;
    //    for (int i = 0; i < recipes.Length; i++)
    //    {
    //        if(recipes[i] == currentRecipes)
    //        {
    //            //item recipeResult = custom.image;
    //            if(recipes[i] == currentRecipes)
    //            {
    //                resultSRS.gameObject.SetActive(true);
    //                resultSRS.GetComponent<Image>().sprite = recipeResuls[i].GetComponent<Image>().sprite; // untuk menampikan gambar hasil (ex. ramuan)
    //                resultSRS.item = recipeResuls[i];
    //                Debug.Log("c");
    //            }
    //        }
    //    }
    //
    //}
    //public void OnClickSlot(slot slot)
    //{
    //    slot.item = null;
    //    itemList[slot.index] = null;
    //    slot.gameObject.SetActive(false);
    //    ChekForCreateCustomor();
    //    Debug.Log("d");
    //}


}





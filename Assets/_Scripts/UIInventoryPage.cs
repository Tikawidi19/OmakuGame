using System;
using System.Collections;
using System.Collections.Generic;
//using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace inventory.UI
{
    public class UIInventoryPage : MonoBehaviour
{
[SerializeField] private UIInventoryItem itemPrefebs;
[SerializeField] private RectTransform ContentPanel;
[SerializeField] private UIInventoryDescription itemDescription;

List<UIInventoryItem> ListOfUIItem = new List<UIInventoryItem>();

public event Action<int> OnDescriptionRequested, OnItemActionRequested;
private void Awake() {
   //Hide();
    itemDescription.ResetDescription();
}

public void InitializeInventoryUI(int inventorysize)
{
    for (int i = 0; i < inventorysize; i++)
    {
        UIInventoryItem uiItem = Instantiate(itemPrefebs, Vector3.zero, Quaternion.identity);
        uiItem.transform.SetParent(ContentPanel);
        ListOfUIItem.Add(uiItem);
        uiItem.OnItemClicked += handleItemSelection;
        uiItem.OnRightMouseBtnClick += HandleShowItemActions;
    }
}
public void UpdateData(int itemIndex, Sprite itemImage, int itemQuantity)
{
    if (ListOfUIItem.Count > itemIndex)
    {
        ListOfUIItem[itemIndex].SetDate(itemImage, itemQuantity);
    }
}

    private void HandleShowItemActions(UIInventoryItem obj)
    {
        
    }

    private void handleItemSelection(UIInventoryItem inventoryItemUI)
    {
        int index = ListOfUIItem.IndexOf(inventoryItemUI);
        if(index == -1)
        return;
        OnDescriptionRequested?.Invoke(index);
    }

    public void Show()
{
    gameObject.SetActive(true);
    
    ResetSelection();
}

    public void ResetSelection()
    {
        itemDescription.ResetDescription();
        DeselectAllItem();
    }

    private void DeselectAllItem()
    {
        foreach (UIInventoryItem item in ListOfUIItem)
        {
            item.Deselect();
        }
    }

    public void Hide()
{
    gameObject.SetActive(false);
}

    internal void UpdateDescription(int itemIndex, Sprite itemImage, string name, string describtion)
    {
        itemDescription.SetDescription(itemImage, name, describtion);
        DeselectAllItem();
        ListOfUIItem[itemIndex].Selec();
    }


}
}


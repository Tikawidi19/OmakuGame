using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using Unity.VisualScripting.ReorderableList;
using UnityEngine;

namespace inventory.Model
{
    [CreateAssetMenu]
public class InventorySO : ScriptableObject
{
    [SerializeField]
    private List<InventoryItem> inventoryItems;
    [field: SerializeField]
    public int size {get; private set;} =10;
    public event Action<Dictionary<int, InventoryItem>> OnInventoryUpdated;
    public void Initialize()
    {
        inventoryItems = new List<InventoryItem>();
        for (int i = 0; i < size; i++)
        {
            inventoryItems.Add(InventoryItem.GetEmptyItem());
        }
    }

    public void AddItem(InventoryItem item){
        AddItem(item.item, item.quantity);
    }
    public int AddItem(itemSO item, int quantity)
    {
        if (item.IsStackable == false)
        {
#pragma warning disable CS0162 // Unreachable code detected
                for (int i = 0; i < inventoryItems.Count; i++)
           {
            while (quantity > 0 && IsInventoryFull()== false)
            {
               quantity -= AddNonStackableItem(item, 1);
                
            }
            InforAboutChange();
            return quantity;

            // if(IsInventoryFull())
            // return quantity;
            // if (inventoryItems[i].IsEmpty)
            // {
            //     inventoryItems[i] = new InventoryItem
            //     {
            //         item = item,
            //         quantity = quantity
            //     };
            //     return;
            // }
          }
#pragma warning restore CS0162 // Unreachable code detected
            } 
        quantity = AddStackableItem(item, quantity);
        InforAboutChange();
        return quantity;
        
    }    
        private int AddNonStackableItem(itemSO item, int quantity)
        {
            InventoryItem newItem = new InventoryItem{
                item= item,
                quantity=quantity
            };
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if(inventoryItems[i].IsEmpty)
                {
                    inventoryItems[i] = newItem;
                    return quantity;
                }
            }
            return 0;
        }

        public bool IsInventoryFull()
            => inventoryItems.Where(item => item.IsEmpty).Any() == false;


        private int AddStackableItem(itemSO item, int quantity)
        {
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if (inventoryItems[i].IsEmpty)
                {
                    continue;
                }
                if (inventoryItems[i].item.ID == item.ID)
                {
                    int amountPossibleToTake = inventoryItems[i].item.MaxStackSize - inventoryItems[i].quantity;

                    if (quantity > amountPossibleToTake)
                    {
                        inventoryItems[i] = inventoryItems[i].ChangeQuantity(inventoryItems[i].item.MaxStackSize);
                        quantity -= amountPossibleToTake;
                    }
                    else{
                        inventoryItems[i] = inventoryItems[i].ChangeQuantity(inventoryItems[i].quantity + quantity);
                        InforAboutChange();
                        return 0;
                    }
                }
            }
            while(quantity > 0 && IsInventoryFull()== false)
            {
                int newQuantity = Math.Clamp(quantity, 0 , item.MaxStackSize);
                quantity -= newQuantity;
                AddItemToFreeSlot(item, newQuantity);
            } return quantity;
        }

        private int AddItemToFreeSlot(itemSO item , int quantity)
        {
            InventoryItem newItem = new InventoryItem{
                item= item,
                quantity=quantity
            };
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                if(inventoryItems[i].IsEmpty)
                {
                    inventoryItems[i] = newItem;
                    return quantity;
                }
            }
            return 0;
        }

        public Dictionary<int, InventoryItem> GetCurrentInventoryState()
    {
        Dictionary<int, InventoryItem> returnValue = new Dictionary<int, InventoryItem>();
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            if (inventoryItems[i].IsEmpty)
            continue;
            returnValue[i] = inventoryItems[i];
        }
        return returnValue;
    }

    public InventoryItem GetItemAt(int itemIndex)
    {
        return inventoryItems[itemIndex];
    }
      private void InforAboutChange()
        {
           OnInventoryUpdated?.Invoke(GetCurrentInventoryState());
        }
    public void ResetInventory()
    {
        Initialize();
        InforAboutChange();
    }
}
 [Serializable]
 public struct InventoryItem
 {
    public int quantity;
    public itemSO item;
    public bool IsEmpty => item == null;
    public InventoryItem ChangeQuantity(int newQuantity)
    {
        return new InventoryItem
        {
            item = this.item,
            quantity = newQuantity,
        };
        
    }
    public static InventoryItem GetEmptyItem()
    => new InventoryItem
    {
        item = null,
        quantity = 0,
    };

 }
}




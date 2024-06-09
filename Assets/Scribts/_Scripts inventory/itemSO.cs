using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace inventory.Model
{
  [CreateAssetMenu]
public class itemSO : ScriptableObject
{

    [field: SerializeField]
    public bool IsStackable { get; set;}
    public int ID => GetInstanceID();
    [field: SerializeField]
    public int MaxStackSize { get; set;}
    [field: SerializeField]
    public string Name { get; set;}
    [field: SerializeField]
    [field: TextArea]
    public string Describtion { get; set;}
    [field: SerializeField]
    public Sprite ItemImage {get; set;}

}  
}


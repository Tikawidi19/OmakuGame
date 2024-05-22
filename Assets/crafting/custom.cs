using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "custom", menuName = "Obat/custom")]
public class custom : ScriptableObject
{
    public string customerName;
    [TextArea] public string customDesc;
    public item[] item;
    public item image ;
}

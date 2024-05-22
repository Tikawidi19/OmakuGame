using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "bahan", menuName = "Obat/bahan")]

public class databahan : ScriptableObject
{
    public string namabahan;
    [TextArea] public string deskribsibahan;
    public Sprite imag;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCurson : MonoBehaviour
{

    private void Awake()
    {
      transform.position = Input.mousePosition;
        Debug.Log("drig");
    }

    private void Update()
    {
      transform.position = Input.mousePosition;
        Debug.Log("drug");
    }
}

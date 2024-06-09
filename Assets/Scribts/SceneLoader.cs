using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Analytics;

public class SceneLoader : MonoBehaviour
{
    public Transform slider;
    public float startValue;
    public float valueSpeed;

    [System.Obsolete]
    private void Update() {
        if (startValue < 100)
        {
            startValue += valueSpeed * Time.deltaTime;
            Debug.Log((int)startValue);
        } else
        {
            Application.LoadLevel("Main Menu");
            
        }
        slider.GetComponent<Image> ().fillAmount = startValue/100;

    }
}

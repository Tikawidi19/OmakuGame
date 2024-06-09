using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public GameObject informasi;
    // Start is called before the first frame update
private void OnTriggerEnter2D(Collider2D other) {
    informasi.SetActive(true);
    Time.timeScale = 0;
}
private void Update() {
    if(Input.touchCount>0){
        informasi.SetActive(false);
        Time.timeScale = 1;
    }
}
}

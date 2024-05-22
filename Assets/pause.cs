using UnityEngine;


public class pause : MonoBehaviour
{
    private bool isPaused = true;
    public GameObject player;
    // Function to toggle pause state
    public void TogglePause()
    {
        isPaused = !isPaused;
        // plyer.speed =3f;
        Time.timeScale = isPaused ? 0: 1;
        Debug.Log("JALAN");
        // player.SetActive(false);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneController : MonoBehaviour
{
    // public void OnIntroFinished()
    // {
    //     SceneManager.LoadScene("MainGameScene");
    // }
    
     // Nama scene yang ingin ditampilkan sekali
    public string sceneName;

    void Start()
    {
        // Periksa apakah scene sudah pernah dilihat
        if (!PlayerPrefs.HasKey(sceneName + "_seen"))
        {
            // Jika belum, tampilkan scene dan tandai sebagai sudah dilihat
            PlayerPrefs.SetInt(sceneName + "_seen", 1);
            PlayerPrefs.Save();
            SceneManager.LoadScene(sceneName);
        }
    }
}

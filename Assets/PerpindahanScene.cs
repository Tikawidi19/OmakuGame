using UnityEngine;
using UnityEngine.SceneManagement;

public class PerpindahanScene : MonoBehaviour
{
    public Animator animator;
    public string nextSceneName;

    void Update()
    {
        // Check if the current animation state is finished
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1 && !animator.IsInTransition(0))
        {
            // Change to the desired scene
            SceneManager.LoadScene(nextSceneName);
        }
    }
        // Method to be called by the Animation Event

}

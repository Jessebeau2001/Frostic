using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChanger : MonoBehaviour {

    public Animator animator;

    private int levelToLoad;
    void Update() {
    }

    public void FadeToLevel (int levelIndex) {
        animator.SetTrigger("FadeOut");
        levelToLoad = levelIndex;
    }

    public void onFadeComplete () {
        SceneManager.LoadScene(levelToLoad);
    }
}

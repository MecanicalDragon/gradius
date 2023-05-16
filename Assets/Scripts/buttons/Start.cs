using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {
    private void OnMouseUpAsButton() {
        SceneManager.LoadScene("Game");
    }
}
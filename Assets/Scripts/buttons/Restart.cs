using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    private void OnMouseUpAsButton() {
        SceneManager.LoadScene("Game");
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    private void OnMouseUpAsButton() {
        SceneManager.LoadScene("Menu");
    }
}
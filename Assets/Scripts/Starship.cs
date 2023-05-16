using UnityEngine;

public class Starship : MonoBehaviour {
    public GameObject restartButton;
    public GameObject menuButton;
    [SerializeField] private bool invincible;
    public static bool crashed = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (!other.CompareTag(Const.ASTEROID)) return;
        if (!invincible) {
            Scoring.StoreHighScore();
            crashed = true;
            restartButton.SetActive(true);
            menuButton.SetActive(true);
        }
    }
}
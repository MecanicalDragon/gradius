using UnityEngine;

public class ScoreLine : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
        if (!other.CompareTag(Const.ASTEROID) || Starship.crashed) return;
        Scoring.score++;
    }
}
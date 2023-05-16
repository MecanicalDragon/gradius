using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour {
    public static int score = 0;

    public TextMeshProUGUI scoreText;

    void Start() {
        score = 0;
    }

    void Update() {
        scoreText.text = score.ToString();
    }

    public static void StoreHighScore() {
        int currentScore = score;
        int oldHighScore = PlayerPrefs.GetInt(Const.HISCORE, 0);
        if (currentScore > oldHighScore) {
            PlayerPrefs.SetInt(Const.HISCORE, currentScore);
        }
    }
}
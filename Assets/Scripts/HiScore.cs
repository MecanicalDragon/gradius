using TMPro;
using UnityEngine;

public class HiScore : MonoBehaviour {
    private int _hiscore = 0;

    public TextMeshProUGUI scoreText;

    void Start() {
        _hiscore = PlayerPrefs.GetInt(Const.HISCORE, 0);
    }

    void Update() {
        scoreText.text = Const.HISCORE_VIEW + _hiscore;
    }
}
using System.Collections;
using UnityEngine;

public class Space : MonoBehaviour {
    public GameObject asteroid1;

    [SerializeField] private float rate;
    [SerializeField] private float accelerator;
    [SerializeField] private float acceleratorMultiplier;

    private readonly float[] _thresholds = { 0.75f, 0.5f, 0.333f, 0.25f, 0.2f};
    private float _activeThreshold;
    private float _activeAccelerator;
    private bool _lastThresholdReached;

    void Start() {
        Starship.crashed = false;
        _activeThreshold = _thresholds[0];
        _activeAccelerator = accelerator;
        _lastThresholdReached = false;
        StartCoroutine(AsteroidDrift());
    }

    private IEnumerator AsteroidDrift() {
        while (!Starship.crashed) {
            Instantiate(asteroid1, new Vector2(Random.Range(-3.0f, 3.0f), 6f), Quaternion.identity);
            var wait = rate - Scoring.score / 100f * _activeAccelerator;
            print(wait);
            if (wait < _activeThreshold && !_lastThresholdReached) {
                SelectNewThreshold(wait);
            }

            yield return new WaitForSeconds(wait);
        }
    }

    private void SelectNewThreshold(float wait) {
        _activeAccelerator *= acceleratorMultiplier;
        for (int i = _thresholds.Length - 1; i >= 0; i--) {
            if (_activeThreshold == _thresholds[i]) {
                if (i == _thresholds.Length - 1) {
                    _lastThresholdReached = true;
                    _activeAccelerator *= acceleratorMultiplier;
                    break;
                }

                _activeThreshold = _thresholds[i + 1];
            }
        }

        print("new threshold: " + _activeThreshold);
        print("new accelerator: " + _activeAccelerator);
    }
}
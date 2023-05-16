using UnityEngine;

public class Asteroid : MonoBehaviour {
    [SerializeField] private float speed;
    [SerializeField] private float rotation;
    [SerializeField] private float shift;
    [SerializeField] private float shiftChance;

    private float _rotation;
    private float _shift;

    private void Start() {
        _rotation = Random.Range(0 - rotation, rotation);
        if (Random.value < shiftChance) {
            _shift = transform.position.x > 0
                ? Random.Range(0, shift)
                : 0 - Random.Range(shift, 0);
        }
    }

    void Update() {
        transform.position -= new Vector3(_shift * Time.deltaTime, speed * Time.deltaTime, 0);
        transform.Rotate(0, 0, _rotation);
    }
}
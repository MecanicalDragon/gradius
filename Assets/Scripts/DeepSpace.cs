using UnityEngine;
using UnityEngine.UI;

public class DeepSpace : MonoBehaviour {
    [SerializeField] private RawImage space;
    [SerializeField] private float pace;

    void Update() {
        space.uvRect = new Rect(space.uvRect.position + new Vector2(0, pace) * Time.deltaTime, space.uvRect.size);
    }
}
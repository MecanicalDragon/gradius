using UnityEngine;

public class ScreenFlightController : MonoBehaviour {
    [SerializeField] private float LimitRight = 2.8f;
    [SerializeField] private float LimitLeft = -2.8f;
    [SerializeField] private float LimitTop = 4.2f;
    [SerializeField] private float LimitBot = -4.2f;
    [SerializeField] private float speed = 8f;

    public Transform starship;

    private void OnMouseDrag() {
        if (!Starship.crashed) {
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var newX = pos.x > LimitRight ? LimitRight : pos.x < LimitLeft ? LimitLeft : pos.x;
            var newY = pos.y > LimitTop ? LimitTop : pos.y < LimitBot ? LimitBot : pos.y;
            starship.position = Vector2.MoveTowards(
                starship.position,
                new Vector2(newX, newY),
                speed * Time.deltaTime
            );
        }
    }
}
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float destroyX = -10f;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
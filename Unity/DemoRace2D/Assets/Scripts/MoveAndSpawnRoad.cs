using UnityEngine;

public class MoveAndSpawnRoad : MonoBehaviour
{
    public float speed = 1.0f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (transform.position.y < -10)
            Destroy(gameObject);
    }
}

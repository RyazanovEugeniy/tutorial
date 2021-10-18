using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.y < -6.7)
            Destroy(gameObject);
    }
}

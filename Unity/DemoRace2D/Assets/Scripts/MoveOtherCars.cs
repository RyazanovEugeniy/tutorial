using UnityEngine;

public class MoveOtherCars : MonoBehaviour
{
    public float speed = 2.0f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.y < -6.7)
            Destroy(gameObject);
    }
}

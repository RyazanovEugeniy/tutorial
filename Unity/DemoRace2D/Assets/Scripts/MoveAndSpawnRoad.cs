using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject road;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (transform.position.y < -10.0f)
        {
            Instantiate(road, new Vector3(0.0f, 9.31f, 0.0f), Quaternion.identity);
            road.transform.localScale = new Vector3(0.8f, 1.0f, 1.0f);
            //transform.position = new Vector3(-0.78f, 8.11f, 0.0f);
            //EditorApplication.isPaused = true;
            Destroy(gameObject);
        }
    }
}

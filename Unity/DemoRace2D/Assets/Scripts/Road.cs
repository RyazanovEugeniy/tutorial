using UnityEngine;
using UnityEditor;

public class Road : MonoBehaviour
{
    public float speed = 2f;
    public GameObject road;
    void FixedUpdate()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (transform.position.y < -10.0f)
        {
            Instantiate(road, new Vector3(-0.03f, 9.31f, 0.0f), Quaternion.identity);
            road.transform.localScale = new Vector3(0.8f, 1.0f, 1.0f);
            Destroy(gameObject);

            //EditorApplication.isPaused = true;


        }
    }
}

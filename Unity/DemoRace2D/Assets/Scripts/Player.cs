using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 1.5f;
    void Update()
    {
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector3 dir = new Vector3(horizontal, 0, 0);

        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //SceneManager.LoadScene(2);
            //Destroy(gameObject);
        }
    }
}

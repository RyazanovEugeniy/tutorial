using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float longitudinalSpeed = 1.5f;
    public float rotateSpeed = 30.0f;

    void Update()
    {
        Vector3 dir = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
        Vector3 rotate = new Vector3(0, Input.GetAxisRaw("Horizontal"), 0);

        transform.Translate(dir.normalized * Time.deltaTime * longitudinalSpeed);
        transform.Rotate(rotate * Time.deltaTime * rotateSpeed);
    }
}

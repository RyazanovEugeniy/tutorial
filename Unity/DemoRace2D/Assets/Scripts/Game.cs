using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject text;
    public GameObject[] cars;

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(cars[Random.Range(0, cars.Length)], 
                new Vector3(Random.Range(-1.73f, 1.73f), 6.79f, 0.0f),
                Quaternion.Euler(new Vector3(90.0f, 180.0f, 0.0f)));
            yield return new WaitForSeconds(2.5f);
        }
    }


    void Update()
    {
        text.GetComponent<Text>().text = "Time: " + Time.time;
    }
}

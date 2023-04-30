using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    int numberOfTimes = 5;
    string nameOfTheKey = "space";
    float speedOfLight = 12.54f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hellow everyone im print from debug " + numberOfTimes);
        Debug.LogError("Algo deu errado ao precionar " + nameOfTheKey);
        Debug.LogWarning("Isso é um aviso, acinado velocidade da luz " + speedOfLight);


    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up * (Time.deltaTime + 1.0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * (Time.deltaTime + 0.1f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (Time.deltaTime + 0.1f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (Time.deltaTime + 0.1f));
        }


    }
}

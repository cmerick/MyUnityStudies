using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D myRigidBody2d;




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
            myRigidBody2d.velocity = new Vector2(0f, 10f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myRigidBody2d.velocity = new Vector2(0f, -10f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidBody2d.velocity = new Vector2(-10f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigidBody2d.velocity = new Vector2(10f, 0f);
        }


    }
}

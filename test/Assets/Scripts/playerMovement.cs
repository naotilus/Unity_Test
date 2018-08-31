using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Vector2 speed = new Vector2(25, 25);

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(speed.x * inputX, 0, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }
}

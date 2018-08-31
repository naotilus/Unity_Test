using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
// Update is called once per frame
	void Update () {


        Vector3 start = new Vector3(0, 0, 0);

        Vector3 posY = transform.position;

        if(posY.y <= -10)
        {
            transform.position = start;
            Debug.Log("Penis. Errigiert.");

        }
	}
}

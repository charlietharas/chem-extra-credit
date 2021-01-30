using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
	public GameObject cam;

    // Update is called once per frame
    void Update()
    {
		transform.position = new Vector2(cam.transform.position.x, cam.transform.position.y);
    }
}

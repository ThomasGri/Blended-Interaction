using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TangoPointCloud pc = GameObject.FindObjectOfType<TangoPointCloud>();
		Camera cam = Camera.main;

		if (Input.touchCount == 1)
		{
			Touch t = Input.GetTouch(0);
			Vector3 planeCenter;
			Plane plane;
			if (pc.FindPlane(cam, t.position, out planeCenter, out plane))
			{
				Debug.Log("Found plane");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}

using UnityEngine;
using System.Collections;

public class scriptButtonQuit : MonoBehaviour {

	public void Update(){
		if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) || (Input.GetMouseButtonDown (0))) {
			// quit application
			//Application.Quit ();
		}
}
}
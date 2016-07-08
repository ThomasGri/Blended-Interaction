using UnityEngine;
using System.Collections;

public class createNote : MonoBehaviour {

	public Material Yellow;
	 

	public void end(){
		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.localScale = new Vector3 (0.5F, 0.5F, 0.005F);
		cube.transform.position = new Vector3 (0, 0, 1);
		// supposed to set material to Yellow. But it is pink!
		cube.GetComponent<MeshRenderer> ().material = Yellow;
	}
}

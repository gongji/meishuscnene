using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testbounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.A))
		{
			CreateCube();
		}
	}

	private void CreateCube()
	{
		BoxCollider box = GetComponent<BoxCollider>();
		if(!box)
		{
			return ;
		}

		Bounds b= box.bounds;

		Debug.Log(b.size);
		GameObject wireObject= GameObject.CreatePrimitive(PrimitiveType.Cube);
		wireObject.transform.SetParent(transform);
		wireObject.transform.localPosition= new Vector3(0,0,b.size.z/2.0f);
		wireObject.transform.localEulerAngles = new Vector3(-90,0,0);
		wireObject.transform.localScale = b.size;
	}
}

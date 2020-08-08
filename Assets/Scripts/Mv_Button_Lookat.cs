using UnityEngine;
using System.Collections;

public class Mv_Button_Lookat : MonoBehaviour {
	public Transform myTransform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.LookAt(myTransform);
	}
}

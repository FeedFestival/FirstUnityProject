using UnityEngine;
using System.Collections;

public class sc1_item01 : MonoBehaviour {
	public Texture2D Use_normalTex;
	
	public Texture2D Use_hoverTex;
	public GameObject FstBut;
	// Use this for initialization
	void Start () {
		FstBut = GameObject.Find("sc1_Item01_Use");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnMouseEnter(){
		FstBut.guiTexture.texture = Use_normalTex;
	}
	public void OnMouseExit(){
		FstBut.guiTexture.texture = Use_hoverTex;
	}
	
	public void RightClickMenu_pentru_item01(/*GameObject EBut GameObject IBut*/){
					
			FstBut.guiTexture.enabled = true;
			//UseButton.guiTexture.enabled = true;
			//IBut.guiTexture.enabled = true;
			FstBut.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
			//UseButton.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
			//IBut.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
			//Debug.Log("a accesat" + ob);
	}
}

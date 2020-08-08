using UnityEngine;
using System.Collections;

public class MouseClickButton_Door : MonoBehaviour {
	
	public Texture2D normalTex;
	public Texture2D hoverTex;
	public Texture2D clickTex;
	public bool clicked = false;
	public GameObject OpenButton;
	// Use this for initialization
	void Start () {
		OpenButton = GameObject.Find("Door_Button_Open");
	}
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnMouseDown(){
		if (clicked == false){
		guiTexture.texture = clickTex;
		clicked = true;
		//StartCoroutine(MyLoadLevel(3,"Scene2"));
		
		OpenButton.guiTexture.enabled = true;
		}
		else if (clicked == true){
			guiTexture.texture = normalTex;
			clicked = false;
			OpenButton.guiTexture.enabled = false;
		}
	}
	public void OnMouseEnter(){
		if (clicked == false)
			guiTexture.texture = hoverTex;
	}
	public void OnMouseExit(){
		if (clicked == false)
		guiTexture.texture = normalTex;
	}
	IEnumerator MyLoadLevel(float delay,string level){
		
    	yield return new WaitForSeconds(delay);
		PlayerPrefs.Save();
    	Application.LoadLevel(level);
	}
}

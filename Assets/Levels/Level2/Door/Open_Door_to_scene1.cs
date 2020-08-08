using UnityEngine;
using System.Collections;

public class Open_Door_to_scene1 : MonoBehaviour {
	public Texture2D enter_normalTex;
	
	public Texture2D enter_hoverTex;
	public GameObject OpenButton;
	public GameObject next_Scene;
	public GameObject next_Scene1;
	public GameObject curent_Scene;
	public GameObject door_trig;
	// Use this for initialization
	void Start () {
		OpenButton = GameObject.Find("Enter_Door_sc1");
		next_Scene = GameObject.Find("sc1_2");
		curent_Scene = GameObject.Find("Scene2");
		next_Scene1 = GameObject.Find("sc1");
		door_trig = GameObject.Find("Door_to_Scene2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DisableOnMB(){
			OpenButton.guiTexture.enabled = false;
	}
	public void OnMouseDown(){
		/*next_Scene.renderer.enabled = true;
		next_Scene1.renderer.enabled = true;
		curent_Scene.renderer.enabled = false;
		door_trig.collider.enabled = false;*/
		
	}
	public void OnMouseEnter(){
		OpenButton.guiTexture.texture = enter_normalTex;
		GameObject.Find("Disable_Menu").SendMessage("OpenState",false);
		GameObject.Find("Disable_Menu").SendMessage("check");
	}
	public void OnMouseExit(){
		OpenButton.guiTexture.texture = enter_hoverTex;
		
		GameObject.Find("Disable_Menu").SendMessage("OpenState",true);
		GameObject.Find("Disable_Menu").SendMessage("check");
	}
	
}
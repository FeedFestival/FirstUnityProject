using UnityEngine;
using System.Collections;

public class Info_Door_to_scene2 : MonoBehaviour {
	public Texture2D enter_normalTex;
	
	public Texture2D enter_hoverTex;
	public GameObject InfoButton;
	// Use this for initialization
	void Start () {
		InfoButton = GameObject.Find("Info_Door_sc2");
		//StartCoroutine(WaitTill_DisableMenu(3));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DisableOnMB(){
			InfoButton.guiTexture.enabled = false;
	}
	public void OnMouseEnter(){
		InfoButton.guiTexture.texture = enter_normalTex;
		GameObject.Find("Disable_Menu").SendMessage("InfoState",false);
		GameObject.Find("Disable_Menu").SendMessage("check");
	}
	public void OnMouseExit(){
		InfoButton.guiTexture.texture = enter_hoverTex;
		
		GameObject.Find("Disable_Menu").SendMessage("InfoState",true);
		GameObject.Find("Disable_Menu").SendMessage("check");
	}
}

using UnityEngine;
using System.Collections;

public class Enter: MonoBehaviour {
	public Texture2D enter_normalTex;
	
	public Texture2D enter_hoverTex;
	public GameObject OpenButton;
	// Use this for initialization
	void Start () {
		OpenButton = GameObject.Find("Cube_Enter");
		//StartCoroutine(WaitTill_DisableMenu(3));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DisableOnMB(){
			OpenButton.guiTexture.enabled = false;
	}
	public void OnMouseDown(){
		Application.LoadLevel("Scene2");
	}
	public void OnMouseEnter(){
		OpenButton.guiTexture.texture = enter_normalTex;
		StopCoroutine("DisableMenu");
	}
	public void OnMouseExit(){
		OpenButton.guiTexture.texture = enter_hoverTex;
		StartCoroutine("DisableMenu",4.0);
	}
	
	IEnumerator DisableMenu(float delay){
		
    	yield return new WaitForSeconds(delay);
		OpenButton.guiTexture.enabled = false;
		
	}
}

using UnityEngine;
using System.Collections;

public class Info : MonoBehaviour {
public Texture2D enter_normalTex;
	
	public Texture2D enter_hoverTex;
	public GameObject InfoButton;
	// Use this for initialization
	void Start () {
		InfoButton = GameObject.Find("Cube_Info");
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
		StopCoroutine("DisableMenu");
	}
	public void OnMouseExit(){
		InfoButton.guiTexture.texture = enter_hoverTex;
		StartCoroutine("DisableMenu",4.0);
	}
	IEnumerator DisableMenu(float delay){
		
    	yield return new WaitForSeconds(delay);
		InfoButton.guiTexture.enabled = false;
		
	}
}

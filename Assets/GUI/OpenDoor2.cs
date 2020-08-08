using UnityEngine;
using System.Collections;

public class OpenDoor2 : MonoBehaviour {
	public Texture2D normalTex;
	public Texture2D hoverTex;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
	public void OnMouseDown(){
		StartCoroutine(MyLoadLevel(3,"Scene1"));
	}
	public void OnMouseEnter(){
			guiTexture.texture = hoverTex;
	}
	public void OnMouseExit(){
		guiTexture.texture = normalTex;
	}
	IEnumerator MyLoadLevel(float delay,string level){
    	yield return new WaitForSeconds(delay);
		PlayerPrefs.Save();
    	Application.LoadLevel(level);
	}
}
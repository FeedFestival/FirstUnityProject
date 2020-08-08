using UnityEngine;
using System.Collections;

public class disable_Menu_D_sc1 : MonoBehaviour {
	public bool go1 = false;
	public bool go2 = false;
	public GameObject OpenButton;
	public GameObject InfoButton;
	// Use this for initialization
	void Start () {
		OpenButton = GameObject.Find("Enter_Door_sc2");
		InfoButton = GameObject.Find("Info_Door_sc2");
	}
	
	// Update is called once per frame
	void Update () {
		/*Disable_Meniu(go1,go2);
		Debug.Log(go1 + " - " + go2);*/
	}
	public void check(){
		Disable_Meniu(go1,go2);
		Debug.Log(go1 + " - " + go2);
	}
	public void OpenState(bool da){
		go1 = da;
	}
	public void InfoState(bool ba){
		go2 = ba;
	}
	public void Disable_Meniu(bool a, bool b){
		if ((a == true)&&(b==true)){
			StartCoroutine("DisableMenu",4.0);
			}else {StopCoroutine("DisableMenu");}
		
	}
	IEnumerator DisableMenu(float delay){
		
    	yield return new WaitForSeconds(delay);
		OpenButton.guiTexture.enabled = false;
		InfoButton.guiTexture.enabled = false;
		
	}
}

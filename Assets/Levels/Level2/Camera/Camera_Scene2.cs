using UnityEngine;
using System.Collections;

public class Camera_Scene2 : MonoBehaviour {
	public Texture cursorImage;
	public Texture cursorOver;
	public GameObject EnterButton;
	public GameObject InfoButton;
	private bool useNormal = true;
	//public GameObject UseButton;
	
	
//---------------------------------------------------------------------------------------------------------------------------
	
	// - declaram String(numele) ptr fiecare obiect si button care trb accesat prin camera
	// Obiect-ul/ele Trigger
	public string Obiect01 = "Door_to_Scene1";	// Usa cu care intri in scena1

// Buttoanele, GUI texture
//---------------------------------------------------------------------------------------------------------------------------
	
	private string Button1 = "Enter_Door_sc1"; 	// butonul de intrare in scena 1
	private string Button2 = "Info_Door_sc1";	// informatii despre obiect: Usa
	
	
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
	
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		//Cautam GUI buttons in scena
		
		EnterButton = GameObject.Find(Button1);
		//UseButton = GameObject.Find():
		InfoButton = GameObject.Find(Button2);
		
//---------------------------------------------------------------------------------------------------------------------------
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);	// Shoot RAY din camera
		Debug.DrawRay(ray.origin, ray.direction * 30,Color.black);
		RaycastHit hit;
		useNormal = true;
		
		if (Physics.Raycast(ray,out hit) == true){
			Debug.DrawRay(ray.origin, ray.direction * 30,Color.green);
			
			RightClickMenu_pentru(Obiect01,hit);
			
			}
// - daca un meniu este deschis, il poti inchide apasand oriunde un click >--------------------------------------------------
//---------------------------------------------------------------------------------------------------------
		if(Physics.Raycast(ray,out hit) == false){
			if (Input.GetMouseButtonDown(0)){
				EnterButton.SendMessage("DisableOnMB");
				//UseButton.SendMessage("DisableOnMB");
				InfoButton.SendMessage("DisableOnMB");
			}
			if (Input.GetMouseButtonDown(1)){
				EnterButton.SendMessage("DisableOnMB");
				//UseButton.SendMessage("DisableOnMB");
				InfoButton.SendMessage("DisableOnMB");
			}
		}
		
		
	}
	
	// Cursor Change 
//--------------------------------------------------------------------------------------------------------
	public void OnGUI(){
	    if (useNormal == true){
			Vector3 mousePos = Input.mousePosition;
	    	Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y, cursorImage.width, cursorImage.height);
	    	GUI.Label(pos, cursorImage);
			}
			else {
				Vector3 mousePos = Input.mousePosition;
	    		Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y, cursorOver.width, cursorOver.height);
	   			GUI.Label(pos, cursorOver);
				}
	}
	// Right Click Menu
	//--------------------------------------------------------------------------------------------------------
	public void RightClickMenu_pentru(string ob,RaycastHit hit){
		useNormal = false;
		if (Input.GetMouseButtonDown(1)){
				if (hit.collider.gameObject.name == ob){
					EnterButton.guiTexture.enabled = true;
					//UseButton.guiTexture.enabled = true;
					InfoButton.guiTexture.enabled = true;
					EnterButton.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					//UseButton.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					InfoButton.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					Debug.Log("a accesat" + ob);
					}
			}
	}
}

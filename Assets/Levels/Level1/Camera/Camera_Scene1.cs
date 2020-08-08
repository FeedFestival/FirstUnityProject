using UnityEngine;
using System.Collections;

public class Camera_Scene1 : MonoBehaviour {
	public Texture cursorImage;
	public Texture cursorOver;
	
	public GameObject EnterButtonsc1;
	public GameObject InfoButtonsc1;
	public GameObject EnterButtonsc2;
	public GameObject InfoButtonsc2;
	
	private bool useNormal = true;
	//public GameObject UseButton;
	
	
//---------------------------------------------------------------------------------------------------------------------------
	
	// - declaram String(numele) ptr fiecare obiect si button care trb accesat prin camera
	// Obiect-ul/ele Trigger
	//public string Obiect01 = "Door_to_Scene2";	// Usa cu care intri in scena2
	//public string Obiect_door_to_sc1 = "Door_to_Scene1"; // usa cu care intri in scena1

// Buttoanele, GUI texture
//---------------------------------------------------------------------------------------------------------------------------
	
	/*private string Button1 = "Enter_Door_sc2"; 	// butonul de intrare in scena 1
	private string Button2 = "Info_Door_sc2";	// informatii despre obiect: Usa
	
	private string Button1_a = "Enter_Door_sc1";
	private string Button2_a =	"Info_Door_sc1";*/
	
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
	
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		//Cautam GUI buttons in scena
		
		/*EnterButtonsc1 = GameObject.Find(Button1);
		EnterButtonsc2 = GameObject.Find(Button1_a);
		//UseButton = GameObject.Find():
		InfoButtonsc1 = GameObject.Find(Button2);
		InfoButtonsc2 = GameObject.Find(Button2_a);*/
		
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
			useNormal = false;
			if (Input.GetMouseButtonDown(1)){
				Debug.DrawRay(ray.origin, ray.direction * 30,Color.red);
				/*if (hit.collider.gameObject.name == Obiect_door_to_sc1){
					//RightClickMenu_pentru_Door(EnterButtonsc1,InfoButtonsc1);
					//RightClickMenu_pentru_Door(EnterButtonsc2,InfoButtonsc2);
					}
				if (hit.collider.gameObject.name == Obiect01){
					RightClickMenu_pentru_Door(EnterButtonsc1,InfoButtonsc1);
					//RightClickMenu_pentru_Door(EnterButtonsc2,InfoButtonsc2);
					}*/
			}
			
			
			}
		
			
			
			
// - daca un meniu este deschis, il poti inchide apasand oriunde un click >--------------------------------------------------
//---------------------------------------------------------------------------------------------------------
		if(Physics.Raycast(ray,out hit) == false){
			//Disable_onClick_forDoors(EnterButtonsc1,InfoButtonsc1);
			//Disable_onClick_forDoors(EnterButtonsc2,InfoButtonsc2);
		
		}
	}
	
	// Right Click Menu
	//--------------------------------------------------------------------------------------------------------
	public void RightClickMenu_pentru_Door(GameObject EBut, GameObject IBut){
					
					EBut.guiTexture.enabled = true;
					//UseButton.guiTexture.enabled = true;
					IBut.guiTexture.enabled = true;
					EBut.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					//UseButton.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					IBut.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					//Debug.Log("a accesat" + ob);
					
			
	}
	
	//functia pentru inchiderea meniurilor pentru usi la click
	//---------------------------------------------------------------------------------------------------
	public void Disable_onClick_forDoors(GameObject EBut, GameObject IBut){
		
			if (Input.GetMouseButtonDown(0)){
				EBut.SendMessage("DisableOnMB");
				//UseButton.SendMessage("DisableOnMB");
				IBut.SendMessage("DisableOnMB");
			}
			if (Input.GetMouseButtonDown(1)){
				EBut.SendMessage("DisableOnMB");
				//UseButton.SendMessage("DisableOnMB");
				IBut.SendMessage("DisableOnMB");
			}
		}
	
}


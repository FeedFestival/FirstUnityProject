using UnityEngine;
using System.Collections;

public class Camera_Ray : MonoBehaviour {
	public Texture cursorImage;
	public Texture cursorOver_Goto_Area;
	public Texture cursorOver_Door;
	public Texture cursorOver_Item;
	public Texture cursorOver_Person;
	
	public int useCursor = 0;
	
	void Start () {		// Use this for initialization

	Screen.showCursor = false;
	}
	
	
	void Update () {	// Update is called once per frame
	Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);	// Shoot RAY din camera
	Debug.DrawRay(ray.origin, ray.direction * 30,Color.black);
	RaycastHit hit;
// - Verificam ce loveste
	if (Physics.Raycast(ray,out hit) == true){
		Debug.DrawRay(ray.origin, ray.direction * 30,Color.green);
//---------------------------------------------------------------------------------------------------------
//Obiecte de tip Goto sau Look
		if (hit.collider.gameObject.name == "sc1__Look_Behind_Cube"){
				useCursor = 1;
				if (Input.GetMouseButtonDown(0)){
					//Goto_Area();
					Look_at_Area(/*-positia */new Vector3(6.97f, 3.96f, 0.20f),/*-rotatie */ new Vector3(37.0f, 201.0f, 0.2f),
"sc1__Look_Behind_Cube", "sc1__Look_atwhole_sc1");
					}
			}
		if (hit.collider.gameObject.name == "sc1__Look_atwhole_sc1"){
				useCursor = 1;
				if (Input.GetMouseButtonDown(0)){
					//Goto_Area();
					Look_at_Area(new Vector3(-1.9f, 6.0f, 6.2f), new Vector3(33.0f, 156.0f, 2.0f),
"sc1__Look_atwhole_sc1", "sc1__Look_Behind_Cube");
				}
			}
//Obiecte de tip Door sau Chest
		if (hit.collider.gameObject.name == "sc1__Door_to_sc2"){
				useCursor = 2;
			}
//Obiecte de tip Item
		if (hit.collider.gameObject.name == "sc1__Item_01"){
				useCursor = 3;
				if (Input.GetMouseButtonDown(1)){
					GameObject.Find("sc1__Item_01").SendMessage("RightClickMenu_pentru_item01");
				}
			}
// Obiecte de tip Person
		}
	
	
	
	if (Physics.Raycast(ray,out hit) == false){
		useCursor = 0;
	
		}
	}
	public void OnGUI(){	// Schimbam cursorul in funtie de ce obiect avem sub mouse
	if (useCursor == 0){
	    Vector3 mousePos = Input.mousePosition;
	    Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y, cursorImage.width, cursorImage.height);
	    GUI.Label(pos, cursorImage);
		}	
	if (useCursor == 1){
	    Vector3 mousePos = Input.mousePosition;
	    Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y, cursorImage.width, cursorImage.height);
	    GUI.Label(pos, cursorOver_Goto_Area);
		}
	if (useCursor == 2){
	    Vector3 mousePos = Input.mousePosition;
	    Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y, cursorImage.width, cursorImage.height);
	    GUI.Label(pos, cursorOver_Door);
		}
	if (useCursor == 3){
	    Vector3 mousePos = Input.mousePosition;
	    Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y, cursorImage.width, cursorImage.height);
	    GUI.Label(pos, cursorOver_Item);
		}
	if (useCursor == 4){
	    Vector3 mousePos = Input.mousePosition;
	    Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y, cursorImage.width, cursorImage.height);
	    GUI.Label(pos, cursorOver_Person);
		}
				
	}
	
	public void Look_at_Area(Vector3 Look_pos, Vector3 Look_Rot, string to_kill, string activate){
		GameObject tempactiv;
		GameObject tempkill;
		
		Camera.mainCamera.transform.position = Look_pos;
		Camera.mainCamera.transform.eulerAngles = Look_Rot;
		tempactiv = GameObject.Find(activate);
		tempkill = GameObject.Find(to_kill);
		tempactiv.collider.enabled = true;
		tempkill.collider.enabled = false;
	}
}

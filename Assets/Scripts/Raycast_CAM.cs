using UnityEngine;
using System.Collections;

public class Raycast_CAM : MonoBehaviour {
	public Texture cursorImage;
	public Texture cursorOver;
	public GameObject OpenCubeButton;
	public GameObject InfoCubeButton;
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		OpenCubeButton = GameObject.Find("Cube_Enter");
		InfoCubeButton = GameObject.Find("Cube_Info");
	}
	private bool useNormal = true;
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(ray.origin, ray.direction * 30,Color.black);
		RaycastHit hit;
		useNormal = true;
		
		if(Physics.Raycast(ray,out hit) == true){
			Debug.DrawRay(ray.origin, ray.direction * 30,Color.green);
			useNormal = false;
				
			if (Input.GetMouseButtonDown(1)){
				if (hit.collider.gameObject.name == "Door"){
					OpenCubeButton.guiTexture.enabled = true;
					InfoCubeButton.guiTexture.enabled = true;
					OpenCubeButton.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					InfoCubeButton.transform.position = new Vector3(Input.mousePosition.x/Screen.width, Input.mousePosition.y/Screen.height,0);
					Debug.Log("a accesat usa");
					}
				
				}
			}
		if(Physics.Raycast(ray,out hit) == false){
			if (Input.GetMouseButtonDown(0)){
				OpenCubeButton.SendMessage("DisableOnMB");
				InfoCubeButton.SendMessage("DisableOnMB");
			}
			if (Input.GetMouseButtonDown(1)){
				OpenCubeButton.SendMessage("DisableOnMB");
				InfoCubeButton.SendMessage("DisableOnMB");
			}
		}
	}
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
}

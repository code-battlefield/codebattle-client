using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	private int buttonWidth = 120;
	private int buttonHeight = 30;
	private int spacing = 30;
	
	private string joinRoomId = "room id";
	
	private string lable;
	
	private string ip = "106.186.21.40";
	private string port = "11011";
	
	

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnGUI () {
		GUILayout.BeginArea(new Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - 200, buttonWidth, 400));
			GUILayout.Label("IP");
			ip = GUILayout.TextField(ip, buttonWidth-40);
			GUILayout.Label("PORT");
			port = GUILayout.TextField(port, buttonWidth);
			if(GUILayout.Button("Create Room", GUILayout.Height(buttonHeight)))	{
				CodeBattle.Static.StaticVar.ip = ip;
				CodeBattle.Static.StaticVar.port = port;
				Application.LoadLevel("Battle");
			}
			GUILayout.Space(spacing);
		
			//joinRoomId = GUILayout.TextField(joinRoomId, buttonWidth);

			if(GUILayout.Button("Join Room", GUILayout.Height(buttonHeight))) {
				lable = "This feature is NOT available in this version";
			}
			GUILayout.Label(lable);

			GUILayout.Space(spacing - 10);
		
			if(GUILayout.Button("Exit", GUILayout.Height(buttonHeight)))	{
				Application.Quit();
			}
		
		GUILayout.EndArea();
	}
		
	void IgnoreThis(int WindowId) {
		
	}
}

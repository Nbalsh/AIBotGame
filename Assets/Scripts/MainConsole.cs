using UnityEngine;
using System.Collections;

public class MainConsole : MonoBehaviour {
	bool showText = true;
	Rect textAreaTop;
	Rect textAreaBottom;
	string userText;
	string room;
	string userTextTop = "Logging into LightStream.\n";

	// Use this for initialization
	void Start () {
		userTextTop += "Logged in. Routing you to last room; The Wiccan Imperial Suite. What would you like to do? (try: <i>examine</i> <b>room</b>)\n";
		room = "intro";
		textAreaTop = new Rect(0,0,Screen.width, Screen.height - Screen.height/9);
		textAreaBottom = new Rect(0, Screen.height - Screen.height/8, Screen.width, Screen.height/10);
	} 
	
	void OnGUI(){

	 if(showText){
		GUI.Label(textAreaBottom, userText);
		GUI.Label(textAreaTop, userTextTop);
		KeyboardInput();
	 }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void KeyboardInput() {
		if(Event.current.type == EventType.KeyUp) {
			if (Event.current.keyCode == KeyCode.Space)
				userText += ' ';
			else if (Event.current.keyCode == KeyCode.Return){
				userTextTop = userTextTop != null ? userTextTop += "\nUSER: " + userText : "USER: " + userText;
				userTextTop += "\n";
				ParseInput(userText, room);
				userText = "";
			}
			else if( Event.current.keyCode == KeyCode.Backspace && userText != null)
				userText = userText.Length > 0 ? userText.Substring(0, userText.Length - 1) : userText;
			else if (Event.current.keyCode == KeyCode.A)
				userText += KeyCode.A;
			else if (Event.current.keyCode == KeyCode.B)
				userText += KeyCode.B;
			else if (Event.current.keyCode == KeyCode.C)
				userText += KeyCode.C;
			else if (Event.current.keyCode == KeyCode.D)
				userText += KeyCode.D;
			else if (Event.current.keyCode == KeyCode.E)
				userText += KeyCode.E;
			else if (Event.current.keyCode == KeyCode.F)
				userText += KeyCode.F;
			else if (Event.current.keyCode == KeyCode.G)
				userText += KeyCode.G;
			else if (Event.current.keyCode == KeyCode.H)
				userText += KeyCode.H;
			else if (Event.current.keyCode == KeyCode.I)
				userText += KeyCode.I;
			else if (Event.current.keyCode == KeyCode.J)
				userText += KeyCode.J;
			else if (Event.current.keyCode == KeyCode.K)
				userText += KeyCode.K;
			else if (Event.current.keyCode == KeyCode.L)
				userText += KeyCode.L;
			else if (Event.current.keyCode == KeyCode.M)
				userText += KeyCode.M;
			else if (Event.current.keyCode == KeyCode.N)
				userText += KeyCode.N;
			else if (Event.current.keyCode == KeyCode.O)
				userText += KeyCode.O;
			else if (Event.current.keyCode == KeyCode.P)
				userText += KeyCode.P;
			else if (Event.current.keyCode == KeyCode.Q)
				userText += KeyCode.Q;
			else if (Event.current.keyCode == KeyCode.R)
				userText += KeyCode.R;
			else if (Event.current.keyCode == KeyCode.S)
				userText += KeyCode.S;
			else if (Event.current.keyCode == KeyCode.T)
				userText += KeyCode.T;
			else if (Event.current.keyCode == KeyCode.U)
				userText += KeyCode.U;
			else if (Event.current.keyCode == KeyCode.V)
				userText += KeyCode.V;
			else if (Event.current.keyCode == KeyCode.W)
				userText += KeyCode.W;
			else if (Event.current.keyCode == KeyCode.X)
				userText += KeyCode.X;
			else if (Event.current.keyCode == KeyCode.Y)
				userText += KeyCode.Y;
			else if (Event.current.keyCode == KeyCode.Z)
				userText += KeyCode.Z;
			else if (Event.current.keyCode == KeyCode.Keypad1 || Event.current.keyCode == KeyCode.Alpha1)
				userText += "1";
			else if (Event.current.keyCode == KeyCode.Keypad2 || Event.current.keyCode == KeyCode.Alpha2)
				userText += "2";
			else if (Event.current.keyCode == KeyCode.Keypad3 || Event.current.keyCode == KeyCode.Alpha3)
				userText += "3";
			else if (Event.current.keyCode == KeyCode.Keypad4 || Event.current.keyCode == KeyCode.Alpha4)
				userText += "4";
			else if (Event.current.keyCode == KeyCode.Keypad5 || Event.current.keyCode == KeyCode.Alpha5)
				userText += "5";
			else if (Event.current.keyCode == KeyCode.Keypad6 || Event.current.keyCode == KeyCode.Alpha6)
				userText += "6";
			else if (Event.current.keyCode == KeyCode.Keypad7 || Event.current.keyCode == KeyCode.Alpha7)
				userText += "7";
			else if (Event.current.keyCode == KeyCode.Keypad8 || Event.current.keyCode == KeyCode.Alpha8)
				userText += "8";
			else if (Event.current.keyCode == KeyCode.Keypad9 || Event.current.keyCode == KeyCode.Alpha9)
				userText += "9";
			else if (Event.current.keyCode == KeyCode.Keypad0 || Event.current.keyCode == KeyCode.Alpha0)
				userText += "0";
		}
	}

	void ParseInput(string input, string room) {
		input = input.ToLower();
		if (room == "intro") {
			if (input == "examine room") {
				userTextTop += "A <b>bookcase</b>, a shaft of <b>light</b> to our right. Looks like someone's office.\n";
			} else if (input == "examine bookcase") {
				userTextTop += "Each book, except for one, is inverted. The only book with a visible spine is called '<b>Lightweight</b>.'\nWe might wanna <i>lookup</i> that book.\n";
			} else if (input == "examine light") {
				userTextTop += "An expanse. The city remains abuzz, precalculated pylons and technical terror behind the walls. It's raining.\n";
			} else if (input == "lookup lightweight") {
				userTextTop += "Okay, okay, okay... Yeah, got it! That book doesn't exist. Hmm. Should we <i>touch</i> it?\n";
			} else if (input == "touch lightweight") {
				userTextTop += "We lift it out, and out of it falls a <b>key</b>.\n";
			} else {
				userTextTop += "Input Unrecognized.\n";
			}
		} else {
			userTextTop += "Input Unrecognized.\n";
		}

//		if (input == "look" && room == "intro") {
//			userTextTop += "A bookcase, a shaft of light to our right. Looks like someone's office.\n";
//		} else {
//			userTextTop += "Input Unrecognized.\n";
//		}
	}
}

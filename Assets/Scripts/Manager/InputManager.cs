using UnityEngine;
using System.Collections;

public class InputManager : Singleton<InputManager> {

	public event System.Action OnTapEvent;
	public event System.Action OnTapDownEvent;
	public event System.Action OnTapUpEvent;
	
	void Update(){
		if(Input.GetMouseButton(0) && OnTapEvent != null) { OnTapEvent(); }
		if(Input.GetMouseButtonUp(0) && OnTapUpEvent != null){ OnTapUpEvent (); }
		if(Input.GetMouseButtonDown(0) && OnTapDownEvent != null){ OnTapDownEvent (); }
	}

	public void OnGetLoginButtonDown(){
		AppManager.I.Login();
	}

	/*use this where want tap action
 	void  OnEnable(){
		InputManager.I.OnTapEvent += OnTap;
		InputManager.I.OnTapUpEvent += OnTapUp;
		InputManager.I.OnTapDownEvent += OnTapDown;
	}

	void  OnDisable(){
		if (!InputManager.IsValid ()) {
			return;
		}
		InputManager.I.OnTapEvent -= OnTap;
		InputManager.I.OnTapUpEvent -= OnTapUp;
		InputManager.I.OnTapDownEvent -= OnTapDown;
	}

	void OnDestroy(){
		if (!InputManager.IsValid ()) {
			return;
		}
		InputManager.I.OnTapEvent -= OnTap;
		InputManager.I.OnTapUpEvent -= OnTapUp;
		InputManager.I.OnTapDownEvent -= OnTapDown;	
	}

	void OnTap(){ isTapped = true; }
	void OnTapDown(){ isTapped = true; }
	void OnTapUp(){ isTapped = false; }
	 */

}

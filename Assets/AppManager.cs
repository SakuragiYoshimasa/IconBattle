using UnityEngine;
using System.Collections;

public class AppManager : Singleton<AppManager> {

	public AppStatus appStatus;

	void Awake(){
		appStatus = AppStatus.Title;
	}

	public void Login(){
		//if(logins){}
		appStatus = AppStatus.Ranking;
		GuiManager.I.Login();
	}


}

public enum AppStatus{
	Title,
	Ranking,
	Tactics,
	Profile,
	Game
}

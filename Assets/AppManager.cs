using UnityEngine;
using System.Collections;

public class AppManager : Singleton<AppManager> {

	public AppStatus appStatus;

	void Awake(){
		appStatus = AppStatus.Title;
	}


}

public enum AppStatus{
	Title,
	Ranking,
	Tactics,
	Profile,
	Game
}

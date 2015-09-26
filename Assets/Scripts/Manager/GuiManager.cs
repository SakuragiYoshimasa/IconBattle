using UnityEngine;
using System.Collections;

public class GuiManager : Singleton<GuiManager> {

	public GameObject titlePanel;
	public GameObject MenuPanel;

	public void Login(){
		titlePanel.SetActive(false);
		MenuPanel.SetActive(true);
	}
	

}

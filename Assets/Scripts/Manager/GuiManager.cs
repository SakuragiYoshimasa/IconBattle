using UnityEngine;
using System.Collections;

public class GuiManager : Singleton<GuiManager> {

	public GameObject titlePanel;
	public GameObject MenuPanel;

	public GameObject rankingPanel;
	public GameObject tacticsPanel;
	public GameObject profilePanel;
	public GameObject battlePanel;

	//-------------------------------------
	//Title
	//-------------------------------------
	public void Login(){
		titlePanel.SetActive(false);
		MenuPanel.SetActive(true);
	}

	//-------------------------------------
	//MainMenu
	//-------------------------------------
	public void Ranking(){
		rankingPanel.SetActive(true);
		tacticsPanel.SetActive(false);
		profilePanel.SetActive(false);
		battlePanel.SetActive(false);
	}
	public void Tactics(){
		rankingPanel.SetActive(false);
		tacticsPanel.SetActive(true);
		profilePanel.SetActive(false);
		battlePanel.SetActive(false);
	}
	public void Profile(){
		rankingPanel.SetActive(false);
		tacticsPanel.SetActive(false);
		profilePanel.SetActive(true);
		battlePanel.SetActive(false);
	}
	public void Battle(){
		rankingPanel.SetActive(false);
		tacticsPanel.SetActive(false);
		profilePanel.SetActive(false);
		battlePanel.SetActive(true);
	}
}

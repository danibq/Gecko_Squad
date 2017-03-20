using UnityEngine;
using System.Collections;

public class Scene_navigation : MonoBehaviour {

	public void Game()
	{
		Application.LoadLevel ("Game_scene");
	}

	public void Highscore()
	{
		Application.LoadLevel ("HighScore_scene");
	}

	public void Menu()
	{
		Application.LoadLevel ("Menu_scene");
	}

	public void Options()
	{
		Application.LoadLevel ("Options_scene");
	}

    

}

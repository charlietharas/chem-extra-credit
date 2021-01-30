using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLeave : MonoBehaviour
{
	public string levelElement;
	public void OnTriggerEnter2D()
	{
		PlayerPrefs.SetString("lastElement", levelElement);
		SceneManager.LoadScene("JustPlayed");
	}
}

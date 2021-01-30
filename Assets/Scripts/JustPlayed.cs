using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JustPlayed : MonoBehaviour
{
    public Text elementText;
	
	void Update()
	{
		// update text
		if (Input.GetKeyDown(KeyCode.R))
		{
			elementText.text = PlayerPrefs.GetString("lastElement");
		}
		
		// leave
		if (Input.GetKeyDown(KeyCode.Q))
		{
			SceneManager.LoadScene("LevelSelect");
		}

	}
}

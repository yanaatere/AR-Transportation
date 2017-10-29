using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EscapeOnScript : MonoBehaviour {


	public int index;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() {

		LoadByIndex(index);
	}

	public void LoadByIndex (int index)
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{

			SceneManager.LoadScene(index);

		}

	}
}
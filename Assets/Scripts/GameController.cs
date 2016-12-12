using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		EventManager.StartListening (EventTypes.quitGame, LoadScene0);
	}

	void OnDestroy() {
		EventManager.StopListening (EventTypes.quitGame, LoadScene0);
	}
	
	void LoadScene0() {
		SceneManager.LoadScene (0);
	}
}

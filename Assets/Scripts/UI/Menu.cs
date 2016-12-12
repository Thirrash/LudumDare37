using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {
    public GameObject plane;
    public Text text;
	public void Exit()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Credicts()
    {
        plane.SetActive(true);
        text.text = "Game created: \nPaweł Winiecki \nMariusz Sielicki\n Textures taken from:\n www.flaticon.com \nFrom username: \nFreepik\nMadebyoliver\nEucalyp\nIconnice";
    }
    public void Close()
    {
        plane.SetActive(false);
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatisticsUI : MonoBehaviour {
    public GameObject player;
    public Text text;
    private PlayerStatistics _stat;

	void Start () {
        player = Player.instance.gameObject;
        _stat = player.GetComponent<PlayerStatistics>();
	}
	
	void Update () {
        /*
        text.text = "Statistics\n" + "Max weight:  " + _stat.maxWeight + 
            "\n" + "Player speed\nFrom side to side: "+_stat.movementHorizontalSpeed+ 
            "\nFront back: "+_stat.movementVerticalSpeed + "\nSkill\nWood: "+ _stat.skills.woodSkill+
            "\n Stone: "+_stat.skills.stoneSkill +"\n Skin: "+ _stat.skills.skinSkill +"\nMetal: "+_stat.skills.metalSkill+
            "\n ManMade: "+ _stat.skills.manMadeSkill;
            */
        text.text = "Statistics\n" + "Max weight:  " + _stat.maxWeight +
        "\n" + "Player speed\nFrom side to side: " + _stat.movementHorizontalSpeed +
        "\nFront back: " + _stat.movementVerticalSpeed + "\nSkill: " + _stat.skills.generalSkill;

    }
}

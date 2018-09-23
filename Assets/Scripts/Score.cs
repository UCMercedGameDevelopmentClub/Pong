using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [SerializeField]
    Text score;
    [SerializeField]
    GameManager gmScript;
    void Start () {
        gmScript = GameObject.Find("GameManager").GetComponent<GameManager>();
		score = GetComponent<Text>();
        score.text = "0";
    }
    void Update () {
        score.text = gmScript.player1Points.ToString() + "           " + gmScript.player2Points.ToString();
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    string highscore = "HighScore";

    Text highscoreText;
	// Use this for initialization
	void Start () {
        highscoreText = GameObject.Find("highscore").GetComponent<Text>();
        Text myText = GetComponent<Text>();
        myText.text = "Score: ";
        myText.text += ScoreKeeper.score.ToString();

        if (ScoreKeeper.score > PlayerPrefs.GetInt(highscore)) {
            PlayerPrefs.SetInt(highscore, ScoreKeeper.score);
        }

        highscoreText.text = "High Score: ";
        highscoreText.text += PlayerPrefs.GetInt(highscore).ToString();

        ScoreKeeper.Reset();
	}
	
}


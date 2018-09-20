using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    // Use this for initialization
    void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");

        }
        PlayerPrefs.SetInt("HighScore",score);
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "HightScore" + score;
        if(score>PlayerPrefs.GetInt("High Score"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}

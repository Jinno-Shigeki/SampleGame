using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    private void Update()
    {
        // Singleton
        int score = GameManager.Instance.Score;
        scoreText.text = $"Score: {score.ToString()}";
    }
}

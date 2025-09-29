using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private Scorer scorer;

    private void Update()
    {
        scoreText.text = $"Total Hits: {scorer.GetHitCount()}";
    }
}

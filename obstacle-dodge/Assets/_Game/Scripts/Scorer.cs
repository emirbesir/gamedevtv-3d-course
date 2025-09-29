using UnityEngine;

public class Scorer : MonoBehaviour
{
    private const string HIT_TAG = "Hit";

    private int hits;

    private void Awake()
    {
        hits = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != HIT_TAG)
        {
            hits++;
            Debug.Log("Hits: " + hits);
        }
    }
}

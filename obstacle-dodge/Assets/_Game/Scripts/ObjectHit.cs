using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    private const string HIT_TAG = "Hit";

    [Header("Material Config")]
    [SerializeField] private Material hitMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == PLAYER_TAG)
        {
            GetComponent<MeshRenderer>().material = hitMaterial;
            gameObject.tag = HIT_TAG;
        }
    }
}

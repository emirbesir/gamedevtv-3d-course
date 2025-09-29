using UnityEngine;

public class TriggerProjectiles : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] private GameObject parentOfProjectiles;

    private void Awake()
    {
        parentOfProjectiles.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == PLAYER_TAG)
        {
            parentOfProjectiles.SetActive(true);
        }
    }
}

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FlyAtPlayer : MonoBehaviour
{
    private const float DESTROY_DISTANCE = 0.05f;

    [Header("Speed Config")]
    [SerializeField] private float moveSpeed;
    [Header("Reference")]
    [SerializeField] private Transform player;

    private Vector3 playerPosition;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        playerPosition = player.transform.position;
    }

    private void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        rb.linearVelocity = (playerPosition - transform.position).normalized * moveSpeed;
        if (Vector3.Distance(transform.position, playerPosition) <= DESTROY_DISTANCE)
        {
            Destroy(gameObject);
        }
    }
}

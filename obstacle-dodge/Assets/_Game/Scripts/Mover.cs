using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{   
    [Header("Speed Config")]
    [SerializeField] private float moveSpeed;

    private Vector3 moveInput;
    private Rigidbody rb;

    private void Awake()
    {
        moveInput = new Vector3();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");
    
        Vector3 moveDir = moveSpeed * moveInput.normalized;
        rb.linearVelocity = new Vector3(moveDir.x, rb.linearVelocity.y, moveDir.z);
    }
}

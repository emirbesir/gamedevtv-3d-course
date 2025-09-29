using UnityEngine;

public class Mover : MonoBehaviour
{   
    [Header("Movement Speed")]
    [SerializeField] private float moveSpeed;

    private Vector3 moveInput;

    private void Awake()
    {
        moveInput = new Vector3();
    }

    private void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");
    
        Vector3 moveDir = moveSpeed * Time.deltaTime * moveInput.normalized;
        transform.Translate(moveDir);
    }
}

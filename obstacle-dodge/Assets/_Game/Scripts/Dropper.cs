using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(MeshRenderer))]
public class Dropper : MonoBehaviour
{   
    [Header("Drop Config")]
    [SerializeField] private float timeBeforeDrop;

    private Rigidbody rb;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        rb.useGravity = false;
        meshRenderer.enabled = false;
    }

    private void Update()
    {
        if (Time.time > timeBeforeDrop)
        {
            rb.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}

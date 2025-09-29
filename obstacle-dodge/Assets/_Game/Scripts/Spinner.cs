using UnityEngine;

public class Spinner : MonoBehaviour
{   
    [Header("Rotation Speed Config")]
    [SerializeField] private float xAngle;
    [SerializeField] private float yAngle;
    [SerializeField] private float zAngle;

    private void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}

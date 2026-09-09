using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    private float dropperTimer = 3.0f;
    private Rigidbody rb;
    private MeshRenderer meshRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        rb.useGravity = false;
        meshRenderer.enabled = false;
    }
    void Update()
    {
        if (Time.time > dropperTimer)
        {
            Debug.Log(dropperTimer + " seconds elapsed!");
            rb.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}

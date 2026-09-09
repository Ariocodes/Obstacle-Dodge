using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    private float xRotate = 0;
    [SerializeField]
    private float yRotate = 0;
    [SerializeField]
    private float zRotate = 0;


    void Update()
    {   
        transform.Rotate(xRotate * Time.deltaTime, yRotate * Time.deltaTime, zRotate * Time.deltaTime);
    }
}

using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Something hit me!");
        GetComponent<MeshRenderer>().material.color = Color.red;
        
    }
}

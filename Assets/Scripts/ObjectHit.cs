using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Something hit me!");
        if (other.gameObject.CompareTag("Player")) // also: other.gameObject.tag == "Player"
        {
            // Debug.Log("Player hit me!");
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
        
    }
}

using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitNumber = 0;


    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            hitNumber++;
            Debug.Log("You've bumped into " + hitNumber + " objects.");
        }
    }
}

using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitNumber = 0;


    void OnCollisionEnter(Collision collision)
    {
        hitNumber++;
        Debug.Log("You've bumped into a thing this many times: " + hitNumber);
    }
}

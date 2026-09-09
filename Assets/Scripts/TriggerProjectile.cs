using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] 
    GameObject projectiles;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            projectiles.SetActive(true);
        }
    }
}

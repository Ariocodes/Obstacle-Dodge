using UnityEngine;

public class TriggerDropBox : MonoBehaviour
{
    [SerializeField]
    GameObject box;


    void Awake()
    {
        box.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            box.SetActive(true);
            Destroy(gameObject);
        }
    }
}

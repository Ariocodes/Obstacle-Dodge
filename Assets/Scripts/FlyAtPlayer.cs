using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField]
    private float flySpeed = 1f;

    [SerializeField]
    Transform player;
    Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.transform.position; // since it's the transform object, it returns itself when .transform is used.
        // playerPosition = player.position; // BOTH WORK
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, flySpeed * Time.deltaTime);
    }
}

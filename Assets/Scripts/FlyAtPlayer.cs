using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField]
    private float flySpeed = 1f;

    [SerializeField]
    Transform player;
    Vector3 playerPosition;


    void Awake()
    {
        // we only need this one to run the moment game starts. otherwise the player position will be saved wrongly
        gameObject.SetActive(false); 
    }


    void Start()
    {
        playerPosition = player.transform.position; // since it's the transform object, it returns itself when .transform is used.
        // playerPosition = player.position; // BOTH WORK
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, flySpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (Vector3.Distance(transform.position, playerPosition) < 0.01f)
        { // "transform.position == playerPosition" might be TOO precise to work sometimes.
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }
}

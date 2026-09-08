using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }


    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the arrow keys or WASD to move the player.");
        Debug.Log("Don't bump into obstacles!");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}

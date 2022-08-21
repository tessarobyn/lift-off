using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerControlMovement movement;
    public GameObject trail;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Planet")
        {
            Destroy(trail);
            movement.enabled = false;
            gameManager.EndGame();
        }
    }
}

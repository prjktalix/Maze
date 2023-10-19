using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerBehavior playerController = other.GetComponent<PlayerBehavior>();

            if (playerController != null)
            {
                playerController.IsGrounded = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerBehavior playerController = other.GetComponent<PlayerBehavior>();

            if (playerController != null)
            {
                playerController.IsGrounded = false;
            }
        }
    }
}
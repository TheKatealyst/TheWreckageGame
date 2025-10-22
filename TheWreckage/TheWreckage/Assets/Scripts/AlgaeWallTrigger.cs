using UnityEngine;

public class AlgaeWallTrigger : MonoBehaviour
{
    private bool playerInside = false;
    private Animator[] childAnimators;

    void Start()
    {
        // Get all Animator components in children once at startup
        childAnimators = GetComponentsInChildren<Animator>();
    }

    void Update()
    {
        // Only trigger when player is inside and right mouse button is pressed
        if (playerInside && Input.GetMouseButtonDown(1))
        {
            TriggerAllAnimations();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Detect the player entering
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Detect the player leaving
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
   
    private void TriggerAllAnimations()
    {
        foreach (Animator animator in childAnimators)
        {
            // Option 1: trigger parameter (recommended)
            Debug.Log("Triggering: " + animator.gameObject.name);
            animator.SetTrigger("SonarDetected");

            // Option 2: play a specific state directly (alternative)
            // animator.Play("ActivateAnimation", 0, 0f);
        }
    }
}

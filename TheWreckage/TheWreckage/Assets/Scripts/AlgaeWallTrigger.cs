using UnityEngine;
using System.Collections;

public class AlgaeWallTrigger : MonoBehaviour
{
    private bool playerInside = false;
    private Animator[] childAnimators;
    public Collider parentCollider;

    void Start()
    {
        // Get all Animator components from children (including this object's children)
        childAnimators = GetComponentsInChildren<Animator>();

        if (parentCollider == null)
            Debug.LogError("[AlgaeWallTrigger] No collider found in parent of " + gameObject.name);
        else
            Debug.Log("[AlgaeWallTrigger] Found parent collider: " + parentCollider.name);
    }

    void Update()
    {
        if (playerInside && Input.GetMouseButtonDown(1))
        {
            TriggerAllAnimations();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInside = true;
    }
/*
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInside = false;
    }
*/
    private void TriggerAllAnimations()
    {
        foreach (Animator animator in childAnimators)
        {
            animator.SetTrigger("SonarDetected");
        }

        // Disable parent collider
        if (parentCollider != null)
        {
            parentCollider.enabled = false;
        }
    }
}


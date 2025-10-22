using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;

    private void Update()
    {

    }

    //Test function to Trigger dialogue for this actor by pressing space.
    public void SpeakTo()
    {
        DialogueManager.Instance.StartDialogue(Name, Dialogue.RootNode);
    }
    //Actual Trigger which can be set to this specific zone.
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered has the tag "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            SpeakTo();
        }
    }
}
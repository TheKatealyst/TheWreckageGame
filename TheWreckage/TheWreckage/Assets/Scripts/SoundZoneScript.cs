using UnityEngine;

public class SoundZoneScript : MonoBehaviour
{
    public AudioSource AudioSource; //The music that we're going to play
    bool musicPlay;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered has the tag "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.Stop();
        }
    }
}

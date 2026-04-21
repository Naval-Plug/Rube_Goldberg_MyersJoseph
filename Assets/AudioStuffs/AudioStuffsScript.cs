using Unity.VisualScripting;
using UnityEngine;

public class AudioStuffsScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] mySounds;

    private AudioClip activeSound;

    // Update is called once per frame
    void Update()
    {

        

    }
    private void OnCollisionEnter(Collision other)
    {
        activeSound = mySounds[Random.Range(0, mySounds.Length)];

        // Plays Sound

        audioSource.PlayOneShot(activeSound);
    }


}
        
    




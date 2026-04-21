using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject explo;
    public GameObject bob;
    public AudioSource audioSource; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    private void OnTriggerEnter(Collider other)
    {

        explo.SetActive(true);
        bob.SetActive(false);
        audioSource.Play();

    }
}

using UnityEditor;
using UnityEngine;

public class SkibidiSigma : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject bob;
    public GameObject ball;
    public GameObject cam;
    public GameObject camOG;
    private bool balls = false;
    void Start()
    {
       //  GameObject instance = Instantiate(bob);
    }

        

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody rb))
        {
            bob.SetActive(true);
            balls = true;
            cam.SetActive(true);
            camOG.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (balls == true)
        {
            ball.transform.localScale += new Vector3(0.02f,0.02f, 0.02f);
        }
        
    }
}

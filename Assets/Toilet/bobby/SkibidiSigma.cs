using UnityEditor;
using UnityEngine;

public class SkibidiSigma : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject bob;
    public GameObject ball;
    private bool balls = false;
    void Start()
    {
        GameObject instance = Instantiate(bob);
    }

        

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody rb))
        {
            bob.SetActive(true);
            balls = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (balls == true)
        {
            ball.transform.localScale += new Vector3(0.1f,0.1f, 0.1f);
        }
        
    }
}

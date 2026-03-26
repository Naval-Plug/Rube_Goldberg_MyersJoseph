using UnityEngine;

public class bang : MonoBehaviour
{
    public Rigidbody diddy;
    bool publicc = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Timer", 5);
        if (publicc == false)
        {
            diddy.AddForce(transform.forward * 300000 * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
       
       

       
    }

    void Timer()
    {
        publicc = true;

    }
}

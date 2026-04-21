using UnityEngine;

public class SkibidiToiletEpisode80fullenglishsubtitlesnoads : MonoBehaviour
{
    public Rigidbody rb;
    private int times = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (gameObject.transform.position.y < -20)
        {
            times++;
            Debug.Log(times);
          transform.Translate(0,1 * Time.deltaTime,0);
            transform.Rotate(0, 500 * Time.deltaTime, 0);
            transform.localScale += new Vector3(0.001f,0.001f, 0.001f);
        }
       
    }
}

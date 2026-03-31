using Unity.VisualScripting;
using UnityEngine;
using Unity.Collections;


public class Gyyaaaaaat : MonoBehaviour
{
    public bool changeColor = false;
    public bool coolDown = true;
    private void OnCollisionEnter(Collision other)
    {
      changeColor = true;
    }
    private void Update()
    {
        if (changeColor)
        {
            if(coolDown == true)
            {
             Invoke("Change", 0.1f);
                coolDown = false;
            }
            
        }
        
    }
    void Change()
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        coolDown = true;
    }

}

using Unity.VisualScripting;
using UnityEngine;
using Unity.Collections;

public class Gyyaaaaaat : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        bool hit = true;
    }

  
}

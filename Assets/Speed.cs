using UnityEngine;


    public class SpeedPad : MonoBehaviour
    {
        public float boostForce = 500f; // Adjustable force amount in the Inspector
        public Vector3 boostDirection = Vector3.forward; // The direction of the boost

        // This function is called when another collider enters the trigger collider attached to this object
        private void OnTriggerEnter(Collider other)
        {
            // Check if the object entering the trigger has a Rigidbody component
            Rigidbody otherRigidbody = other.GetComponent<Rigidbody>();

            if (otherRigidbody != null)
            {
                // Optional: Check for a specific tag (e.g., "Player" or "Plane") if needed
                // if (other.CompareTag("Plane"))
                // {
                // Apply force to the object's Rigidbody in the specified direction
                otherRigidbody.AddForce(transform.TransformDirection(boostDirection) * boostForce, ForceMode.Impulse);
                // }
            }
        }
    }
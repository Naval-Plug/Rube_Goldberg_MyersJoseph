using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 15f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody rb))
        {
            // Reset vertical velocity so the jump is consistent
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

            // Launch upward based on pad's orientation
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }
}
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private bool _isGrounded;

    private void OnCollisionEnter(Collision collision)
    {
        _isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _isGrounded = false;
    }
}

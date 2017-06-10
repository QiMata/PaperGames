using UnityEngine;

public class FocussedCommands : MonoBehaviour
{

    private Rigidbody rbody;

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect(Ray ray)
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
           rbody = this.gameObject.AddComponent<Rigidbody>();
        }

        rbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rbody.AddForce(ray.direction * 1000.0f);
    }
}

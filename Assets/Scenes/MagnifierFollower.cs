using UnityEngine;

public class MagnifierFollower : MonoBehaviour
{
    public Transform lens; // glass-objekti
    public Transform vrCamera; // XR Origin Main Camera

    void LateUpdate()
    {
        // Kamera sijaitsee lasin kohdalla
        transform.position = lens.position;

        // Kamera katsoo aina siihen suuntaan, mihin VR-kamera katsoo
        transform.rotation = Quaternion.LookRotation(
            vrCamera.forward,
            vrCamera.up
         );
    }
}

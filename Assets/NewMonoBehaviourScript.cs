using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Vector3 moveVector;
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        transform.position += moveVector;
    }
}

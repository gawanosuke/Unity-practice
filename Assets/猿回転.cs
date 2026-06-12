using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public Vector3 rotateSpeed = new Vector3(0, 90, 0);

    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
    }
}

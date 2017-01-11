using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour
{
    private void Update()
    {
        transform.RotateAround( Vector3.zero, Vector3.up, 30 * Time.deltaTime );
    }
}

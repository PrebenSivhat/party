using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public void Move(Rigidbody2D rbody, float input_x, float input_y, float speed) {
        rbody.velocity = new Vector2(Mathf.Lerp(0, input_x, speed), Mathf.Lerp(0, input_y, speed));
    }

    public void Rotate(float inputX, float inputY, float speed) {
        gameObject.transform.Rotate(new Vector3(0, 0, Mathf.Lerp(gameObject.transform.rotation.z, inputY - inputX, speed)));
    }

}
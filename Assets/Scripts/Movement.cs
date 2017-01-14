using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
    {
    private static Rigidbody2D rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    public static void Move(float input_x, float input_y, float speed)
        {
            rbody.velocity = new Vector2(Mathf.Lerp(0, input_x*speed, 0.8f),
                Mathf.Lerp(0, input_y*speed, 0.8f));
        }

        public static void Rotate(float inputX, float inputY, float speed)
        {
            
            rbody.transform.Rotate(new Vector3(0, 0, inputY - inputX));
        }

    }
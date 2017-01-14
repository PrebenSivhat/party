using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour

    {
    private Rigidbody2D _rbody;

    private void Start() {
        _rbody = GetComponent<Rigidbody2D>();
    }

    public void Move(float input_x, float input_y, float speed) {
        _rbody.velocity = new Vector2(Mathf.Lerp(0, input_x, speed), Mathf.Lerp(0, input_y, speed));
    }

    public void Rotate(float inputX, float inputY, float speed) {
        _rbody.transform.Rotate(new Vector3(0, 0, Mathf.Lerp(_rbody.transform.rotation.z, inputY - inputX, speed)));
    }

    }

// <Suchiman> MartinKragh: another weird thing with your paste is, is that you're calling an instance method but i can't see the declaration of the object instance

//What is generally the best way to use a class in another class? / inherit
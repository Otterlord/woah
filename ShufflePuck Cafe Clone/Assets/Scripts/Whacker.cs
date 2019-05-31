using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whacker : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(-Input.GetAxisRaw("Mouse X") * speed, 0, -Input.GetAxisRaw("Mouse Y") * speed);
    }
}

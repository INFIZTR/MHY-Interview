using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    [SerializeField] private Transform respawnpoint;
    [SerializeField] CharacterController controller;
    [SerializeField] Transform cameraParent;
    private Vector3 moveVecor;
    public float walkSpeed;
    public float runSpeed = 10f;
    public float mouseSensitivity;
    public float jumpSpeed = 5f;
    public float gravitySpeed = .2f;
    public float jumpDuration = .3f;
    private float jumpEndTime;
    private float speed;
    private float yRot;
    private float xRot;

    public float counter = 0;

    private void Start()
    {
        speed = walkSpeed;
        //initializing xRot and yRot
        yRot = cameraParent.localEulerAngles.y;
        xRot = cameraParent.localEulerAngles.x;
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void CameraMovement() {
        yRot += Input.GetAxis("Mouse X") * mouseSensitivity;
        xRot -= Input.GetAxis("Mouse Y") * mouseSensitivity * .3f;

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);
        cameraParent.localEulerAngles = new Vector3(Mathf.Clamp(xRot, -90f, 90f), cameraParent.localEulerAngles.y, cameraParent.localEulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        CameraMovement();
        FixedUpdate();
         moveVecor = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) {
            moveVecor += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveVecor -= transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveVecor += transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVecor -= transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            speed = runSpeed;
        } else if (Input.GetKeyUp(KeyCode.LeftShift)) {
            speed = walkSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > jumpEndTime) {
            jumpEndTime = Time.time + jumpDuration;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(moveVecor.normalized * speed);
        if (Time.time < jumpEndTime) {
            controller.Move(Vector3.up * jumpSpeed);
        }
        controller.Move(Vector3.down * gravitySpeed);
    }

    public void respawn()
    {
        Vector3 point = respawnpoint.transform.position;
        counter++;
        //transform.position = respawnpoint.transform.position;
        transform.Translate(point);
    }
}

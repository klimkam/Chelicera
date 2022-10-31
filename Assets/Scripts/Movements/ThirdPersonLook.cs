using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonLook : MonoBehaviour
{

    [SerializeField] private float _mouseSensitivity = 100f;
    [SerializeField] private Transform _playerBody;
    private float _xRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;

        _playerBody.Rotate(Vector3.up * mouseX);
    }
}

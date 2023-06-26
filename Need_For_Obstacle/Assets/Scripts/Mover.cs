using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 30;
    [SerializeField] float _rotateAmount = 350;

    private void Update()
    {
        MoveCar();
    }

    void MoveCar()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float zMove = verticalInput * Time.deltaTime * _moveSpeed;
        float yRotation = horizontalInput * Time.deltaTime * _rotateAmount;

        //If car goes backward, rotate opposite way 
        if(verticalInput < 0)
        {
            yRotation *= -1;
        }


        transform.Rotate(0, yRotation, 0, Space.Self);
        transform.Translate(0, 0, zMove, Space.Self);
    }
}

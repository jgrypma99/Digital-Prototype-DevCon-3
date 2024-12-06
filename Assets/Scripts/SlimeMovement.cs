using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    public Vector3 _currentPosition;
    public float _currentMovePause;
    public Quaternion _currentRotation;

    public float _horizontalMoveInput;
    public float _verticalMoveInput;
    public bool _movingHorizontal;

    public bool _lockPosition;
    public Rigidbody _rigidbody;

    public bool _rotateButtonPressed;

    void Start()
    {

        _movingHorizontal = false;
        _lockPosition = false;
        
        _currentPosition = transform.position;
        _currentRotation = Quaternion.Euler(0, 0, 0);
        _currentMovePause = GameManager._currentTimerValue;
    }

    void Update()
    {
        Countdown();

        _rotateButtonPressed = 
            Input.GetButton("Rotate_Toggle");
    }

    private void MoveSlime()
    {

        Debug.Log("MoveSlime");

        if (_lockPosition == true)
            return;

        if (_rotateButtonPressed == true)
        {
            RotateSlimeVertical();
        }

        if (_lockPosition == true)
            return;

        if (_rotateButtonPressed == false)
        {
            MoveSlimeHorizontal();
            MoveSlimeVertical();
        }



        if (transform.position.y == 0)
        {
            FreezeConstraints();

            return;
        }

        if (_movingHorizontal == true)
            return;

        _currentPosition = transform.position;
        _currentPosition.y -= 1;
        transformation.position = _currentPosition;
    }

    private void Countdown()
    {

        Debug.Log("Countdown");

        _currentMovePause -=
            GameManager._currentTimerValue * Time.deltaTime;

        if(_currentMovePause < 0)
            _currentMovePause = 0;

        if (_currentMovePause == 0 &&
            _movingHorizontal == true)
        {
            _currentMovePause = GameManager._currentTimerValue;
            _movingHorizontal = false;
        }

        if (_currentMovePause == 0)
        {
            MoveSlime();

            _currentMovePause = GameManager._currentTimerValue;
        }
    }

    private void MoveSlimeHorizontal()
    {

        Debug.Log("MoveSlimeHorizontal");

        _horizontalMoveInput =
            Input.GetAxis("Movement_Horizontal");

        if (_horizontalMoveInput > 0 &&
            _currentMovePause == 0)
        {
            _movingHorizontal = true;

            _currentPosition = transform.position;
            _currentPosition.x += 1;
            transform.position = _currentPosition;
        }
         if ( _horizontalMoveInput < 0 &&
            _currentMovePause == 0)
        {
            _movingHorizontal = true;
            _currentPosition = transform.position;
            _currentPosition.x -= 1;
            transform.position = _currentPosition;

        }

    }

    private void MoveSlimeVertical()
    {

        Debug.Log("MoveSlimeVertical");

        _verticalMoveInput =
            Input.GetAxis("Movement_Vertical");

        if (_verticalMoveInput > 0 &&
            _currentMovePause == 0)
        {
            _movingHorizontal = true;

            _currentPosition = transform.position;
            _currentPosition.z += 1;
            transform.position = _currentPosition;
        }
        if (_verticalMoveInput < 0 &&
           _currentMovePause == 0)
        {
            _movingHorizontal = true;
            _currentPosition = transform.position;
            _currentPosition.z -= 1;
            transform.position = _currentPosition;

        }

    }

    public void SlimeRotateVertical()
    {
        Debug.Log("SlimeRotateVertical");

        _verticalMoveInput =
            Input.GetAxis("Movement_Vertical");


    }



}

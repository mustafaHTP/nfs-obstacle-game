using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMover : MonoBehaviour
{
    [SerializeField] float waitToStop = 20;
    [SerializeField] float _moveTime = 10;
    [SerializeField] float _moveAmount = 20;
    [SerializeField] Vector3 _oldLocation;
    [SerializeField] Vector3 _targetLocation;
    [SerializeField] Vector3 _targetDirection;

    // Start is called before the first frame update
    void Start()
    {
        _oldLocation = transform.localPosition;
        _targetLocation = new Vector3(_oldLocation.x, _oldLocation.y, _oldLocation.z + _moveAmount);

        /*_targetDirection = _targetLocation - _oldLocation;
        float _magnitude = _targetDirection.magnitude;

        //normalize vector to get direction
        _targetDirection = _targetDirection / _magnitude; */
        _targetDirection = Vector3.forward;


    }

    // Update is called once per frame
    void Update()
    {
        //Human only moves z axis !!!
        if(Time.time < waitToStop)
        {
            transform.Translate(_targetDirection * Time.deltaTime * (_moveAmount / _moveTime));

        }
    }
}

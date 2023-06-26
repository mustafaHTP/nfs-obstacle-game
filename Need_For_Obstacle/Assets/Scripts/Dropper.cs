using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitToDrop = 3;

    Rigidbody _rigibody;

    void Start()
    {
        _rigibody = this.GetComponent<Rigidbody>();
        _rigibody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitToDrop)
        {
            _rigibody.useGravity = true;

        }

    }
}

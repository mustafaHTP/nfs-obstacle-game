using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float _rotateAmount = 600;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _rotateAmount * Time.deltaTime, 0,Space.Self);
    }
}

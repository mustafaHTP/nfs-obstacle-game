using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerBack : MonoBehaviour
{
    [SerializeField] float _rotateAmount = 600;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotateAmount * Time.deltaTime, 0, 0, Space.Self);
    }
}

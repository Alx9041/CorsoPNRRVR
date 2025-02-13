using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward*5, ForceMode.VelocityChange);
    }

}

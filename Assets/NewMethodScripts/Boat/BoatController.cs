using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BoatController : MonoBehaviour
{
    
    [SerializeField] private ParticleSystem splash;
	[SerializeField] private float ForwardForce = 10;
	[SerializeField] private float TurningTorque = 50;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Forward Force
        if (Input.GetKey(KeyCode.W)) 
        {
            GoForward();
        }else{
            splash.Stop();
        }
        
       
    }

    void GoForward()
    {
        _rigidbody.AddForce(transform.forward * ForwardForce, ForceMode.Acceleration);
        splash.Play();
        /*Vector3 torque = torque = new Vector3(0, TurningTorque, 0);
        rigidbody.AddTorque(torque);*/
    }
}

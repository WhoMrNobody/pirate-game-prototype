using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class BoatController : MonoBehaviour
{
    [SerializeField] private ParticleSystem splash;
	//[SerializeField] private float forwardForce = 100f;
	[SerializeField] private float turningTorque = 50f;
    
    private Rigidbody _rigidbody;
    private ConstantForce _constantForce;
    
    private void Awake() {

        _rigidbody = GetComponent<Rigidbody>(); 
        _constantForce = GetComponent<ConstantForce>();
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward(float forwardForce)
    {
        _constantForce.force = new Vector3(0f, 0f, forwardForce);
        splash.Play();
        
        /*Vector3 torque = torque = new Vector3(0, TurningTorque, 0);
        rigidbody.AddTorque(torque);*/
    }

}

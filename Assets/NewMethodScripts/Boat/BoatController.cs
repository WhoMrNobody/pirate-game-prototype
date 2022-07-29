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
    private void Awake() {

        _rigidbody = GetComponent<Rigidbody>();

       /* _move = _playerInput.actions["MoveForward"];
        _move.ReadValue<int>();*/
        
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward()
    {

        _rigidbody.AddForce(transform.forward * ForwardForce, ForceMode.Acceleration);
        splash.Play();
        Debug.Log("Button clicked");

        
        /*Vector3 torque = torque = new Vector3(0, TurningTorque, 0);
        rigidbody.AddTorque(torque);*/
    }

}

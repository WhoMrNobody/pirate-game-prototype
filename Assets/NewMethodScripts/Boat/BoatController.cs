using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class BoatController : MonoBehaviour
{
    [SerializeField] private ParticleSystem splash;
	[SerializeField] private float ForwardForce = 10;
	[SerializeField] private float TurningTorque = 50;
    
    private Rigidbody _rigidbody;
    private PlayerInput _playerInput;
    private InputAction _move;
    

    // Start is called before the first frame update
    private void Awake() {

        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();

        _move = _playerInput.actions["MoveForward"];
        _move.ReadValue<int>();
        
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(_move.triggered){

            _move.started += context => OnMoveForward(context);
        }
        
    }

    void OnMoveForward(InputAction.CallbackContext ctx)
    {
        _rigidbody.AddForce(ctx.ReadValue<Vector2>() * ForwardForce, ForceMode.Acceleration);
        splash.Play();
        Debug.Log("Button clicked");
        /*Vector3 torque = torque = new Vector3(0, TurningTorque, 0);
        rigidbody.AddTorque(torque);*/
    }

    private void OnEnable() {

        _move.Enable();
        
    }

    private void OnDisable() {

        _move.Disable();
        
    }
}

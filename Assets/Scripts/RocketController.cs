using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    private EnergySystem _energySystem;
    private RocketMovement _rocketMovement;
    
    private bool _isMoving;
    private Vector2 _movementDirection;
    
    private void Awake()
    {
        _energySystem = GetComponent<EnergySystem>();
        _rocketMovement = GetComponent<RocketMovement>();
    }

    // TODO : OnMove 구현
    // private void OnMove...
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>().normalized;
        _rocketMovement.ApplyMovement(moveInput);
    }


    // TODO : OnBoost 구현
    // private void OnBoost...
    public void OnBoost(InputAction.CallbackContext context)
    {
        _rocketMovement.ApplyBoost(context.performed);
    }
}
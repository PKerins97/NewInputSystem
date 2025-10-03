using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerInputAction _input;

    private void Start()
    {
        _input = new PlayerInputAction();
        _input.Player.Enable();
        
    }

    private void Update()
    {
        CalculateMovement();
    }
   void CalculateMovement()
    {
        //poll or check input readings
        var move = _input.Player.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 3.0f);
        //transform.Translate(move * Time.deltaTime * 3.0f);
    }
}

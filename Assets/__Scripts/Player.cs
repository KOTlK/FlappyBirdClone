using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1;

    private readonly float _negativeJumpForce = 50;
    private readonly float _positiveJumpForce = 25;
    private Rigidbody _rb;

    public static Player S;
    public PlayerState State;

    private void Start()
    {
        if (S == null)
        {
            S = this;
            S.State = PlayerState.Alive;
        }
        else
        {
            throw new System.NullReferenceException();
        }

        _rb = S.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector2 pos = S.transform.position;
        pos.x += _moveSpeed * Time.deltaTime;
        S.transform.position = pos;
    }

    public void Jump()
    {
        float jumpForce = _rb.velocity.y < 0 ? _negativeJumpForce : _positiveJumpForce;
        
        _rb.AddForce(new Vector2(0, jumpForce), ForceMode.VelocityChange);
    }

    public void Die()
    {
        S.State = PlayerState.Dead;
        Destroy(S.gameObject);
        GameState.PauseOnDeath();
    }
}

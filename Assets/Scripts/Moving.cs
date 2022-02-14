using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : BaseState
{
    private MovementSM _sm;
    private float _horizontalInput;
    private float _verticalInput;

    public Moving(MovementSM stateMachine) : base("Moving", stateMachine)
    {
        _sm = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        _horizontalInput = 0f;
        _verticalInput = 0f;

        // _sm.spriteRenderer.color = Color.red;
        //_sm.mymat.SetVector("_EmissionColor", new Vector4(0, 0,255, 10));
        GameObject.Find("Cube_6").GetComponent<Renderer>().material.SetVector("_EmissionColor", new Vector4(0, 0, 255, 10)); ;
        //Random.Range(0f, 255f)
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(_horizontalInput) < Mathf.Epsilon  )
            stateMachine.ChangeState(_sm.idleState);
        if (Mathf.Abs(_verticalInput) < Mathf.Epsilon)
            stateMachine.ChangeState(_sm.movingState);

    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Vector3 vel = _sm.rigidbody.velocity;
        vel.x = _horizontalInput * _sm.speed;
        vel.y = _verticalInput * _sm.speed;
        Debug.Log(vel);
        _sm.rigidbody.velocity = vel;
    }
}
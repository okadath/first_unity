using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Idle : BaseState
{
    private MovementSM _sm;
    private float _horizontalInput;
    private float _verticalInput;

    // public Material mymat;
    public Idle(MovementSM stateMachine) : base("Idle", stateMachine)
    {
        _sm = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        _horizontalInput = 0f;
        _verticalInput = 0f;
        // _sm.spriteRenderer.color = Color.black;
        // _sm.mymat = GetComponent<Renderer>().material;
        //mymat.SetColor("_EmissionColor", Color.blue


        //_sm.mymat.SetVector("_EmissionColor", new Vector4(255, 255, 0, 10));
        GameObject.Find("Cube_6").GetComponent<Renderer>().material.SetVector("_EmissionColor", new Vector4( 255, 255, 0,10)); ;

    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        if (Mathf.Abs(_horizontalInput) > Mathf.Epsilon)
            stateMachine.ChangeState(_sm.movingState);
        if (Mathf.Abs(_verticalInput) > Mathf.Epsilon)
            stateMachine.ChangeState(_sm.movingState);
        // mymat.SetVector("_EmissionColor", new Vector4(255, 255, 0, 10));

    }
}
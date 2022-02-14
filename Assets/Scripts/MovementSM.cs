using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    [HideInInspector]
    public Idle idleState;
    [HideInInspector]
    public Moving movingState;
    public Rigidbody rigidbody;
    public float speed = 4f;
   // public GameObject go;

    public Material mymat;
    //public SpriteRenderer spriteRenderer;
    private void Awake()
    {
        idleState = new Idle(this);
        movingState = new Moving(this);
    }
     //void Start()
    //{
       // go = this.gameObject;
        //mymat= GetComponent<Material>();
    //}


    protected override BaseState GetInitialState()
    {
        return idleState;
    }
}
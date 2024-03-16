using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [Header("Weapon Data")] 
    public Projectile Projectile;
    
    [Header("States")]
    public State MoveState;
    public State DeathState;

    public State CurrentState {
        get => _currentState;
        set => Transition(value);
    }
    public State _currentState;

    public Vector2 Movement;
    public float MoveSpeed = 5;

    private void Start() {
        CurrentState = MoveState;
    }

    private void Update() {
        _currentState?.Do();

        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        _currentState?.FixedDo();
    }

    private void Transition(State newState) {
        if (_currentState == newState) return;
        
        _currentState?.Exit();
        _currentState = newState;
        _currentState?.Enter();
    }

    public void DoFire() {
        var projectileInstance = Instantiate(Projectile, transform.position, transform.rotation);
    }
}

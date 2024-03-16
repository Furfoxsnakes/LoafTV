using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : State {
    [SerializeField] private Player _player;
    [SerializeField] private Rigidbody2D _body;

    public override void Enter() {
        Debug.Log("Entered Move State");
    }

    public override void Do() {
        if (Input.GetButton("Fire1"))
            _player.DoFire();
    }

    public override void FixedDo() {
        _body.MovePosition((Vector2)_body.transform.position + _player.Movement * _player.MoveSpeed * Time.fixedDeltaTime);
        LookAtMouse();
    }

    private void LookAtMouse() {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        _player.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

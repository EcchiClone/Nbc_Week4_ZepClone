using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private CharacterStatsHandler _stats;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementDirection = Vector2.zero;

    [SerializeField] private SpriteRenderer characterRenderer;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _stats = GetComponent<CharacterStatsHandler>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        // 컨트롤러에 구독
        _controller.OnMoveEvent += Move;
        _controller.OnLookEvent += Look;

    }
    private void FixedUpdate()// 물리처리가 끝난 뒤에 호출
    {
        ApplyMovement(_movementDirection);
    }
    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * _stats.CurrentStats.speed;
        _rigidbody.velocity = direction;
    }
    public void Look(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }
    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

}

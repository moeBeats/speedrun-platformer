using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] LayerMask _groundLayer;
    [SerializeField] float _checkHeight;
    Collider2D _collider;
    void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }
    void Update()
    {
        IsGrounded();
    }
    public bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(_collider.bounds.center, _collider.bounds.size, 0f, Vector2.down, _checkHeight, _groundLayer);

        Color rayColor;
        if (raycastHit.collider != null)
            rayColor = Color.green;
        else
            rayColor = Color.red;
    
        Debug.DrawRay(_collider.bounds.center + new Vector3(_collider.bounds.extents.x, 0), Vector2.down * (_collider.bounds.extents.y + _checkHeight), rayColor);
        Debug.DrawRay(_collider.bounds.center - new Vector3(_collider.bounds.extents.x, 0), Vector2.down * (_collider.bounds.extents.y + _checkHeight), rayColor);
        Debug.DrawRay(_collider.bounds.center - new Vector3(_collider.bounds.extents.x, _collider.bounds.extents.y + _checkHeight), Vector2.right * (_collider.bounds.extents.x) * 2, rayColor);

        //Debug.Log(raycastHit.collider);
        return raycastHit.collider != null;
    }
}

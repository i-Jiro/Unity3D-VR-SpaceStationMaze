using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DoorBehavior : MonoBehaviour
{
    private Animator _animator;
    private bool _isOpen = false;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_isOpen) return;
        if (other.GetComponent<Collider>().tag.Equals("Keycard"))
        {
            _isOpen = true;
            _animator.SetTrigger("Open");
        }
    }
}

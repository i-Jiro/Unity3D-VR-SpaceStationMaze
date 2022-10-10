using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ProxyDoorBehavior : MonoBehaviour
{

    private Animator _animator;
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _openSFXClip;
    private bool _isOpen = false;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_isOpen) return;
        if (other.gameObject.tag.Equals("MainCamera"))
        {
            _isOpen = true;
            _audioSource.PlayOneShot(_openSFXClip);
            _animator.SetTrigger("Open");
        }
    }
}

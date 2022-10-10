using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinStateController : MonoBehaviour
{
    [SerializeField] private GameObject _winMessage;
    
    // Start is called before the first frame update
    void Start()
    {
        _winMessage.gameObject.SetActive(false);    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            if(!_winMessage.activeInHierarchy)
                _winMessage.gameObject.SetActive(true);
        }
    }
}

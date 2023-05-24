using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private UIController UIController;
    private Rigidbody rb;
    private void Start() {
        rb = GetComponent<Rigidbody>();
        UIController = GameObject.FindWithTag("UIController").GetComponent<UIController>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            UIController.updateScore(1);
            StartCoroutine(turnOnGravity());
        }
    }
    IEnumerator turnOnGravity()
    {
        yield return new WaitForSeconds(0.5f);
        rb.useGravity = true;
        rb.isKinematic = false;
        Destroy(gameObject, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushController : MonoBehaviour
{
    private LevitateController _levitateController;

    private Rigidbody rb;

    private void Start()
    {
        _levitateController = GetComponent<LevitateController>();

        rb = GetComponent<Rigidbody>();
    }


    public void Push(GameObject player)
    {
        if (_levitateController.IsLevitating() == true) return;

        Debug.Log("Pushing Object");

        rb.AddForce((this.transform.position - player.transform.position) * 150);
    }
}

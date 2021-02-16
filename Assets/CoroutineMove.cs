using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CoroutineMove : MonoBehaviour
{

    public float speed;


    private void Update() 
    {
        if (Input.GetKeyDown("space"))
        {
            var target = GameObject.Find("Target");
            StartCoroutine(MoveObject(target, 1.0f));

            
        }
        
        Debug.Log(GetComponent<Rigidbody>().velocity);
    }

    private IEnumerator MoveObject(GameObject target, float speed)
    {
        var direction = target.transform.position - transform.position;
        GetComponent<Rigidbody>().velocity = direction * speed;
        yield return null;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == GameObject.Find("Target"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    
}

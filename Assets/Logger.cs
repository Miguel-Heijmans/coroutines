using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{


    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {


        yield return new WaitForSeconds(0.5f);

        
        Debug.Log("ik start nu de coroutine : " + Time.time);

        for (int i = 0; i < 10; i++)
        {
            
            yield return new WaitForSeconds(0.5f);

            
            Debug.Log("coroutine update op : " + Time.time);
        }


        yield return new WaitForSeconds(0.5f);

        Debug.Log("coroutine einde op : " + Time.time);
    }


}

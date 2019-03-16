using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachEqual : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string tmpA = new string(new char[] { 'H', 'L' });
        string tmpB = new string(new char[] { 'H', 'L' });
        Debug.Log(tmpA == tmpB);
        Debug.Log(tmpA.Equals(tmpB));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

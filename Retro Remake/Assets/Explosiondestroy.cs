using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosiondestroy : MonoBehaviour
{
    public int splodtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        Destroy(gameObject, splodtime);
    }





}

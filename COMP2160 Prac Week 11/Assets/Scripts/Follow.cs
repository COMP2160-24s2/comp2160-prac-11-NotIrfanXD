using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform Following;
    private Vector3 movedirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movedirection = transform.InverseTransformPoint(Following.position);
        transform.Translate(movedirection);
    }
}

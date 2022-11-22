using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private Vector3 offsetPosition;
    private Space offsetPositionSpace = Space.Self;
    private bool lookAt = true;
    
    
    // Start is called before the first frame update
    private void Start()
    {
     	offsetPosition = new Vector3(0, 2, -4);
    }

    // Update is called once per frame
    private void Update()
    {
        Refresh();

        
    }
    public void Refresh()
    {
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }
    
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    LineRenderer lineRenderer;
    public int linkNo;
    public GameObject hook;
    public GameObject linkPrefabs;
     HingeJoint joint;
    GameObject link;
    Rigidbody previousRB;
    // Start is called before the first frame update

    private void Start()
    {
        CreatingLinks();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, transform.position);
    }

    void CreatingLinks()
    {
        previousRB = hook.GetComponent<Rigidbody>();
        for(int i=0; i < linkNo; i++)
        {
            link = Instantiate(linkPrefabs, transform);
            joint = link.GetComponent<HingeJoint>();
            joint.connectedBody = previousRB;

            previousRB = link.GetComponent<Rigidbody>();

        }
    }
    private void Update()
    {
        lineRenderer.SetPosition(1, previousRB.transform.position);
    }
}

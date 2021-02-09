using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Separator : Kinematic
{
    Separation myMoveType;
    //Align myRotateType;

    public GameObject[] myTargets = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Separation();
        myMoveType.character = this;
        myMoveType.targets = myTargets;

        //myRotateType = new Align();
        //myRotateType.character = this;
        //myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate = myMoveType.getSteering();
        //steeringUpdate.linear = myMoveType.getSteering().linear;
        //steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToWaitingRoom : GAction
{
    public override bool PrePerform()
    {
        return true;
    }
    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("PatientWaiting", 1);
        GWorld.Instance.AddPatient(this.gameObject);
        return true;
    }
}

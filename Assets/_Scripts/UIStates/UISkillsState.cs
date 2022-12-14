using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UISkillsState : UIState
{
    public override void OnStart()
    {
        base.OnStart();
        uIStateMachine.uIWoodcuttingState.CalculateUnlock();
    }

    public override void UpdateState(float dt) //DT is deltatime
    {
        base.UpdateState(dt);
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}

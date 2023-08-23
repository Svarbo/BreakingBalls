using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Chain : NeedLinksObject
{
    [SerializeField] private int _neededBallsCount;
    [SerializeField] private int _reward;

    private List<HingeJoint> _hingeJoints = new List<HingeJoint>();
    private Animator _animator;
    private int _breakUp = Animator.StringToHash("BreakUp");


    private void Start()
    {
        _animator = GetComponent<Animator>();

        foreach (Transform child in transform)
        {
            if(child.TryGetComponent<HingeJoint>(out HingeJoint hingeJoint))
                _hingeJoints.Add(hingeJoint);
        }
    }

    public void CheckBallsCount()
    {
        if (Player.BallsCount >= _neededBallsCount)
            BreakUp();
        else
            Referee.CheckWin();
    }

    private void BreakUp()
    {
        _animator.Play(_breakUp);

        int breakJointIndex = _hingeJoints.Count / 2;
        _hingeJoints[breakJointIndex].breakForce = 1;

        //foreach(HingeJoint hingeJoint in _hingeJoints)
        //    hingeJoint.breakForce = 0.85f;

        TransferReward();
    }

    private void TransferReward()
    {
        Referee.ReduceScore(_reward);
    }
}

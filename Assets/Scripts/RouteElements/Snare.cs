using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Snare : NeedLinksObject
{
    private List<Ball> _balls = new List<Ball>();

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.TryGetComponent<Ball>(out Ball ball)) 
        {
            _balls.Add(ball);

            if(_balls.Count == Player.BallsCount)
                Referee.DeclareDefeat();
        }
    }
}
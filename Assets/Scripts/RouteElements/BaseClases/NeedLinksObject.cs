using UnityEngine;

public class NeedLinksObject : MonoBehaviour
{
    protected Player Player;
    protected ObjectPool BallsPool;
    protected Referee Referee;

    public void SetNeededLinks(Player player, ObjectPool ballsPool, Referee referee)
    {
        Player = player;
        BallsPool = ballsPool;
        Referee = referee;
    }
}
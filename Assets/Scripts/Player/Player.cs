using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private ObjectPool _ballsPool;

    public event UnityAction BallsCountDecreased;
    private List<Ball> _balls = new List<Ball>();
    private int _money = 0;
    private Vector3 _ballStartPosition = new Vector3(0.5f, 2, -40);

    public int BallsCount => _balls.Count;
    public int Money => _money;

    private void Start()
    {
        TakeStartBall();
    }

    public void AddBall(Ball newBall)
    {
        _balls.Add(newBall);
    }

    public void RemoveBall(Ball removedBall)
    {
        _balls.Remove(removedBall);
        removedBall.gameObject.SetActive(false);

        BallsCountDecreased?.Invoke();
    }

    public void ReduceMoney(int moneyCount)
    {
        _money += moneyCount;
    }

    private void TakeStartBall()
    {
        if (_ballsPool.TryGetObject(out GameObject ballObject))
        {
            if (ballObject.TryGetComponent<Ball>(out Ball ball))
            {
                AddBall(ball);
                SetStartBall(ball);
            }
        }
    }

    private void SetStartBall(Ball ball)
    {
        ball.transform.position = _ballStartPosition;
        ball.gameObject.SetActive(true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Elevator : MonoBehaviour
{
    private void Start()
    {
        Move();
    }

    void Move()
    {
        Sequence elevatorMove = DOTween.Sequence();
        elevatorMove.AppendInterval(5f);
        elevatorMove.Append(transform.DOLocalMove(new Vector3(0,76f,0),5));
        elevatorMove.Join(transform.DOLocalRotate(new Vector3(0, 225, 0), 5));
        elevatorMove.AppendInterval(2.5f);
        elevatorMove.SetLoops(-1,LoopType.Yoyo);

    }
}

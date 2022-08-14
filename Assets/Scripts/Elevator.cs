using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Elevator : MonoBehaviour
{
    public GameObject elevatorSound;
    //public AudioSource elevatorSound;
    private void Start()
    {
        Move();
    }

    void Move()
    {
        elevatorSound.SetActive(true);
        Sequence elevatorMove = DOTween.Sequence();
        elevatorMove.AppendInterval(5f);
        elevatorMove.Append(transform.DOLocalMove(new Vector3(0,76f,0),5));
        elevatorMove.Join(transform.DOLocalRotate(new Vector3(0, 225, 0), 5));
        elevatorMove.AppendInterval(2.5f);
        elevatorMove.SetLoops(-1,LoopType.Yoyo);

    }
}

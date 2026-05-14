using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    [SerializeField] private float _positionY;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMoveY(_positionY,_duration).SetLoops(_repeats, _loopType);
    }
}
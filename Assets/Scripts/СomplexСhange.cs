using DG.Tweening;
using UnityEngine;

public class СomplexСhange : MonoBehaviour
{
    [SerializeField] private float _positionY;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Insert(0,transform.DOMoveY(_positionY, _duration).SetLoops(_repeats, _loopType))
                .Insert(0,transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_repeats, _loopType))
                .Insert(0,transform.DOScale(_scale, _duration).SetLoops(_repeats, _loopType));
    }
}
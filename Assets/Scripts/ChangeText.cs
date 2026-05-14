using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private float _duration = 3f;
    private bool _isRichTextEnabled = true;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("Новый текст ", _duration))
                .Append(_text.DOText("дополнительный текст", _duration).SetRelative())
                .Append(_text.DOText("Вас взломали", _duration, _isRichTextEnabled, ScrambleMode.All));
        sequence.SetLoops(_repeats,_loopType);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    #region Attributs
    [SerializeField] private CharacterMovement _character = null;
    [SerializeField] private RectTransform _fill = null;

    private Vector3 _fullPos = Vector3.zero;
    private Vector3 _emptyPos = Vector3.zero;
    #endregion

    void Start()
    {
        _fullPos = _fill.localPosition;
        _emptyPos = _fill.localPosition;
        _emptyPos.x -= _fill.rect.width;
    }

    
    void Update()
    {
        // (float) <-- cast = changegment d'attribut
        float perc = (float) _character.CurrentHealth / (float) _character.MaxHeath;
        // float perc = (float) _character.(nom de la methode dans l'autre script *return*) /  _character.(nom de la methode dans l'autre script *return*)
        _fill.localPosition = Vector3.Lerp(_emptyPos, _fullPos, perc);
    }

}

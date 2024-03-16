using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "»конки", menuName = "ScriptableObjects/Icons", order = 1)]
public class Icons : ScriptableObject
{
    [SerializeField] public Sprite[] MainIconImes;
    [SerializeField] public Sprite[] IconImes;
}
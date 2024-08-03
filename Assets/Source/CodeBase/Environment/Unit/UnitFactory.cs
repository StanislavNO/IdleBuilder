using System.Collections;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    [CreateAssetMenu(fileName = "UnitFactory", menuName = "Configs/UnitFactory")]
    public class UnitFactory : ScriptableObject
    {
        [SerializeField] private Unit _prefab;
    }
}
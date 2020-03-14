using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Level Config", menuName = "Level Config")]
public class LevelConfigSO : ScriptableObject
{

    public float Offset;
    public float BeatRate;
    public float DamageRate;
    public float WeaponChargeSpeed;
    public float WeaponMaxCharge;
    public float[] BeatTimes;
    public Vector3[] BeatPositions;
}

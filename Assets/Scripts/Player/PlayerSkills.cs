using UnityEngine;
using System.Collections;

public class PlayerSkills : MonoBehaviour 
{
    [SerializeField] int _woodSkill;
    public int woodSkill {
        get {
            return _woodSkill;
        }
        set {
            _woodSkill += value;
        }
    }

    [SerializeField] int _stoneSkill;
    public int stoneSkill {
        get {
            return _stoneSkill;
        }
        set {
            _stoneSkill += value;
        }
    }

    [SerializeField] int _metalSkill;
    public int metalSkill {
        get {
            return _metalSkill;
        }
        set {
            _metalSkill += value;
        }
    }

    [SerializeField] int _skinSkill;
    public int skinSkill {
        get {
            return _skinSkill;
        }
        set {
            _skinSkill += value;
        }
    }

    [SerializeField] int _manMadeSkill;
    public int manMadeSkill {
        get {
            return _manMadeSkill;
        }
        set {
            _manMadeSkill += value;
        }
    }

}

using System.Collections.Generic;
using UnityEngine;

public class DialogList : MonoBehaviour
{
    public Dictionary<string, bool> IsDialogProceeded = new Dictionary<string, bool>
    {
        { "Main1_1", false },
        { "Main2_1", true },
        { "Main3_1", true },
        { "Main4_1", true },
        {"Main5_1", true},
        {"Main6_1", true},
        {"Sub1_1", false},
        {"Sub2_1", false},
        {"Sub3_1", false},
        {"Sub4_1", false},
        {"Sub5_1", true},
        {"Sub6_1", true},
        {"Sub7_1", true},
        {"Sub8_1", true},
        {"Sub9_1", true},
        {"Sub10_1", true},
        {"Sub11_1", true},
        {"Sub12_1", true}
    };
}

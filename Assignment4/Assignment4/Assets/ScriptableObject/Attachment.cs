using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attatchment", menuName = "Attachments", order = 1)]
public class Attachment : ScriptableObject
{
    public int attachmentSlotID;
    public int attachmentID;
}

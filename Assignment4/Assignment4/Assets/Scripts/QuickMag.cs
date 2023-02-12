using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickMag : AttachmentDecorator
{
    public QuickMag(WeaponComponent wrap) : base(wrap)
    {
        price = 90;
        description = "This weapon has a faster reload for a premium price";
    }
}

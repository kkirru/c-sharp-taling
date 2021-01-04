using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : Parent
{
    public override void aa()
    {
        throw new System.NotImplementedException();
    }

    public new void Show(){
        Debug.Log("I'm child");
    }
    


}

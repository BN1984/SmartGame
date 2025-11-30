using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreDeposit
{
    public Resource Res { get; private set;}

    public OreDeposit(Resource res)
    {
        Res = res;
    }

    public void GetRes(int power, GameStructure structure)
    {
        Resource res = Res.Copy();
        structure.GetResource(res);
        Res.ChangeAmount(power);

        if (Res.Amount <= 0)
            Res = null;
    }
}

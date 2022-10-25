using System;
using System.Collections.Generic;

[Serializable]
public class LevelData
{
    public List<PoolData> PoolList = new List<PoolData>();
}

[ Serializable]
public struct PoolData
{
    public sbyte RequiredObjectcount;
}

using System;
using System.Collections.Generic;

[Serializable]
public class CollectionMeta
{
    public string id;
    public string uid;
    public string title;
    public string slogan;
    public OnlineImageAsset cover;
    public OnlineUser owner;
    public List<OnlineLevel> levels;
}
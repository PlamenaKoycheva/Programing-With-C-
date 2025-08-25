using System.ComponentModel;
using System.Xml.Linq;

class Song
{
    public Song(string typeList, string name, string duration)
{
    TypeList = typeList;
    Name = name;
    Time = duration;
}

public string TypeList { get; set; }

public string Name { get; set; }

public string Time { get; set; }
}

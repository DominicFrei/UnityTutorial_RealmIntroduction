using Realms;

class ColorEntity : RealmObject
{
    [PrimaryKey]
    public string ObjectName { get; set; }
    public float Red { get; set; } = 0f;
    public float Green { get; set; } = 0f;
    public float Blue { get; set; } = 0f;

    public ColorEntity() { }

    public ColorEntity(string objectName)
    {
        ObjectName = objectName;
    }
}

[System.Serializable]
public struct PlayerData
{
    public string Name;
    public int Age;
    public float HP;
    public float Attack;

    public PlayerData(string name, int age, float hp, float attack)
    {
        Name = name;
        Age = age;
        HP = hp;
        Attack = attack;
    }
}

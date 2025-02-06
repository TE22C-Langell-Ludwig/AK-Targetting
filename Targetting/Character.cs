public class Character
{

    public Character(bool a, int b) {
        ArtsDmg = a;
        Atk=b;
    }
private bool ArtsDmg;
private int Atk;
public bool GetArtsDmg()
    {
        return ArtsDmg;
    }
    public int GetAtk()
    {
        return Atk;
    }
}


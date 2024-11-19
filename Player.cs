namespace Infinity_Runner;

public delegate void CallBack();
public class Player : Animacao
{
    public Player(image a) : base(a)
    {
        for(int i = 0; i < 10; i++)
        {
            animacao.Add($"{i.ToString("D2")}");
        }
        SetAnimacaoAtiva(1);
    }

    public void Die()
    {
        loop = false;
    }

    public void Run()
    {
        loop = true;
        SetAnimacaoAtiva(1);
        Play();
    }

    public void MoveY(int n)
    {
        compImagem.TranslationV += n;
    }

    public double GetY()
    {
        return compImagem.TranslationV;
    }

    public void SetY(double n)
    {
        compImagem.TranslationV = n;
    }
}
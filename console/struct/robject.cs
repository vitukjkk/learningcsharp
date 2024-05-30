using System;

class Galinha
{
    private string nome;
    private int ovos;
    public Galinha(string nome)
    {
        this.nome = nome;
        ovos = 0;
    }

    public Ovo botar()
    {
        ovos++;
        return new Ovo(ovos, nome);
    }
}

class Ovo
{
    private int numOvo;
    private string mgalinha;
    public Ovo(int numOvo, string mgalinha)
    {
        this.numOvo = numOvo;
        this.mgalinha = mgalinha; 
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.mgalinha);
    }
}

class myC
{
    public static void Main()
    {
        Galinha g1 = new Galinha("Gertrudes");
        g1.botar();
        g1.botar();
        g1.botar();
        Galinha g2 = new Galinha("Marisvalda");
        g2.botar();
        Galinha g3 = new Galinha("Joaninha");
        g3.botar();
    }
}
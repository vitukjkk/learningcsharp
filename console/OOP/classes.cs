/*
        MODIFICADOR DE CLASSE
        PUBLIC - ABSTRACT - SEALED - STATIC
        public: sem restrição de visualização
        abstract: classe-base para outras classes, não podem ser instanciados objetos dessa classe
        sealed: classe não pode ser herdada
        static: não permite a instanciação de objetos e seus membros devem ser static
        
        ESPECIFICADOR DE ACESSO - onde um membro da classe pode ser acessado
        PUBLIC: sem restrição de acesso
        PRIVATE: só podem ser acessados pela própria classe
        PROTECTED: podem ser acessados na própria classe e nas classes derivadas
        ABSTRACT: classes pais que irão herdar outras
        SEALED: o método não pode ser redefinido
        VIRTUAL: o método pode ser redefinido em uma classe derivada
        STATIC: o método pode ser chamado sem a instanciação de um objeto
        */

using System;

class myC
{
    static void Main()
    {
        Player j1 = new Player();

        Console.WriteLine("Energia do player 1: {0}", j1.energia);
        j1.energia = 50;
        Console.WriteLine("Energia do player 1 agora: {0}", j1.energia);
    }
}

public class Player // SE NAO ESPECIFICA ELE SERÁ PÚBLICA
{
    public int energia = 100;
    public bool vivo = true;
}
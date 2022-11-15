using System;
using System.Collections.Generic;

namespace Università
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        //Dictionary
        Dictionary<DIPARTIMENTI, Dictionary<Matricola, List<Esame>>> università = new Dictionary<DIPARTIMENTI, Dictionary<Matricola, List<Esame>>>();
        
            // matricole
        Matricola matr1 = new Matricola("Giresse", 458145);
        Matricola matr2 = new Matricola("Mathias", 441396);
        Matricola matr3 = new Matricola("Melissa", 456738);
        

        //esami
        Esame esam1 = new Esame(1, " ingegneria del software1", 25);
        Esame esam2 = new Esame(2, "geometria", 18);
        Esame esam3 = new Esame(3, "economia Aziendale1", 27);
       

        //Chiavi dei dipartimenti
        università.Add(DIPARTIMENTI.INGEGNERIA, new ());
            università.Add(DIPARTIMENTI.MATEMATICA, new ());
            università.Add(DIPARTIMENTI.ECONOMIA, new ());
           
          

            
            università[DIPARTIMENTI.INGEGNERIA].Add(matr1, new ());
            università[DIPARTIMENTI.MATEMATICA].Add(matr2, new ());
            università[DIPARTIMENTI.ECONOMIA].Add(matr3, new ());
           
           

            
            università[DIPARTIMENTI.INGEGNERIA][matr1].Add(esam3);
            università[DIPARTIMENTI.MATEMATICA][matr2].Add(esam2);
            università[DIPARTIMENTI.ECONOMIA][matr3].Add(esam1); 
       
            // Stampa
        Console.WriteLine(" Dipartimenti: ");
            foreach (var item in università)
            {                
                    Console.WriteLine(item.Key);       
            }

    Console.WriteLine("  esami di Dipartimenti: ");
            Console.WriteLine(università[DIPARTIMENTI.INGEGNERIA][matr1][0].getName();
            Console.WriteLine(università[DIPARTIMENTI.MATEMATICA][matr2][0].getName();
            Console.WriteLine(università[DIPARTIMENTI.ECONOMIA][matr3][0].getName();
            
        }
    }
}


public class Matricola
{
    private string name;
    private int matr;
    // costruttore
    public Matricola(string name, int matr)
    {
        this.name = name;
        this.matr = matr;
    }

    //Getter and Setter
    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public int getMatr()
    {
        return matr;
    }

    public void setMatr(int matr)
    {
        this.matr = matr;
    }
}

public class Esame
{
    private long id;
    private string name;
    private int voto;

    //Costruttore
    public Esame(int id, string name, int voto)
    {
        this.id = id;
        this.name = name;
        this.voto = voto;
    }
    // getter and setter
    public long getId()
    {
        return id;
    } 
    
    public void setId(long id)
    {
        this.id=id;
    }

    public String getName()
    {
        return name;
    }

    public void setId(string name)
    {
        this.name = name;
    }

    public int geVoto()
    {
        return voto;
    }

    public void setId(int voto)
    {
        this.voto = voto;
    }
}

public enum DIPARTIMENTI
{
    INGEGNERIA,
    MATEMATICA,
    ECONOMIA,    
}


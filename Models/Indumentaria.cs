namespace TPBase.Models;
using System;
public class indumentaria
{
    public string Media{get;private set;}
    public string Pantalon {get; private set;}
    public string Remera{get; private set;}

    public indumentaria()
    {

    }

    public indumentaria(string me, string pa, string ca)
    {
        Media = me;
        Pantalon = pa;
        Remera= ca;
    }
}
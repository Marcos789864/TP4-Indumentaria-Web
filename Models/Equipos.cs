namespace TPBase.Models;
using System.Linq;
using System.Web;
public static class Equipos


{
     public static List<string> ListaEquipos {get; private set;} =  new List<string>() {" 1) la cantera", " 2) estudiantes de rio cuarto", "3) Ituzaingo", "4) all boys", "5) flandria", "6) rosario central", "7) defensa y justicia", "8) colo colo", "9) fluminense", "10) deportivo rayo"};
    public static List<string> ListaMedias {get; private set;} =  new List<string>() {"calcetines rojos.jpg", "calcetines celestes.jpg", "calcetines verdes.jpg", "calcetines negros.jpg", "calcetines amarillos.jpg", "calcetines azul y amarillo.jpg", "calcetines amarilla y verde.jpg", "calcetines blancos.jpg", "calcetines del flu.jpg", "calcetines del rayo.jpg"};
    public static List<string> ListaPantalones{get;private set;} =  new List<string>() {"short rojo.jpg", "short celeste.jpg", "short verde.jpg", "short negro.jpg", "short amarillo.jpg", "short azul y amarillo.jpg", "short amarillo y verde.jpg", "short blanco.jpg", "short del flu.jpg", "short rayo.jpg"};
    public static List<string> ListaRemeras {get; private set;} =  new List<string>() {"camisetas rojas.jpg", "camiseta celeste.jpg", "camiseta verde.jpg", "camiseta negra.jpg", "camiseta amarilla.jpg", "camiseta azul y amarilla.jpg", "camiseta amarilla y verde.jpg", "camiseta blanca.jpg", "camiseta del flu.jpg", "camiseta rayo.jpg"};

    public static Dictionary<string,indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, indumentaria>();


    public static bool IngresarIndumentaria (string EquipoSeleccionado, indumentaria item)
    {       
       bool SePuede = EquiposIndumentaria.ContainsKey(EquipoSeleccionado);
        if (SePuede == false) EquiposIndumentaria.Add(EquipoSeleccionado,item);
        return SePuede;
    }
}
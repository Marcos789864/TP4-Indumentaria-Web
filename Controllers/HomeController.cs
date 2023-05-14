using  TPBase.Models;
using  Microsoft.AspNetCore.Mvc;


namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.DicEquipo = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {   
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias= Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }
    public IActionResult GuardarIndumentaria(int Equipo,int Media,int Pantalon,int Remera)
    {
           bool puede;
            indumentaria t1 = new indumentaria(Equipos.ListaMedias[Media-1],Equipos.ListaPantalones[Pantalon-1],Equipos.ListaRemeras[Remera-1]);
            puede = Equipos.IngresarIndumentaria(Equipos.ListaEquipos[Equipo-1],t1);
            if(puede == false)
            {
                ViewBag.DicEquipo = Equipos.EquiposIndumentaria;
            return View("index");
            }
            else
            {
                return View("SelectIndumentaria");  
            }      
    }
}

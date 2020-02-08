using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablaPeriodica.Models;

namespace TablaPeriodica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ElementList = new List<Elementos>()
            {
                new Elementos("H","Otros no metales",1),
                new Elementos("He","Gases nobles",2),
                new Elementos("Li","Alcalinos",3),
                new Elementos("Be","Alcalinoterreos",4),
                new Elementos("B","Metaloides",5),
                new Elementos("C","Otros no metales",6),
                new Elementos("N","Otros no metales",7),
                new Elementos("O","Otros no metales",8),
                new Elementos("F","Halogenos",9),
                new Elementos("Ne","Gases nobles",10),
                new Elementos("Na","Alcalinos",11),
                new Elementos("Mg","Alcalinoterreos",12),
                new Elementos("Al","Otros metales",13),
                new Elementos("Si","Metaloides",14),
                new Elementos("P","Otros no metales",15),
                new Elementos("S","Otros no metales",16),
                new Elementos("Cl","Halogenos",17),
                new Elementos("Ar","Gases nobles",18),
                new Elementos("K","Alcalinos",19),
                new Elementos("Ca","Alcalinoterreos",20),
                new Elementos("Sc","Metales de transicion",21),
                new Elementos("Ti","Metales de transicion",22),
                new Elementos("V","Metales de transicion",23),
                new Elementos("Cr","Metales de transicion",24),
                new Elementos("Mn","Metales de transicion",25),
                new Elementos("Fe","Metales de transicion",26),
                new Elementos("Co","Metales de transicion",27),
                new Elementos("Ni","Metales de transicion",28),
                new Elementos("Cu","Metales de transicion",29),
                new Elementos("Zn","Metales de transicion",30),
                new Elementos("Ga","Otros metales",31),
                new Elementos("Ge","Metaloides",32),
                new Elementos("As","Metaloides",33),
                new Elementos("Se","Otros no metales",34),
                new Elementos("Br","Halogenos",35),
                new Elementos("Kr","Gases nobles",36),
                new Elementos("Rb","Alcalinos",37),
                new Elementos("Sr","Alcalinoterreos",38),
                new Elementos("Y","Metales de transicion",39),
                new Elementos("Zr","Metales de transicion",40),
                new Elementos("Nb","Metales de transicion",41),
                new Elementos("Mo","Metales de transicion",42),
                new Elementos("Tc","Metales de transicion",43),
                new Elementos("Ru","Metales de transicion",44),
                new Elementos("Rh","Metales de transicion",45),
                new Elementos("Pd","Metales de transicion",46),
                new Elementos("Ag","Metales de transicion",47),
                new Elementos("Cd","Metales de transicion",48),
                new Elementos("In","Otros metales",49),
                new Elementos("Sn","Otros metales",50),
                new Elementos("Sb","Metaloides",51),
                new Elementos("Te","Metaloides",52),
                new Elementos("I","Halogenos",53),
                new Elementos("Xe","Gases nobles",54),
                                new Elementos("Cs","Alcalinos",55),
                new Elementos("Ba","Alcalinoterreos",56),
                new Elementos("La-Lu","Lantanidos",0),
                new Elementos("Hf","Metales de transicion",72),
                new Elementos("Ta","Metales de transicion",73),
                new Elementos("W","Metales de transicion",74),
                new Elementos("Re","Metales de transicion",75),
                new Elementos("Os","Metales de transicion",76),
                new Elementos("Ir","Metales de transicion",77),
                new Elementos("Pt","Metales de transicion",78),
                new Elementos("Au","Metales de transicion",79),
                new Elementos("Hg","Metales de transicion",80),
                new Elementos("Tl","Otros metales",81),
                new Elementos("Pb","Otros metales",82),
                new Elementos("Bi","Otros metales",83),
                new Elementos("Po","Metaloides",84),
                new Elementos("At","Halogenos",85),
                new Elementos("Rn","Gases nobles",86),
                                new Elementos("Fr","Alcalinos",87),
                new Elementos("Ra","Alcalinoterreos",88),
                new Elementos("Ac-Lr","Actinidos",0),
                new Elementos("Rf","Metales de transicion",104),
                new Elementos("Db","Metales de transicion",105),
                new Elementos("Sg","Metales de transicion",106),
                new Elementos("Bh","Metales de transicion",107),
                new Elementos("Hs","Metales de transicion",108),
                new Elementos("Mt","Metales de transicion",109),
                new Elementos("Ds","Metales de transicion",110),
                new Elementos("Rg","Metales de transicion",111),
                new Elementos("Cn","Metales de transicion",112),
                new Elementos("Nh","Otros metales",113),
                new Elementos("Fl","Otros metales",114),
                new Elementos("Mc","Otros metales",115),
                new Elementos("Lv","Otros metales",116),
                new Elementos("Ts","Halogenos",117),
                new Elementos("Og","Gases nobles",118),
                                new Elementos("La","Lantanidos",57),
                new Elementos("Ce","Lantanidos",58),
                new Elementos("Pr","Lantanidos",59),
                new Elementos("Nd","Lantanidos",60),
                new Elementos("Pm","Lantanidos",61),
                new Elementos("Sm","Lantanidos",62),
                new Elementos("Eu","Lantanidos",63),
                new Elementos("Gd","Lantanidos",64),
                new Elementos("Tb","Lantanidos",65),
                new Elementos("Dy","Lantanidos",66),
                new Elementos("Ho","Lantanidos",67),
                new Elementos("Er","Lantanidos",68),
                new Elementos("Tm","Lantanidos",69),
                new Elementos("Yb","Lantanidos",70),
                new Elementos("Lu","Lantanidos",71),
                                                new Elementos("Ac","Actinidos",89),
                new Elementos("Th","Actinidos",90),
                new Elementos("Pa","Actinidos",91),
                new Elementos("U","Actinidos",92),
                new Elementos("Np","Actinidos",93),
                new Elementos("Pu","Actinidos",94),
                new Elementos("Am","Actinidos",95),
                new Elementos("Cm","Actinidos",96),
                new Elementos("Bk","Actinidos",97),
                new Elementos("Cf","Actinidos",98),
                new Elementos("Es","Actinidos",99),
                new Elementos("Fm","Actinidos",100),
                new Elementos("Md","Actinidos",101),
                new Elementos("No","Actinidos",102),
                new Elementos("Lr","Actinidos",103)
            };

            var LeyendList = new List<string>()
            {
                new string("Alcalinos"),
                new string("Alcalinoterreos"),
                new string("Metales de transicion"),
                new string("Lantanidos"),
                new string("Actinidos"),
                new string("Otros Metales"),
                new string("Metaloides"),
                new string("Otros no metales"),
                new string("Halogenos"),
                new string("Gases nobles")
            };

            ViewBag.ListaElementos = ElementList;
            ViewBag.ListaLeyenda = LeyendList;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

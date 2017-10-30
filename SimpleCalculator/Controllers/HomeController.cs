using SimpleCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SimpleCalculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int number1, int number2, string Operator)
        {
            Calculator calc = new Calculator(number1, number2);
           
 
            if (ModelState.IsValid)
            {
                while (Operator != "Select Operator")
                {

                    if (Operator == "Add")
                    {
                        calc.Add();
                        return View(ViewBag.Outcome = calc.outcome);
                        
                    }

                    if (Operator == "Subtract")
                    {
                        calc.Subtract();
                        return View(ViewBag.Outcome = calc.outcome);
                        
                    
                    }

                    if (Operator == "Divide")
                    {
                        calc.Divide();
                        return View(ViewBag.Outcome = calc.outcome);
                        
                        
                    }

                    if (Operator == "Multiply")
                    {
                        calc.Multiply();
                        return View(ViewBag.Outcome = calc.outcome);
                        
                        
                    }
                
                }
            
            }

            return View();
        }


    }
}
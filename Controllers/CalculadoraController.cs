using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet ("Somar/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Somar(double valor1, double valor2) {
            var calc = new Calculadora(valor1, valor2);
            calc.somar();
            return Ok(calc);
        }

        [HttpGet ("Subtrair/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Subtrair(double valor1, double valor2) {
            var calc = new Calculadora(valor1, valor2);
            calc.subtrair();
            return Ok(calc);
        }

        [HttpGet ("Multiplicar/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Multiplicar(double valor1, double valor2) {
            var calc = new Calculadora(valor1, valor2);
            calc.multiplicar();
            return Ok(calc);
        }

        [HttpGet ("Dividir/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Dividir(double valor1, double valor2) {
            var calc = new Calculadora(valor1, valor2);
            calc.dividir();
            return Ok(calc);
        }
    }
}
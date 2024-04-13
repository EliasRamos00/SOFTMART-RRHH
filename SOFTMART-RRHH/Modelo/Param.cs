using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Modelo
{
    /// <summary>
    /// Clase que ayuda a crear listas de tipo parameros (Param), recibe el nombre y el valor del parametro para los procedimientos almacenados.
    /// </summary>
    public class Param
    {
        /// <summary>
        /// Recibe el nombre del atributo y el valor del mismo.
        /// </summary>
        /// <param name="atributo"></param>
        /// <param name="valor"></param>
        public Param(string atributo, object valor)
        {
            Atributo = atributo;
            Valor = valor;
        }
        public string Atributo { get; set; }
        public object Valor { get; set; }
    }

}

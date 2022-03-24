﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Alumno
{
    internal class Alumno
    {
        private string matricula;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string nombres;
        private DateTime fechaNacimiento;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
            set
            {
                apellidoPaterno = value;
            }
        }
        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }
            set
            {
                apellidoMaterno = value;
            }
        }
        public string Nombres
        {
            get
            {
                return nombres;
            }
            set
            {
                nombres = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }
        public string NombreCompleto
        {
            get
            {
                return nombres + " " + apellidoPaterno + " " + apellidoMaterno;
            }
        }
    }
}


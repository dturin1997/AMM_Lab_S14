using Database2022.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database2022.Services
{
    public class EstudianteService
    {
        private readonly AppDbContext _context;

        public EstudianteService() => _context = App.GetContext();


        public bool Create(Estudiante item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Estudiantes.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

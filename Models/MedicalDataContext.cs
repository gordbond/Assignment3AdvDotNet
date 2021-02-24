using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3AdvDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment3AdvDotNet.Models
{
    /// <summary>
    /// Database context for this API
    /// Co-ordinateswith between EF and the model
    /// </summary>
    public class MedicalDataContext : DbContext
    {

        public MedicalDataContext(DbContextOptions<MedicalDataContext> options)
            : base(options)
        {
        }

        //Immunization DBset - used to create queries for instances of Immunizations
        public DbSet<Immunization> Immunizations { get; set; }

        //MedicalEntity DBset - used to create queries for instances of MedicalEntity
        public DbSet<MedicalEntity> MedicalEntities { get; set; }

        //Person DBset - used to create queries for instances of Person
        public DbSet<Person> People { get; set; }

        //Patient DBset - used to create queries for instances of Patient
        public DbSet<Patient> Patients { get; set; }

        //Provider DBset - used to create queries for instances of Provider
        public DbSet<Provider> Providers { get; set; }

    }
}

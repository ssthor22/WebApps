//using Microsoft.AspNetCore.Builder;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;

//namespace ProTherm.Models
//{
//    public static class SeedData
//    {
//        public static void EnsurePopulated(IApplicationBuilder app)
//        {
//            ProThermDbContext context = app.ApplicationServices
//                .CreateScope().ServiceProvider.GetRequiredService<ProThermDbContext>();

//            if (context.Database.GetPendingMigrations().Any())
//            {
//                context.Database.Migrate();
//            }

//            if (!context.Mutants.Any())
//            {
//                context.Mutants.AddRange(
//                    new Mutant
//                    {
//                        name = "Gene V",
//                        PDB = "1VQB",
//                        pdburl = "https://www.rcsb.org/structure/1VQB",
//                        size = 87,
//                        chain = "N/A",
//                        original = "E",
//                        site = 30,
//                        mutation = "F",
//                        ddg = 2.1m
//                    },
//                    new Mutant
//                    {
//                        name = "Gene V",
//                        PDB = "1VQB",
//                        pdburl = "https://www.rcsb.org/structure/1VQB",
//                        size = 87,
//                        chain = "N/A",
//                        original = "E",
//                        site = 30,
//                        mutation = "M",
//                        ddg = 0.7m
//                    },
//                    new Mutant
//                    {
//                        name = "Gene V",
//                        PDB = "1VQB",
//                        pdburl = "https://www.rcsb.org/structure/1VQB",
//                        size = 87,
//                        chain = "N/A",
//                        original = "C",
//                        site = 33,
//                        mutation = "S",
//                        ddg = -4.2m
//                    },
//                    new Mutant
//                    {
//                        name = "Gene V",
//                        PDB = "1VQB",
//                        pdburl = "https://www.rcsb.org/structure/1VQB",
//                        size = 87,
//                        chain = "N/A",
//                        original = "D",
//                        site = 36,
//                        mutation = "C",
//                        ddg = -2.0m
//                    },
//                    new Mutant
//                    {
//                        name = "Gene V",
//                        PDB = "1VQB",
//                        pdburl = "https://www.rcsb.org/structure/1VQB",
//                        size = 87,
//                        chain = "N/A",
//                        original = "D",
//                        site = 36,
//                        mutation = "N",
//                        ddg = -1.0m
//                    },
//                    new Mutant
//                    {
//                        name = "Gene V",
//                        PDB = "1VQB",
//                        pdburl = "https://www.rcsb.org/structure/1VQB",
//                        size = 87,
//                        chain = "N/A",
//                        original = "I",
//                        site = 47,
//                        mutation = "T",
//                        ddg = -7.4m
//                    },
//                    new Mutant
//                    {
//                        name = "Rop",
//                        PDB = "1ROP",
//                        pdburl = "https://www.rcsb.org/structure/1ROP",
//                        size = 63,
//                        chain = "A",
//                        original = "D",
//                        site = 30,
//                        mutation = "G",
//                        ddg = -22.2m
//                    },
//                    new Mutant
//                    {
//                        name = "Rop",
//                        PDB = "1ROP",
//                        pdburl = "https://www.rcsb.org/structure/1ROP",
//                        size = 63,
//                        chain = "A",
//                        original = "D",
//                        site = 30,
//                        mutation = "Q",
//                        ddg = 10.4m //dTm
//                    },
//                    new Mutant
//                    {
//                        name = "Rop",
//                        PDB = "1ROP",
//                        pdburl = "https://www.rcsb.org/structure/1ROP",
//                        size = 63,
//                        chain = "A",
//                        original = "D",
//                        site = 30,
//                        mutation = "E",
//                        ddg = 6.2m //dTm
//                    }

//                );
//                context.SaveChanges();
//            }
//        }
//    }
//}

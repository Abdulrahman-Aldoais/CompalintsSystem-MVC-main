using CompalintsSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompalintsSystem.EF.Configuration
{
    public class GovConfigration : IEntityTypeConfiguration<Colleges>
    {


        public void Configure(EntityTypeBuilder<Colleges> builder)
        {


            builder.HasData(
                    new Colleges
                    {
                        Id = 1,
                        Name = "كلية الطب ",
                    },
                    new Colleges
                    {
                        Id = 2,
                        Name = " كلية الهندسة",
                    },
                     new Colleges
                     {
                         Id = 4,
                         Name = " جميع الكليات",
                     },
                      new Colleges
                      {
                          Id = 5,
                          Name = "زائر ",
                      },
                     new Colleges
                     {
                         Id = 3,
                         Name = "كلية التربية",
                     }
                );
        }


    }

}
using CompalintsSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompalintsSystem.EF.Configuration
{
    public class DirConfigration : IEntityTypeConfiguration<Departments>
    {


        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            builder.HasData(
                    new Departments
                    {
                        Id = 1,
                        Name = "الطب البشري",
                        CollegesId = 1,
                    },
                    new Departments
                    {
                        Id = 9,
                        Name = "المختبرات",
                        CollegesId = 1,
                    },
                    new Departments
                    {
                        Id = 10,
                        Name = "التمريض",
                        CollegesId = 1,
                    },
                    new Departments
                    {
                        Id = 11,
                        Name = "نظم معلومات",
                        CollegesId = 2,

                    },
                      new Departments
                      {
                          Id = 12,
                          Name = "امن سيبراني",
                          CollegesId = 2,

                      },
                        new Departments
                        {
                            Id = 13,
                            Name = "هندسة معماري",
                            CollegesId = 2,

                        },
                      new Departments
                      {
                          Id = 2,
                          Name = "علوم حاسوب",
                          CollegesId = 2,

                      },
                     new Departments
                     {
                         Id = 5,
                         Name = "هندسة مدني",
                         CollegesId = 2,

                     },
                     new Departments
                     {
                         Id = 3,
                         Name = "صيدلة",
                         CollegesId = 1,

                     },
                      new Departments
                      {
                          Id = 6,
                          Name = "فيزياء",
                          CollegesId = 3,

                      },
                       new Departments
                       {
                           Id = 7,
                           Name = "جميع الاقسام",
                           CollegesId = 4,

                       },
                        new Departments
                        {
                            Id = 8,
                            Name = "زئر",
                            CollegesId = 5,

                        },
                      new Departments
                      {
                          Id = 4,
                          Name = "قران",
                          CollegesId = 3,

                      }
                );
        }




    }
}

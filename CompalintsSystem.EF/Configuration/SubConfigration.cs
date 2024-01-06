using CompalintsSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompalintsSystem.EF.Configuration
{
    public class SubConfigration : IEntityTypeConfiguration<SubDepartments>
    {
        public void Configure(EntityTypeBuilder<SubDepartments> builder)
        {
            builder.HasData(
                    new SubDepartments
                    {
                        Id = 1,
                        Name = " الاول",
                        DepartmentsId = 1,
                    },
                      new SubDepartments
                      {
                          Id = 15,
                          Name = " الثالث",
                          DepartmentsId = 1,
                      },
                        new SubDepartments
                        {
                            Id = 16,
                            Name = " الرابع",
                            DepartmentsId = 1,
                        },
                          new SubDepartments
                          {
                              Id = 17,
                              Name = " الخامس",
                              DepartmentsId = 1,
                          },
                            new SubDepartments
                            {
                                Id = 18,
                                Name = " السادس",
                                DepartmentsId = 1,
                            },
                              new SubDepartments
                              {
                                  Id = 19,
                                  Name = " السابع",
                                  DepartmentsId = 1,
                              },
                                new SubDepartments
                                {
                                    Id = 20,
                                    Name = " خريج",
                                    DepartmentsId = 1,
                                },
                      new SubDepartments
                      {
                          Id = 2,
                          Name = " الثاني",
                          DepartmentsId = 1,
                      },
                        new SubDepartments
                        {
                            Id = 3,
                            Name = " الاول",
                            DepartmentsId = 2,
                        },
                         new SubDepartments
                         {
                             Id = 21,
                             Name = " الثالث",
                             DepartmentsId = 2,
                         },
                          new SubDepartments
                          {
                              Id = 22,
                              Name = " الرابع",
                              DepartmentsId = 2,
                          },
                        new SubDepartments
                        {
                            Id = 4,
                            Name = " الثاني",
                            DepartmentsId = 2,
                        },
                                                new SubDepartments
                                                {
                                                    Id = 6,
                                                    Name = " الاول",
                                                    DepartmentsId = 3,
                                                },
                        new SubDepartments
                        {
                            Id = 7,
                            Name = " الثاني",
                            DepartmentsId = 3,
                        },
                         new SubDepartments
                         {
                             Id = 23,
                             Name = " الثالث",
                             DepartmentsId = 3,
                         },
                          new SubDepartments
                          {
                              Id = 24,
                              Name = " الرابع",
                              DepartmentsId = 3,
                          },
                                                new SubDepartments
                                                {
                                                    Id = 8,
                                                    Name = " الاول",
                                                    DepartmentsId = 4,
                                                },
                        new SubDepartments
                        {
                            Id = 9,
                            Name = " الثاني",
                            DepartmentsId = 4,
                        },
                                                new SubDepartments
                                                {
                                                    Id = 10,
                                                    Name = " الاول",
                                                    DepartmentsId = 5,
                                                },
                        new SubDepartments
                        {
                            Id = 11,
                            Name = " الثاني",
                            DepartmentsId = 5,
                        },
                        new SubDepartments
                        {
                            Id = 25,
                            Name = " الثالث",
                            DepartmentsId = 5,
                        },
                        new SubDepartments
                        {
                            Id = 26,
                            Name = " الرابع",
                            DepartmentsId = 5,
                        },
                        new SubDepartments
                        {
                            Id = 27,
                            Name = " الاول",
                            DepartmentsId = 9,
                        },
                        new SubDepartments
                        {
                            Id = 28,
                            Name = " الثاني",
                            DepartmentsId = 9,
                        },
                        new SubDepartments
                        {
                            Id = 29,
                            Name = " الثالث",
                            DepartmentsId = 9,
                        },
                        new SubDepartments
                        {
                            Id = 30,
                            Name = " الرابع",
                            DepartmentsId = 9,
                        },
                        new SubDepartments
                        {
                            Id = 31,
                            Name = " خريج",
                            DepartmentsId = 9,
                        },
                        new SubDepartments
                        {
                            Id = 32,
                            Name = " خريج",
                            DepartmentsId = 10,
                        },
                         new SubDepartments
                         {
                             Id = 33,
                             Name = " الاول",
                             DepartmentsId = 10,
                         },
                          new SubDepartments
                          {
                              Id = 34,
                              Name = " الثاني",
                              DepartmentsId = 10,
                          },
                           new SubDepartments
                           {
                               Id = 35,
                               Name = " الثالث",
                               DepartmentsId = 10,
                           },
                            new SubDepartments
                            {
                                Id = 36,
                                Name = " الرابع",
                                DepartmentsId = 10,
                            },
                             new SubDepartments
                             {
                                 Id = 37,
                                 Name = " خريج",
                                 DepartmentsId = 10,
                             },
                              new SubDepartments
                              {
                                  Id = 38,
                                  Name = " الاول",
                                  DepartmentsId = 11,
                              },
                              new SubDepartments
                              {
                                  Id = 39,
                                  Name = " الثاني",
                                  DepartmentsId = 11,
                              },
                              new SubDepartments
                              {
                                  Id = 40,
                                  Name = " الثالث",
                                  DepartmentsId = 11,
                              },
                              new SubDepartments
                              {
                                  Id = 41,
                                  Name = " الرابع",
                                  DepartmentsId = 11,
                              },
                              new SubDepartments
                              {
                                  Id = 42,
                                  Name = " خريج",
                                  DepartmentsId = 11,
                              },
                              new SubDepartments
                              {
                                  Id = 43,
                                  Name = " الاول",
                                  DepartmentsId = 12,
                              },
                               new SubDepartments
                               {
                                   Id = 44,
                                   Name = " الثاني",
                                   DepartmentsId = 12,
                               },
                                new SubDepartments
                                {
                                    Id = 45,
                                    Name = " الثالث",
                                    DepartmentsId = 12,
                                },
                                 new SubDepartments
                                 {
                                     Id = 46,
                                     Name = " الرابع",
                                     DepartmentsId = 12,
                                 },
                                  new SubDepartments
                                  {
                                      Id = 47,
                                      Name = " خريج",
                                      DepartmentsId = 12,
                                  },
                                   new SubDepartments
                                   {
                                       Id = 48,
                                       Name = " الاول",
                                       DepartmentsId = 13,
                                   },
                                   new SubDepartments
                                   {
                                       Id = 49,
                                       Name = " الثاني",
                                       DepartmentsId = 13,
                                   },
                                   new SubDepartments
                                   {
                                       Id = 50,
                                       Name = " الثالث",
                                       DepartmentsId = 13,
                                   },
                                   new SubDepartments
                                   {
                                       Id = 51,
                                       Name = " الرابع",
                                       DepartmentsId = 13,
                                   },
                                   new SubDepartments
                                   {
                                       Id = 52,
                                       Name = " خريج",
                                       DepartmentsId = 13,
                                   },
                        new SubDepartments
                        {
                            Id = 12,
                            Name = " الثاني",
                            DepartmentsId = 6,
                        },
                           new SubDepartments
                           {
                               Id = 13,
                               Name = " جميع المستويات",
                               DepartmentsId = 7,
                           },
                              new SubDepartments
                              {
                                  Id = 14,
                                  Name = " لا يوجد",
                                  DepartmentsId = 8,
                              },
                         new SubDepartments
                         {
                             Id = 5,
                             Name = "الاول",
                             DepartmentsId = 6,
                         }


                );
        }
    }
}

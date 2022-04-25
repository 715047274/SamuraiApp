using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;

namespace SamuraiApp.Data.Configurations.Entities
{
    public class SamuraiConfiguration: IEntityTypeConfiguration<Samurai>
    {

        public void Configure(EntityTypeBuilder<Samurai> builder)
        {
            Console.WriteLine("it works");
        }
    }
}
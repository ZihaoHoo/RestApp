using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApp.Shared.Domain;
using System;

namespace RestApp.Server.Configurations.Entities
{
    public class ImageSeedConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = 1,
                    Rest_Name="OpenTable",
                    Img_url = "https://qul.imgix.net/c489aa2b-7abb-47c8-90c1-3138eda84fab/435795_sld.jpg?auto=format&w=230&h=156&fit=crop&ch=Viewport-Width%2CWidth%2CDPR",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Image
                {
                    Id = 2,
                    Rest_Name = "CloseTable",
                    Img_url = "https://qul.imgix.net/efd3bffe-ac27-4dfe-9900-24047f0f105c/383932_sld.jpg?auto=format&w=230&h=156&fit=crop&ch=Viewport-Width%2CWidth%2CDPR",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Image
                {
                    Id = 3,
                    Rest_Name = "FrenchTable",
                    Img_url = "https://qul.imgix.net/48628ed8-c092-4194-a91f-335e9e5170d9/101253_landscape.jpg?auto=format&ch=Viewport-Width%2CWidth%2CDPR",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

namespace gigabyte_homework.Models.Application
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Products.Any()) return; // 避免重複種子

            var products = Enumerable.Range(1, 1000)
                .Select(x => new Product
                {
                    Id = x,
                    Name = "Demo Product",
                    Description = "This is a sample product used for seeding data.",
                    Images = new List<Image>
                    {
                        new Image { ImageName = "Image1", ImageDescription = $"Image1 description", Blob =  File.ReadAllBytes("Assets/image-solid.svg")},
                        new Image { ImageName = "Image2", ImageDescription = $"Image2 description", Blob =  File.ReadAllBytes("Assets/image-solid.svg")},
                        new Image { ImageName = "Image3", ImageDescription = $"Image3 description", Blob =  File.ReadAllBytes("Assets/image-solid.svg")},
                        new Image { ImageName = "Image4", ImageDescription = $"Image4 description", Blob =  File.ReadAllBytes("Assets/image-solid.svg")},
                    },
                    Specifications = new List<Specification>
                    {
                        new Specification { SpecName = "Spec1", SpecDescription = $"Spec1 description" },
                        new Specification { SpecName = "Spec2", SpecDescription = $"Spec2 description" },
                        new Specification { SpecName = "Spec3", SpecDescription = $"Spec3 description" },
                        new Specification { SpecName = "Spec4", SpecDescription = $"Spec4 description" }
                    },
                    RelatedNews = new List<News>
                    {
                        new News { Title = "News 1", Summary = $"Summary of News 1" },
                        new News { Title = "News 2", Summary = $"Summary of News 2" },
                        new News { Title = "News 3", Summary = $"Summary of News 3" },
                        new News { Title = "News 4", Summary = $"Summary of News 4" },
                        new News { Title = "News 5", Summary = $"Summary of News 5" },
                    },
                    Tags = new List<Tag>
                    {
                        new Tag { TagName = "Tag1", TagDescription = $"Tag1 description"},
                        new Tag { TagName = "Tag2", TagDescription = $"Tag2 description"},
                        new Tag { TagName = "Tag3", TagDescription = $"Tag3 description"},
                        new Tag { TagName = "Tag4", TagDescription = $"Tag4 description"},
                        new Tag { TagName = "Tag5", TagDescription = $"Tag5 description"},
                    },
                })
                .ToList();

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}

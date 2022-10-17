using API.Models;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(JstoreContext context)
        {
            if (context.Products.Any())
                return;

            var products = new List<Product>
            {

                new Product
                {
                    Name="React Board 101",
                    Description = " Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..",
                    Price= 10100,
                    PictureUrl="/images/products/glove-react1/png",
                    Brand = "Netcore",
                    Type="Boards",
                    QauntityInStock = 120
                },
                new Product
                {
                    Name="OctaBox",
                    Description = " Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..",
                    Price= 10100,
                    PictureUrl="/images/products/glove-react1/png",
                    Brand = "Netcore",
                    Type="lighting",
                    QauntityInStock = 360
                },
                new Product
                {
                    Name="RCahier Chargerer",
                    Description = " Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..",
                    Price= 10100,
                    PictureUrl="/images/products/glove-react1/png",
                    Brand = "Netcore",
                    Type="Electorincs",
                    QauntityInStock = 1500
                },
                new Product
                {
                    Name="Tulips",
                    Description = " Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..",
                    Price= 10100,
                    PictureUrl="/images/products/glove-react1/png",
                    Brand = "Netcore",
                    Type="Flowers",
                    QauntityInStock = 5846
                },
                new Product
                {
                    Name="Damascus Knife",
                    Description = " Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..",
                    Price= 10100,
                    PictureUrl="/images/products/glove-react1/png",
                    Brand = "K&F",
                    Type="utensils",
                    QauntityInStock = 1500
                },

            };

            foreach (var product in products)
            {
                context.Products.Add(product);

            }
            context.SaveChanges();
        }
    }
}

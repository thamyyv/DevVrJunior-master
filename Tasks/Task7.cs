using System.Collections.Generic;
using Tasks.HelpClasses;

namespace Tasks
{

    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock()
        {
            var repository = new Repository();
            List<Product> products = repository.Products;
            List<string> nameProductOutStock = new List<string>();

            foreach (Product product in products)
            {
                if (product.Stock.Quantity == 0)
                {
                    nameProductOutStock.Add(product.Name);
                }
            }
            return nameProductOutStock;
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock()
        {
            var repository = new Repository();
            List<Product> products = repository.Products;
            int totalQuantity = 0;


            foreach (Product product in products)
            {

                totalQuantity += product.Stock.Quantity;

            }
            return totalQuantity;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity)
        {
            var repository = new Repository();
            List<Product> products = repository.Products;
            Product product = products.Find(item => item.Id == productId);

            if (product == null)
            {
                return false;
            }
            else if (product.Stock.Quantity >= orderQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using hw11;

ProductsService _productsService = new ProductsService();

while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Please select the desired option");
        Console.WriteLine("1. Create a new product");
        Console.WriteLine("2. Display the list of products along with the name of the category");
        Console.WriteLine("3. Product display based on ID along with category name");
        Console.WriteLine("4. Edit product specifications");
        Console.WriteLine("5. Remove the product");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {

            case 1:
                Console.Clear();
                Console.Write("Pls Enter The Name: ");
                string name = Console.ReadLine();
                Console.Write("Pls Enter The CategoryId: ");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pls Enter The Price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                _productsService.Creat(name, cid, price);
                Console.ReadKey();

                break;
            case 2:
                Console.Clear();
                _productsService.ProductsList();
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Console.Write("Please enter the desired product ID : ");
                int idd = Convert.ToInt32(Console.ReadLine());
                _productsService.GettId(idd);
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.Write("Please enter the desired product ID: ");
                int idb = Convert.ToInt32(Console.ReadLine());
                _productsService.GettId(idb);
                Console.Write("Pls Enter The New CategoryId: ");
                int cidd = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pls Enter The New Price: ");
                int pricee = Convert.ToInt32(Console.ReadLine());
                _productsService.UpdatePr(idb, _productsService.getName(idb), cidd, pricee);

                break;
            case 5:
                Console.Write("Please enter the desired product ID: ");
                int ii = Convert.ToInt32(Console.ReadLine());
                _productsService.DeletPr(ii);
                break;
            default:
                Console.WriteLine("There is no choice");
                Console.ReadKey();
                break;



        }





    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected Error: {ex.Message}");
        Console.ReadKey();
    }
}







namespace Sales.ViewModels
{
    using Sales.Common.Models;
    using Sales.Services;
    using System.Collections.ObjectModel;
    public class ProductsViewModel: BaseViewModel
    {
        private ApiService aspiService;

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ProductsViewModel()
        {
            this.aspiService = new ApiService();
            this.LoadProducts();
        }
         private async void LoadProducts()
        {
           var response = await this.aspiService.GetList<Product>("","","") //aca van los datos de coneccion al sevicio
        }
    }
}

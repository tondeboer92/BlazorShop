BlazorShopApp

BlazorShopApp is a simple Blazor WebAssembly application designed to demonstrate a basic e-commerce storefront. Users can browse products, add them to a cart, and proceed to checkout.

Features
Product Listing: Displays a list of products with basic details.
Product Details: View detailed information about a specific product.
Shopping Cart: Add products to a shopping cart and view the cart contents.
Checkout: Enter customer details and proceed to order confirmation.
LocalStorage: Cart and Customer data is kept in local storage.


Getting Started

Prerequisites
.NET SDK 8.0

Installation

Clone the repository:
git clone https://github.com/yourusername/BlazorShopApp.git
cd BlazorShopApp

Restore dependencies:
dotnet restore


Build the project:
dotnet build

Run the application:
dotnet run --project BlazorShopApp.Client



Usage

Home Page: The home page displays a list of products.
Product Details: Click on a product to view its details.
Add to Cart: Click the "Add to Cart" button on a product to add it to the shopping cart.
View Cart: Navigate to the cart to see added products.
Checkout: Enter customer details and submit the order to see a confirmation.

Project Structure
BlazorShopApp.Client: The main Blazor WebAssembly project.

wwwroot: Contains static files such as CSS, JS, and images.

Components:
ProductList.razor: Displays the list of products.
ProductDetails.razor: Shows detailed information about a product.
Cart.razor: Displays the shopping cart contents.


Models
Product.cs: Represents a product in the store.
Customer.cs: Represents customer details for the checkout process.


Sample Data
Sample data is hardcoded in the project for demonstration purposes. You can find it in the ProductService class.

Contributing
Contributions are welcome! Please open an issue or submit a pull request for any features, bugs, or enhancements.

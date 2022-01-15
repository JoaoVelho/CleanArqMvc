using CleanArqMvc.Domain.Validation;

namespace CleanArqMvc.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;

            ValidateDomain();
        }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;

            ValidateDomain();
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
            CategoryId = categoryId;

            ValidateDomain();
        }

        private void ValidateDomain()
        {
            DomainExceptionValidation.When(Id < 0, "Invalid Id value");

            DomainExceptionValidation.When(string.IsNullOrEmpty(Name), "Invalid name. Name is required");
            DomainExceptionValidation.When(Name.Length < 3, "Invalid name, too short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(Description), "Invalid description. Description is required");
            DomainExceptionValidation.When(Description.Length < 5, "Invalid description, too short, minimum 5 characters");

            DomainExceptionValidation.When(Price < 0, "Invalid Price value");

            DomainExceptionValidation.When(Stock < 0, "Invalid Stock value");

            DomainExceptionValidation.When(Image.Length > 250, "Invalid image name, too long, maximum 250 characters");
        }
    }
}

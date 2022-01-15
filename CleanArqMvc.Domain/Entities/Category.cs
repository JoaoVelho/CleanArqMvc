using CleanArqMvc.Domain.Validation;
using System.Collections.Generic;

namespace CleanArqMvc.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }

        public Category(string name)
        {
            Name = name;

            ValidateDomain();
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;

            ValidateDomain();
        }

        public void Update(string name)
        {
            Name = name;

            ValidateDomain();
        }

        private void ValidateDomain()
        {
            DomainExceptionValidation.When(Id < 0, "Invalid Id value");

            DomainExceptionValidation.When(string.IsNullOrEmpty(Name), "Invalid name. Name is required");
            DomainExceptionValidation.When(Name.Length < 3, "Invalid name, too short, minimum 3 characters");
        }
    }
}

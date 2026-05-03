namespace Dsw2026Ej8.Problema3
{
    public class Product
    {
        public string Description;

        public Product(string description)
        {
            Description = description;
        }

        public void ModificarDescription(string description)
        {
            Description = description;
        }

        public string GetDescription()
        {
            return Description;
        }

    }
}
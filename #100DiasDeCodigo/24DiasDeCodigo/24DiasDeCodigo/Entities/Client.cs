// GetHashCode e Equals

namespace _24DiasDeCodigo.Entities
{
    internal class Client
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        // Comparando um cliente com outro.
        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
                return false;

            Client? other = obj as Client;
            return Email!.Equals(other!.Email);
        }

        public override int GetHashCode()
        {
            return Email!.GetHashCode();
        }
    }
}

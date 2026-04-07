using System.Reflection.Metadata;

namespace GestaoDePatrimonios.DTOs.AutenticacaoDto
{
    public class LoginDto
    {
        public string NIF { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}

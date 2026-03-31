using GestaoDePatrimonios.Domains;
using GestaoPatrimonios.Domains;
using GestaoPatrimonios.DTOs.UsuarioDto;
using GestaoPatrimonios.Repositories;

namespace GestaoPatrimonios.Applications.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public List<ListarUsuarioDto> Listar()
        {
            List<Usuario> usuarios = _repository.Listar();

            List<ListarUsuarioDto> usuariosDto = usuarios.Select(usuario => new ListarUsuarioDto
            {
                UsuarioID = usuario.UsuarioID,
                NIF = usuario.NIF,
                NomeUsuario = usuario.NomeUsuario,
                RG = usuario.RG,
                CPF = usuario.CPF,
                CarteiraTrabalho = usuario.CarteiraTrabalho,
                Email = usuario.Email,
                Ativo = usuario.Ativo,
                PrimeiroAcesso = usuario.PrimeiroAcesso,
                EnderecoID = usuario.EnderecoID,
                CargoID = usuario.CargoID,
                TipoUsuarioID = usuario.TipoUsuarioID
            }).ToList();

            return usuariosDto;
        }
    }
}
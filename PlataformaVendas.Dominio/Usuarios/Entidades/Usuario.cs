using PlataformaVendas.Dominio.Usuarios.Comandos;
using PlataformaVendas.Dominio.UsuariosExterno.Entidades;
using PlataformaVendas.Dominio.UsuariosLocal.Entidades;
using PlataformaVendas.Dominio.Utils;
using System.ComponentModel.DataAnnotations;

namespace PlataformaVendas.Dominio.Usuarios.Entidades
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string? Cnpj { get; private set; }
        public string Email { get; private set; }
        public EmailConfirmadoEnum EmailConfirmado { get; private set; }
        public DateTime? DataEmailConfirmado { get; private set; }
        public TipoUsuarioEnum TipoUsuario { get; private set; }
        public AtivoInativoEnum Situacao { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataUltimoLogin { get; private set; }

        #region Navegação com os relacionamentos
        // Relacionamento 1:1 com UsuarioLocal
        public UsuarioLocal UsuarioLocal { get; private set; }
        // Relacionamento 1:N com UsuarioExterno
        public ICollection<UsuarioExterno> UsuariosExternos { get; private set; }
        #endregion

        private Usuario() { }

        public Usuario(UsuarioInserirComando comando)
        {
            SetNome(comando.Nome);
            SetCpf(comando.Cpf);
            SetEmail(comando.Email);
            SetCnpj(comando.Cnpj);
            EmailConfirmado = EmailConfirmadoEnum.Pendente;
            TipoUsuario = comando.TipoUsuario;
            Situacao = AtivoInativoEnum.Ativo;
            DataCadastro = DateTime.UtcNow;
            DataUltimoLogin = DateTime.UtcNow;
        }

        public void SetCnpj(string cnpj)
        {
           if (cnpj.Length > 14)
                throw new ArgumentException("O CNPJ do usuário deve conter no máximo 14 caracteres.");

            Cnpj = cnpj;
        }

        public void SetCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("O CPF do usuário é obrigatório.");

            if (cpf.Length != 11)
                throw new ArgumentException("O CPF do usuário deve conter 11 caracteres.");

            Cpf = cpf;
        }

        public void SetNome(string nome)
        {
            if(string.IsNullOrEmpty(nome))
                throw new ArgumentException("O nome do usuário é obrigatório.");

            if (nome.Length < 4)
                throw new ArgumentException("O nome do usuário deve conter no mínimo 4 caracteres.");

            Nome = nome;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("O email do usuário é obrigatório.");

            if (!new EmailAddressAttribute().IsValid(email))
                throw new ArgumentException("E-mail inválido!");

            Email = email;
        }
    }
}

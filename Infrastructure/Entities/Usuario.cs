using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Usuario
    {
        public long Id { get; set; }

        [Column("id_perfil")]
        public int IdPerfil { get; set; }

        [Column("id_tipo_usuario")]
        public int? IdTipoUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }

        [Column("cpf_cnpj")]
        public string CpfCnpj { get; set; }
        public DateTime? Validade { get; set; }
        public DateTime Inclusao { get; set; }
        public DateTime? Alteracao { get; set; }
        public bool Ativo { get; set; }

        [Column("data_ultimo_acesso")]
        public DateTime? DataUltimoAcesso { get; set; }

        public virtual List<PermissaoUsuario> Permissoes { get; set; }
        [NotMapped]
        public virtual Perfil Perfil { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual List<UsuarioEmpresa> Empresas { get; set; }
    }

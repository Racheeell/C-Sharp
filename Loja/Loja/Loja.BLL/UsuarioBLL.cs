using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL;
using Loja.DTO;

namespace Loja.BLL
{
	/*	A camada BLL chamará as camadas DAL e DTO para 
	 *	acessar o banco. Desse modo, insira o código a seguir
	 *	abaixo de using System.Threading.Tasks*/
	public class UsuarioBLL 
	{
	/* Método cargaUsuario, retorna uma lista de objetos usuario DTO
	 * (composto por varios atributos), vai ate o BD e busca todos os usuarios.
	 * Usamos o try e catch caso de algum erro, retorna para a camada view
	 * Executar o metodo cargaUsuario (será criado na DAL)*/
	public IList<usuario_DTO> cargaUsuario()
		{
			try
			{
				return new UsuarioDAL().cargaUsuario();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int insereUsuario(usuario_DTO_USU)
		{
			//Insere usuario sera criado na DAL
			try
			{
				return new UsuarioDAL().insereUsuario(USU);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int alteraUsuario(usuario_DTO_USU)
		{
			//Insere usuario sera criado na DAL
			try
			{
				return new UsuarioDAL().alteraUsuario(USU);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int editaUsuario (usuario_DTO USU)
		{
			try
			{
				return new UsuarioDAL().editaUsuario(USU);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int deletaUsuario (usuario_DTO USU)
		{
			try
			{
				return new UsuarioDAL().deletaUsuario(USU);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}

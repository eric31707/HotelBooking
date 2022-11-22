using BookingForm.Infra.DAOs;
using BookingForm.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookingForm.Models.DTOs.UsersDTO;

namespace BookingForm.Models.DTOs
{
	public class UserService
	{
		private UserDAO _dao;

		public UserService()
		{
			_dao = new UserDAO();
		}

		public void Create(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Create(model);

		}

		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Name = row.Field<string>("Name")
			};
		}

		internal void Update(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");
			new UserDAO().Update(model);
		}

		internal void Delete(int id)
		{
			_dao.Delete(id);
		}

		public bool Authenticate(LoginVM model, out UserDTO userLogin)
		{
			userLogin = new UserDTO();
			bool valid = false;
			var user = _dao.Get(model.Account);
			if ( user!=null && user.Password == model.Password)
			{
				valid = true;
				userLogin=user;				
			}			
			return valid;
		}
	}
}

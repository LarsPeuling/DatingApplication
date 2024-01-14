//using Microsoft.VisualBasic;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatingApplication.MVVM.Models;

namespace DatingApplication
{
    public class UserRepository
    {
        SQLiteConnection connection;
        public string? statusMessage { get; set; }
        public UserRepository()
        {
            connection = new SQLiteConnection(
                Contstants.DatabasePath,
                Contstants.flags);
            connection.CreateTable<User>();
        }

        public void AddOrUpdate(User user)
        {
            int result = 0;
            try
            {
                if (user.Id != 0) 
                {
                    result = connection.Update(user);
                    statusMessage = $"{result} row(s) updated";
                }
                else
                {
                    result = connection.Insert(user);
                    statusMessage = $"{result} row(s) added";
                }
                
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public List<User>? GetAll()
        {
            try
            {
                return connection.Table<User>().ToList();
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public User? Get(int id)
        {
            try
            {
                return connection.Table<User>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void Delete(int id)
        {
            try
            {
                User user = Get(id);
                connection.Delete(user);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
    }
}

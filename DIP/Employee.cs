using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }

    public interface IRepositoryLayer
    {
        void Save(Employee emp);
    }
    public class BusinessLogicLayer : IRepositoryLayer
    {
        private readonly IRepositoryLayer _repository;
        public BusinessLogicLayer(IRepositoryLayer repository)
        {
            _repository = repository;
        }
        public void Save(Employee emp)
        {
            _repository.Save(emp);
        }
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(Employee emp)
        {
            // Save to database.
        }
    }




}

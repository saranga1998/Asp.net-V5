using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyMvcApp.Models;

public interface IissueRepo{

    Task <List<BookModel>> GetAllBooks(); 

    Task <List<CustomerModel>> GetAllMembers();
}
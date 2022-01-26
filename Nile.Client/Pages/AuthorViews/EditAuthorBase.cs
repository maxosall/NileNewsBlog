using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Nile.Client.Models;
using Nile.Client.Services;
using Nile.lib;

namespace Nile.Client.Pages.AuthorViews
{
    public class EditAuthorBase : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public string DepartmentId { get; set; }
        private Author Author { get; set; } = new Author();
        public EditAuthorModel EditAuthorModel { get; set; } = new EditAuthorModel();

        [Inject]
        public IAuthorService AuthorService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Author = await AuthorService.GetAuthorById(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();
            DepartmentId = Author.DepartmentId.ToString();

            EditAuthorModel.AuthorId = Author.AuthorId;
            EditAuthorModel.FirstName = Author.FirstName;
            EditAuthorModel.LastName = Author.LastName;
            EditAuthorModel.Gender = Author.Gender;
            EditAuthorModel.Bio = Author.Bio;
            EditAuthorModel.DateOfBirth = Author.DateOfBirth;
            EditAuthorModel.Email = Author.Email;
            EditAuthorModel.ConfirmEmail = Author.Email;
            EditAuthorModel.DepartmentId = Author.DepartmentId;
            EditAuthorModel.Department = Author.Department;
            EditAuthorModel.Articles = Author.Articles;
            EditAuthorModel.PhotoPath = Author.PhotoPath;
        }

        public void HandleEditAuthor()
        {

        }
    }
}
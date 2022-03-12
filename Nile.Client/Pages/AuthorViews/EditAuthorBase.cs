using AutoMapper;
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
        [Inject]
        public IMapper Mapper { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string PageHeaderText { get; set; }
        public string SaveButtonText { get; set; }
        public string DepartmentId { get; set; }
        private Author Author { get; set; } = new Author();

        public EditAuthorModel EditAuthorModel { get; set; } = new EditAuthorModel();

        [Inject]
        public IAuthorService AuthorService { get; set; }


        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int authorId);

            if (authorId != 0)
            {
                PageHeaderText = "Edit Author";
                SaveButtonText = "Save Changes";
                Author = await AuthorService.GetAuthorById(int.Parse(Id));
            }
            else
            {
                PageHeaderText = "Create Author";
                SaveButtonText = "Save";
                Author = new Author
                {
                    DateOfBirth = DateTime.Now,
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhotoPath = "img/a_7.jfif"
                };
            }


            Departments = (await DepartmentService.GetDepartments()).ToList();
            DepartmentId = Author.DepartmentId.ToString();

            Mapper.Map(Author, EditAuthorModel);
        }

        protected async Task HandleEditAuthor()
        {
            Mapper.Map(EditAuthorModel, Author);
            Author result = await CreateAndSaveAuthor();

            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        private async Task<Author> CreateAndSaveAuthor()
            => Author.AuthorId != 0
                ? await AuthorService.UpdateAuthor(Author)
                : await AuthorService.CreateAuthor(Author);

        protected async Task HandleDeleteAuthor()
        {
            await AuthorService.DeleteAuthor(Author.AuthorId);
            NavigationManager.NavigateTo("/");
        }
        protected async Task Handle_SaveAndAddAnothorOne()
        {
            Mapper.Map(EditAuthorModel, Author);
            Author result = await CreateAndSaveAuthor();
            if (result != null)
            {
                Author = new Author
                {

                    FirstName = "",
                    LastName = string.Empty,
                    Email = string.Empty,
                    DepartmentId = 4,
                    Bio = string.Empty
                };
                NavigationManager.NavigateTo("Author/Create");
            }
        }
    }
}


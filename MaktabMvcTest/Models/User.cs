using MaktabMvcTest.ViewModels;

namespace MaktabMvcTest.Models
{
    public class User
    {
        public User(AddUserViewModel userViewModel)
        {
            FirstName = userViewModel.FirstName;
            LastName = userViewModel.LastName;
        }
        public int Id { get; set; } = Random.Shared.Next(100, 10000);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}

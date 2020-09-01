using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Mocks
{
    public class MockAuthRepository
    {
        public List<MockUser> MockUsers = new List<MockUser>
        {
            new MockUser { Id = 1, FirstName = "Obinna", LastName = "Osuji", Email = "oosuji@medismarts.com.ng", Password = "oosuji", Role = "Admin"},
            new MockUser { Id = 2, FirstName = "Ujunwa", LastName = "Anusionwu", Email = "uanusionwu@medismarts.com.ng", Password = "uanusionwu", Role = "Doctor"},
            new MockUser { Id = 3, FirstName = "Joy", LastName = "Aghogho", Email = "jaghogho@medismarts.com.ng", Password = "jaghogho", Role = "Nurse"},
            new MockUser { Id = 4, FirstName = "Victor", LastName = "Mbarachi", Email = "vmbarachi@medismarts.com.ng", Password = "vmbarachi", Role = "Doctor"},
            new MockUser { Id = 5, FirstName = "Victor", LastName = "Onyebuchi", Email = "vonyebuchi@medismarts.com.ng", Password = "vonyebuchi", Role = "Staff"},
            new MockUser { Id = 6, FirstName = "Gbenga", LastName = "Adeyeye", Email = "gadeyeye@medismarts.com.ng", Password = "gadeyeye", Role = "Nurse"},
            new MockUser { Id = 7, FirstName = "Oghenetega", LastName = "Akprese", Email = "oakprese@medismarts.com.ng", Password = "oakprese", Role = "Staff"},
        };

        public MockUser Login(string username, string password) => MockUsers.FirstOrDefault(x => x.Email == username && x.Password == password);
 
    }

    public class MockUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

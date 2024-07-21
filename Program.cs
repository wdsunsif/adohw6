using Adohw6;

UserContex db = new UserContex();

User user = new User() { Login = "Faig", Password = "20088" };

db.Add(user);
db.SaveChanges();
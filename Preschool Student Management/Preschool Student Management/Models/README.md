# Các sử dụng các model

## Cách lấy dữ liệu

Nếu khởi tạo một model với không tham số thì nó sẽ coi như một `query builder`

```cs
	using Preschool_Student_Management.Models;

	// Lấy user đầu tiên có name = Le Dinh hoặc có username nằm trong {"ledinh", "ledinh2"}
	var user = (new User()).Where("name", "=", "Le Dinh").WhereIn("username", new List<string>{"ledinh", "ledinh2"}, "OR").First();

	// Lấy tất cả user có name = Le Dinh
	var users = (new User()).Where("name", "=", "Le Dinh").Get();

	// Lấy một phần user có name = Le Dinh
	var users = (new User()).Where("name", "=", "Le Dinh").Slide(1,2);

	// Lấy tất cả classrooms và các students của nó
	var classrooms = (new Classroom()).WithStudents().Get();

	// Lấy tất cả classrooms và các students của nó và cả người tạo classroom `user`
	var classrooms = (new Classroom()).WithStudents().WithUser().Get();
```

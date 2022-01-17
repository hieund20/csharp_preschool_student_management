# Các sử dụng các model

## Cách lấy dữ liệu

Trên mỗi model sẽ có một static property là `Query` sử dụng đó để xây dụng chuỗi query

```cs
	using Preschool_Student_Management.Models;

	var userQueryBuilder = User.Query;
```

### Thêm điều kiện vào query builder

`ToSql` method là một method đặc biệt để lấy kết quả chuỗi truy vấn đã xây dựng (thường sử dụng để debug);

```cs
	using Preschool_Student_Management.Models;

	// Lấy những người dùng có name là "Le Dinh" hoặc có username nằm trong "ledinh", "ledinh2"
	// SELECT * FROM `users` WHERE `name` = "Le Dinh" OR `username` IN ("ledinh", "ledinh2")
	User.query.Where("name", "=", "Le Dinh").WhereIn("username", new List<string>{"ledinh", "ledinh2"}, "OR").ToSql();

	// Nếu where or nằm ở đầu thì điều đó không có ý nghĩa
	// SELECT * FROM `users` WHERE `name` = "Le Dinh" AND `username` = "ledinh"
	User.query.Where("name", "=", "Le Dinh", "OR").Where("username", "=", "ledinh")
```

### Thêm mỗi quan hệ vào câu query

Ví dụ một lớp học có nhiều học sinh, chúng ta muốn khi lấy lớp học sẽ đính kèm tất cả học sinh vào lớp học

Chú ý các câu truy cấn lấy mối quan hệ cần đặt trước điều kiện của query builder

```cs
	// Lấy lớp có mã là M11 và các học sinh của lớp và người tạo lớp này
	Classroom.Query.WithStudents().WithUser().Where("name", "=", "M11").ToSql();
```

### Cuối cùng lấy dữ liệu ta

Tất nhiên method lấy dữ liệu phải để ở cuối câu query

```cs
	// Lấy tất cả học sinh thoả điều kiện `Get()`
	Student.Query.WithClassroom.Where("first_name", "=" ,"Le Dinh").Get();

	// Lấy cái đầu tiên thoả điều 
	Student.Query.WithClassroom.Where("first_name", "=" ,"Le Dinh").First();

	// Lấy cái cuối tiên thoả điều 
	Student.Query.WithClassroom.Where("first_name", "=" ,"Le Dinh").OrderBy("id", "DESC").First();

	// Lấy kết quả từ vị trí 2 đến 10
	Student.Query.WithClassroom.Where("first_name", "=" ,"Le Dinh").OrderBy("id", "DESC").Slice(2, 10);

	// Lấy cái đầu tiên thoả điều kiện và thêm luân câu lệnh where primary key `id`
	// Lấy student có id là 1
	Student.Query.WithClassroom.Find("1");
```
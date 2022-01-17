# Các sử dụng các model

## Cách lấy dữ liệu

Nếu khởi tạo một model với không tham số thì nó sẽ coi như một `query builder`

```cs
	using Preschool_Student_Management.Models;

	// Lấy user đầu tiên có name = Le Dinh
	var user = (new User).Where("name", "=", "Le Dinh").First();

	// Lấy tất cả user có name = Le Dinh
	var users = (new User).Where("name", "=", "Le Dinh").Get();

	// Lấy một phần user có name = Le Dinh
	var users = (new User).Where("name", "=", "Le Dinh").Slide(1,2);
```
